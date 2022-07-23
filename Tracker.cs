using System.ComponentModel;
using Tracker.Domain.Dto;
using Tracker.Domain.Enum;
using Tracker.Domain.Service;
using Tracker.Infraestructure;

namespace PlayerTracker
{
    public partial class Tracker : Form
    {
        private TrackerStatusEnum _trackerStatus;
        private ConsultService _consultService;
        private IList<GuildData> _foundGuilds;
        private Configuration _configuration;
        private SettingsXml _settings;
        private object _lock;

        public Tracker()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _trackerStatus = TrackerStatusEnum.Stopped;
            _consultService = new ConsultService(textBoxWebsiteAddress.Text);
            _foundGuilds = new List<GuildData>();
            _configuration = new Configuration();
            _settings = _configuration.LoadSettings();
            _lock = new object();

            StartConfiguration();

            StartUpdater();
        }

        private void StartUpdater()
        {
            var thread = new Thread(new ThreadStart(Updater));
            thread.Start();
        }

        public void Updater()
        {
            while (true)
            {
                UpdateGrid();

                SetCounters(_consultService.GetCounters());

                Thread.Sleep(10000);
            }
        }

        private void UpdateGrid()
        {
            if (dataGridLastConsults.InvokeRequired)
            {
                dataGridLastConsults.Invoke(new Action(UpdateGrid));
                return;
            }

            var consultedGuilds = _consultService.GetTrackingGuilds();

            foreach (var guild in consultedGuilds)
            {
                foreach (var member in guild.MemberList)
                {
                    if(!string.IsNullOrEmpty(member.CurrentLocation))
                        dataGridLastConsults.Rows.Add(guild.ConsultDate, guild.GuildName, member.Name, member.CurrentLocation, member.LastLocation);

                    if (member.MapChanged
                        /*&& _notificationMaps.Contains(member.CurrentLocation)*/)
                    {
                        TrayNotification($"{member.Name} entered {member.CurrentLocation}.");
                    }
                }
            }

            //dataGridLastConsults.Sort(dataGridLastConsults.Columns["gridDateColumn"], ListSortDirection.Descending);
            Refresh();
        }

        private void StartConfiguration()
        {
            //List
            foreach (var guild in _settings.List.Guilds)
            {
                listBoxCurrentTracking.Items.Add(guild.Name);
            }

            //Notifications


            //Settings
            textBoxAccessEmail.Text = _settings.Settings.Access.Email;
            textBoxAccessPass.Text = _settings.Settings.Access.Password;
        }

        private void SaveSettings()
        {
            //Mudar para validação no campo
            try
            {
                _settings.Settings.GeneralSettings.ConsultInterval = Convert.ToInt32(textBoxConsultInterval.Text);
            }
            catch { _settings.Settings.GeneralSettings.ConsultInterval = 30; }

            _settings.Settings.Access.Email = textBoxAccessEmail.Text;
            _settings.Settings.Access.Password = textBoxAccessPass.Text;

            //Adicionar a parte das notificacoes

            _configuration.Save(_settings);
        }

        private void buttonStartStopTracking_Click(object sender, EventArgs e)
        {
            switch (_trackerStatus)
            {
                case TrackerStatusEnum.Stopped:
                    {
                        if (listBoxCurrentTracking.Items.Count == 0)
                        {
                            MessageBox.Show("You must add a guild to the tracker on 'List' tab.", "Warning");
                            return;
                        }

                        SetCounters(new Counters());

                        labelTrackStatus.Text = "Starting...";
                        buttonStartStopTracking.Text = "Start";
                        buttonStartStopTracking.Enabled = false;
                        labelStartTime.Text = DateTime.Now.ToString();
                        _trackerStatus = TrackerStatusEnum.Starting;
                        Refresh();

                        this.workerConsult.RunWorkerAsync();
                        Thread.Sleep(2000);

                        labelTrackStatus.Text = "Running";
                        buttonStartStopTracking.Text = "Stop";
                        buttonStartStopTracking.Enabled = true;
                        _trackerStatus = TrackerStatusEnum.Running;
                        Refresh();
                    }
                    break;

                case TrackerStatusEnum.Running:
                    {
                        labelTrackStatus.Text = "Stopping";
                        buttonStartStopTracking.Text = "Stop";
                        buttonStartStopTracking.Enabled = false;
                        _trackerStatus = TrackerStatusEnum.Stopping;
                        Refresh();

                        this.workerConsult.CancelAsync();
                        Thread.Sleep(2000);

                        
                    }
                    break;
            }
        }

        private void SetGuildConsults(string guildConsults)
        {
            if (labelTotalGuildConsults.InvokeRequired)
            {
                labelTotalGuildConsults.Invoke(new Action<string>(SetGuildConsults), guildConsults);
                return;
            }
            labelTotalGuildConsults.Text = guildConsults;
        }

        private void SetPlayersConsults(string playersConsult)
        {
            if (labelTotalPlayerConsults.InvokeRequired)
            {
                labelTotalPlayerConsults.Invoke(new Action<string>(SetPlayersConsults), playersConsult);
                return;
            }
            labelTotalPlayerConsults.Text = playersConsult;
        }

        private void SetNotifications(string notifications)
        {
            if (labelTotalNotifications.InvokeRequired)
            {
                labelTotalNotifications.Invoke(new Action<string>(SetNotifications), notifications);
                return;
            }
            labelTotalNotifications.Text = notifications;
        }

