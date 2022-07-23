using HtmlAgilityPack;
using System.Xml.Linq;
using Tracker.Domain.Dto;
using Tracker.Domain.Enum;

namespace Tracker.Domain.Service
{
    public class ConsultService : IConsultService
    {
        private HttpClient? _client;

        private IList<GuildData> _trackingGuilds;

        private string _websiteAddress;

        private Counters _counters;

        public ConsultService(string websiteAddress)
        {
            _websiteAddress = websiteAddress;
            _trackingGuilds = new List<GuildData>();
            _counters = new Counters();
        }

        public Counters GetCounters()
        {
            return _counters;
        }

        public void AddToTrack(GuildData guildData)
        {
            _trackingGuilds.Add(guildData);
        }

        public void RemoveFromTrack(GuildData guildData)
        {
            _trackingGuilds.Remove(guildData);
        }

        public void ClearTrack()
        {
            _trackingGuilds.Clear();
        }

        public IList<GuildData> GetTrackingGuilds()
        {
            return _trackingGuilds;
        }

        public void TrackingCreated(GuildData guild)
        {
            _trackingGuilds.FirstOrDefault(x => x == guild).RunningThread = true;
        }

        public void TrackingEnded(GuildData guild)
        {
            _trackingGuilds.FirstOrDefault(x => x == guild).RunningThread = false;
        }

        public IList<GuildData> SearchGuilds(ServerEnum server, string guildName)
        {
            InitializeClient();

            var guildList = new List<GuildData>();

            var taskSearchGuilds = _client?.GetAsync($"/priston/clans.php?p=1&s={server.GetHashCode()}&b={guildName}");

            if (taskSearchGuilds != null && taskSearchGuilds.Result.IsSuccessStatusCode)
            {
                var xmlResponseTask = taskSearchGuilds.Result.Content.ReadAsStringAsync();

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(xmlResponseTask.Result);

                var guildsNode = htmlDoc.DocumentNode.SelectNodes("//div/div/div/div/div/div").FirstOrDefault(x => x.InnerHtml.Contains("listaClans"))?.ChildNodes[5];

                foreach (var subNode in guildsNode.ChildNodes.Where(x => x.Name == "div"))
                {
                    var splitted = subNode.InnerText.Split("\n").Where(x => !string.IsNullOrEmpty(x)).ToList();

                    var guildData = new GuildData();
                    guildData.GuildName = splitted[0];
                    guildData.LeaderName = splitted[1];
                    guildData.GuildServer = server;
                    guildData.Members = Convert.ToByte(splitted[3]);

                    var guildIdNode = subNode.ChildNodes[1].ChildNodes[1].Attributes["href"].Value;

                    guildData.GuildId = Convert.ToInt32(guildIdNode.Split("=").Last().Split(";").First());

                    guildList.Add(guildData);
                }
            }

            return guildList;
        }

        public IList<GuildData> ConsultGuilds(string email, string pass)
        {
            var guilds = _trackingGuilds.Where(x => x.RunningThread == false).ToList();

            if (!guilds.Any())
                return new List<GuildData>();

            InitializeClient();

            //DoLogin
            var loginContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("c2", pass),
                new KeyValuePair<string, string>("x", "56"),
                new KeyValuePair<string, string>("y", "16")
            });

            var loginResult = _client?.PostAsync("/priston/login.php", loginContent);

            if (loginResult != null && loginResult.Result.IsSuccessStatusCode)
            {
                var tasks = guilds.Select(async guild =>
                {
                    guild.RunningThread = true;
                    guild.MemberList = await ConsultGuildMembers(guild);
                    guild.RunningThread = false;
                });

                Task.WhenAll(tasks);
            }
            else
            {
                throw new Exception("Login failed. Check your login info on 'Settings' tab.");
            }

            return guilds;
        }

        public async Task<IList<GuildMember>> ConsultGuildMembers(GuildData guild)
        {
            var result = await _client?.GetAsync($"/priston/clan.php?id={guild.GuildId};{guild.GuildServer.GetHashCode()}");

            _counters.ConsultedGuild();

            if (result.IsSuccessStatusCode)
            {
                guild.MemberList.Clear();

                var xmlResponse = await result.Content.ReadAsStringAsync();

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(xmlResponse);

                var clanMembersNode = htmlDoc.DocumentNode.SelectNodes("//div");
                var clanMembersSubNode = clanMembersNode.FirstOrDefault(x => x.Attributes["class"]?.Value == "listaClans");

                if (clanMembersSubNode != null)
                {
                    foreach (var memberDiv in clanMembersSubNode.ChildNodes.Where(x => x.Name == "div"))
                    {
                        var memberName = memberDiv.ChildNodes[3].InnerHtml;

                        if (!string.IsNullOrEmpty(memberName))
                        {
                            guild.MemberList.Add(new GuildMember()
                            {
                                Name = memberName
                            });
                        }
                    }
                }
            }

            var tasks = guild.MemberList.Select(async member =>
            {
                await ConsultMember(guild.GuildServer, member);
            });

            await Task.WhenAll(tasks);

            return guild.MemberList;
        }

        public async Task ConsultMember(ServerEnum server, GuildMember guildMember)
        {
            var xDoc = new XDocument();
            int tryLimit = 5;

            while (true)
            {
                if (tryLimit <= 0)
                    break;

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("servidor", server.ToString()),
                    new KeyValuePair<string, string>("info", guildMember.Name)
                });

                var result = await _client?.PostAsync("/priston/ranking.php", content);

                _counters.ConsultedPlayer();

                if (result.IsSuccessStatusCode)
                {
                    var xmlResponse = await result.Content.ReadAsStringAsync();

                    xmlResponse = xmlResponse.Replace("<br class=\"clearfloat\">", string.Empty);
                    xmlResponse = "<Conteudo>" + xmlResponse + "</Conteudo>";

                    try
                    {
                        xDoc = XDocument.Parse(xmlResponse);
                    }
                    catch
                    {
                        tryLimit--;
                    }

                    var information = xDoc.Descendants().FirstOrDefault(x => x.Name.LocalName == "div" && x.FirstAttribute?.Value == "informacoes");

                    var currentLocation = information?.Descendants().Last().Value ?? "Unknow";

                    if (!string.IsNullOrEmpty(currentLocation))
                    {
                        if (!string.IsNullOrEmpty(guildMember.CurrentLocation))
                            guildMember.LastLocation = guildMember.CurrentLocation;

                        guildMember.CurrentLocation = currentLocation;
                    }
                }

                break;
            }
        }

        private void InitializeClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_websiteAddress);
            _client.DefaultRequestHeaders.Add("user-agent", "common access");
            _client.Timeout = TimeSpan.FromHours(12);
        }
    }
}
