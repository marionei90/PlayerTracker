using System.Xml.Serialization;
using Tracker.Domain.Dto;
using Tracker.Domain.Enum;

namespace Tracker.Infraestructure
{
    [Serializable]
    [XmlRoot("TrackerSettings")]
    public class SettingsXml
    {
        [XmlElement("TrackerList")]
        public TrackerList List { get; set; }

        public SettingsXml()
        {
            List = new TrackerList();

            Notifications = new Notifications();

            Settings = new Settings();
        }

        [XmlElement("Notifications")]
        public Notifications Notifications { get; set; }

        [XmlElement("Settings")]
        public Settings Settings { get; set; }
    }

    public class TrackerList
    {
        [XmlElement("Guild")]
        public List<Guild> Guilds { get; set; }

        public TrackerList()
        {
            Guilds = new List<Guild>();
        }
    }

    public class Guild
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("LeaderName")]
        public string LeaderName { get; set; }

        [XmlAttribute("Members")]
        public byte Members { get; set; }

        [XmlAttribute("Server")]
        public ServerEnum Server { get; set; }

        public Guild(GuildData guildData)
        {
            Id = guildData.GuildId;
            Name = guildData.GuildName;
            LeaderName = guildData.LeaderName;
            Members = guildData.Members;
            Server = guildData.GuildServer;
        }

        public Guild()
        {
            Id = 1;
            Name = "GenericGuild";
            LeaderName = "GenericLeader";
            Members = 1;
            Server = ServerEnum.Awell;
        }
    }

    public class Notifications
    {
    }

    public class Settings
    {
        [XmlElement("GeneralSettings")]
        public GeneralSettings GeneralSettings { get; set; }

        [XmlElement("Access")]
        public Access Access { get; set; }

        public Settings()
        {
            GeneralSettings = new GeneralSettings();

            Access = new Access();
        }
    }

    public class GeneralSettings
    {
        [XmlElement("ConsultInterval")]
        public int ConsultInterval { get; set; }

        public GeneralSettings()
        {
            ConsultInterval = 30;
        }
    }

    public class Access
    {

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("Password")]
        public string Password { get; set; }

        public Access()
        {
            Email = "bpristont8@gmail.com";
            Password = "priston@123";
        }
    }
}