        private void SetGuildsTracked(string trackedGuilds)
        {
            if (labelTotalTrackingGuilds.InvokeRequired)
            {
                labelTotalTrackingGuilds.Invoke(new Action<string>(SetGuildsTracked), trackedGuilds);
                return;
            }
            labelTotalTrackingGuilds.Text = trackedGuilds;
        }

        private void SetCounters(Counters counters)
        {
            SetGuildConsults(counters.TotalGuildConsults);

            SetPlayersConsults(counters.TotalPlayerConsults);
            
            SetNotifications(counters.TotalNotifications);

            SetGuildsTracked(listBoxCurrentTracking.Items.Count.ToString());
        }

        private void Start(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker? bw = sender as BackgroundWorker;

            if (bw == null)
                return;

            if (bw.CancellationPending)
            {
                e.Cancel = true;

                return;
            }

            e.Result = Track(bw);
        }

        private void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
            }
            else if (e.Error != null)
            {
                // Ex
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
            }
            else
            {
            }

            labelTrackStatus.Text = "Stopped";
            buttonStartStopTracking.Text = "Start";
            buttonStartStopTracking.Enabled = true;
            _trackerStatus = TrackerStatusEnum.Stopped;
            Refresh();
        }

        private int Track(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {
                bool exit = bw.CancellationPending;

                if (exit)
                    break;

                try
                {
                    _consultService.ConsultGuilds(_settings.Settings.Access.Email, _settings.Settings.Access.Password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error in the ConsultGuilds step: {ex.Message}");
                }

                Thread.Sleep(_settings.Settings.GeneralSettings.ConsultInterval * 1000);
            }

            return 0;
        }

        private void buttonSearchGuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGuildName.Text))
            {
                MessageBox.Show("Insert the guild name.", "Warning");
                textBoxGuildName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(comboBoxServerName.Text) || InvalidServerName(comboBoxServerName.Text))
            {
                MessageBox.Show("Select the server for the search.", "Warning");
                comboBoxServerName.Focus();
                return;
            }

            if (listBoxCurrentTracking.Items.Count >= 10)
            {
                var dialogResult = MessageBox.Show("The tracking limit is 10 guilds. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult != DialogResult.Yes)
                    return;
            }

            groupBoxAddGuild.Enabled = false;

            listBoxSearchResults.Items.Clear();

            _foundGuilds = _consultService.SearchGuilds((ServerEnum)comboBoxServerName.SelectedIndex + 1, textBoxGuildName.Text);

            foreach (var guild in _foundGuilds)
            {
                if (!listBoxCurrentTracking.Items.Contains(guild.GuildName))
                    listBoxSearchResults.Items.Add(guild.GuildName);
            }

            groupBoxAddGuild.Enabled = true;

            MessageBox.Show($"A total of {listBoxSearchResults.Items.Count} guilds has been found in the search.");
        }

        private static bool InvalidServerName(string text)
        {
            return text != "Awell" &&
                text != "Migal" &&
                text != "Midranda" &&
                text != "Valento" &&
                text != "Cronus";
        }

        private void CheckSelectedGuild(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedItems.Count > 0)
                buttonAddResultGuild.Enabled = true;
            else
                buttonAddResultGuild.Enabled = false;

            if (listBoxCurrentTracking.SelectedItems.Count > 0)
                buttonRemoveFromTrackingList.Enabled = true;
            else
                buttonRemoveFromTrackingList.Enabled = false;
        }

        private void buttonAddResultGuild_Click(object sender, EventArgs e)
        {
            if (listBoxCurrentTracking.Items.Count >= 10)
            {
                MessageBox.Show("The tracking limit is 10 guilds", "Warning");
            }
            else
            {
                var targetGuild = _foundGuilds.First(x => x.GuildName == listBoxSearchResults.SelectedItems[0].ToString());

                _consultService.AddToTrack(targetGuild);
                _settings.List.Guilds.Add(new Guild(targetGuild));

                listBoxCurrentTracking.Items.Add(listBoxSearchResults.SelectedItems[0]);
                listBoxSearchResults.Items.Remove(listBoxSearchResults.SelectedItems[0]);

                SaveSettings();
            }
        }

        private void SendToTray(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipText = "The tracker will keep running in background.";
                notifyIcon.ShowBalloonTip(1500);
            }
        }

        private void RemoveFromTray(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void TrayNotification(string message, int duration = 4000)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.BalloonTipText = message;
                notifyIcon.ShowBalloonTip(duration);
            }
        }

        private void buttonRemoveFromTrackingList_Click(object sender, EventArgs e)
        {
            var targetGuild = _consultService.GetTrackingGuilds().FirstOrDefault(x => x.GuildName == listBoxCurrentTracking.SelectedItems[0].ToString());

            if (targetGuild == null)
                return;

            _consultService.RemoveFromTrack(targetGuild);
            _settings.List.Guilds.RemoveAll(x => x.Name == targetGuild.GuildName);

            listBoxCurrentTracking.Items.Remove(listBoxCurrentTracking.SelectedItems[0]);

            SaveSettings();
        }

        private void buttonClearTrackingList_Click(object sender, EventArgs e)
        {
            _consultService.ClearTrack();

            _settings.List.Guilds.Clear();

            listBoxCurrentTracking.Items.Clear();

            SaveSettings();
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}