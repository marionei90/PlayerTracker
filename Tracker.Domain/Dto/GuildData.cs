using Tracker.Domain.Enum;

namespace Tracker.Domain.Dto
{
    public class GuildData
    {
        public int GuildId { get; set; }
        public DateTime ConsultDate { get; set; }
        public string LeaderName { get; set; }
        public string GuildName { get; set; }
        public ServerEnum GuildServer { get; set; }
        public byte Members { get; set; }
        public bool RunningThread { get; set; }
        public IList<GuildMember> MemberList { get; set; }

        public GuildData()
        {
            ConsultDate = DateTime.Now;
            LeaderName = string.Empty;
            GuildName = string.Empty;
            RunningThread = false;
            MemberList = new List<GuildMember>();
        }
    }
}
