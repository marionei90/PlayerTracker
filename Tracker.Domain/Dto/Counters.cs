namespace Tracker.Domain.Dto
{
    public class Counters
    {
        private DateTime _startDate { get; set; }
        private int _totalGuildConsults { get; set; }
        private int _totalPlayerConsults { get; set; }
        private int _totalNotifications { get; set; }

        public DateTime StartDate { get; set; }

        public string TotalGuildConsults
        {
            get
            {
                return _totalGuildConsults.ToString();
            }
        }

        public string TotalPlayerConsults
        {
            get
            {
                return _totalPlayerConsults.ToString();
            }
        }

        public string TotalNotifications
        {
            get
            {
                return _totalNotifications.ToString();
            }
        }

        public Counters()
        {
            _startDate = DateTime.Now;
            _totalGuildConsults = 0;
            _totalPlayerConsults = 0;
            _totalNotifications = 0;
        }

        public void Reset()
        {
            _startDate = DateTime.Now;
            _totalGuildConsults = 0;
            _totalPlayerConsults = 0;
            _totalNotifications = 0;
        }

        public void ConsultedGuild()
        {
            _totalGuildConsults++;
        }

        public void ConsultedPlayer()
        {
            _totalPlayerConsults++;
        }
    }
}
