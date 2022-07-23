namespace Tracker.Domain.Dto
{
    public class GuildMember
    {
        public string Name { get; set; }
        public string CurrentLocation { get; set; }
        public string LastLocation { get; set; }

        public bool MapChanged
        {
            get
            {
                return !string.IsNullOrEmpty(LastLocation) &&
                    !string.IsNullOrEmpty(CurrentLocation) &&
                    CurrentLocation != "Nenhuma" &&
                    LastLocation != "Nenhuma" &&
                    CurrentLocation != "Unknow" &&
                    LastLocation != "Unknow" &&
                    CurrentLocation != LastLocation;
            }
        }

        public GuildMember()
        {
            Name = string.Empty;
            CurrentLocation = string.Empty;
            LastLocation = string.Empty;
        }
    }
}
