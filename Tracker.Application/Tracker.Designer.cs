namespace PlayerTracker
{
    partial class Tracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTrack = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridLastConsults = new System.Windows.Forms.DataGridView();
            this.gridDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGuildColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPlayerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCurrentLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLastLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalNotifications = new System.Windows.Forms.Label();
            this.labelTotalPlayerConsults = new System.Windows.Forms.Label();
            this.labelTotalTrackingGuilds = new System.Windows.Forms.Label();
            this.labelTotalGuildConsults = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTrackStatus = new System.Windows.Forms.Label();
            this.buttonStartStopTracking = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearTrackingList = new System.Windows.Forms.Button();
            this.buttonRemoveFromTrackingList = new System.Windows.Forms.Button();
            this.listBoxCurrentTracking = new System.Windows.Forms.ListBox();
            this.groupBoxAddGuild = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.buttonAddResultGuild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxServerName = new System.Windows.Forms.ComboBox();
            this.textBoxGuildName = new System.Windows.Forms.TextBox();
            this.buttonSearchGuild = new System.Windows.Forms.Button();
            this.tabNotifications = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxOtherMaps = new System.Windows.Forms.CheckBox();
            this.checkBoxAb3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAb2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAb1 = new System.Windows.Forms.CheckBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxAccessPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAccessEmail = new System.Windows.Forms.TextBox();
            this.textBoxLoginEndpoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPlayerEndpoint = new System.Windows.Forms.TextBox();
            this.textBoxGuildEndpoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWebsiteAddress = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConsultInterval = new System.Windows.Forms.TextBox();
            this.workerConsult = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.workerFillHistory = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTrack.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLastConsults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAddGuild.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabNotifications.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTrack);
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabNotifications);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTrack
            // 
            this.tabTrack.Controls.Add(this.groupBox6);
            this.tabTrack.Controls.Add(this.groupBox1);
            this.tabTrack.Location = new System.Drawing.Point(4, 24);
            this.tabTrack.Name = "tabTrack";
            this.tabTrack.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrack.Size = new System.Drawing.Size(762, 392);
            this.tabTrack.TabIndex = 0;
            this.tabTrack.Text = "Track";
            this.tabTrack.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridLastConsults);
            this.groupBox6.Location = new System.Drawing.Point(6, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(750, 262);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Last Consults";
            // 
            // dataGridLastConsults
            // 
            this.dataGridLastConsults.AllowUserToAddRows = false;
            this.dataGridLastConsults.AllowUserToDeleteRows = false;
            this.dataGridLastConsults.AllowUserToOrderColumns = true;
            this.dataGridLastConsults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLastConsults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridDateColumn,
            this.gridGuildColumn,
            this.gridPlayerColumn,
            this.gridCurrentLocationColumn,
            this.gridLastLocationColumn});
            this.dataGridLastConsults.Location = new System.Drawing.Point(6, 22);
            this.dataGridLastConsults.Name = "dataGridLastConsults";
            this.dataGridLastConsults.ReadOnly = true;
            this.dataGridLastConsults.RowTemplate.Height = 25;
            this.dataGridLastConsults.Size = new System.Drawing.Size(738, 234);
            this.dataGridLastConsults.TabIndex = 0;
            // 
            // gridDateColumn
            // 
            this.gridDateColumn.HeaderText = "Date";
            this.gridDateColumn.MinimumWidth = 70;
            this.gridDateColumn.Name = "gridDateColumn";
            this.gridDateColumn.ReadOnly = true;
            this.gridDateColumn.Width = 70;
            // 
            // gridGuildColumn
            // 
            this.gridGuildColumn.HeaderText = "Guild";
            this.gridGuildColumn.MinimumWidth = 80;
            this.gridGuildColumn.Name = "gridGuildColumn";
            this.gridGuildColumn.ReadOnly = true;
            this.gridGuildColumn.Width = 80;
            // 
            // gridPlayerColumn
            // 
            this.gridPlayerColumn.HeaderText = "Player";
            this.gridPlayerColumn.MinimumWidth = 80;
            this.gridPlayerColumn.Name = "gridPlayerColumn";
            this.gridPlayerColumn.ReadOnly = true;
            this.gridPlayerColumn.Width = 80;
            // 
            // gridCurrentLocationColumn
            // 
            this.gridCurrentLocationColumn.HeaderText = "Current Location";
            this.gridCurrentLocationColumn.MinimumWidth = 150;
            this.gridCurrentLocationColumn.Name = "gridCurrentLocationColumn";
            this.gridCurrentLocationColumn.ReadOnly = true;
            this.gridCurrentLocationColumn.Width = 150;
            // 
            // gridLastLocationColumn
            // 
            this.gridLastLocationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridLastLocationColumn.HeaderText = "Last Location";
            this.gridLastLocationColumn.Name = "gridLastLocationColumn";
            this.gridLastLocationColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalNotifications);
            this.groupBox1.Controls.Add(this.labelTotalPlayerConsults);
            this.groupBox1.Controls.Add(this.labelTotalTrackingGuilds);
            this.groupBox1.Controls.Add(this.labelTotalGuildConsults);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelStartTime);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelTrackStatus);
            this.groupBox1.Controls.Add(this.buttonStartStopTracking);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // labelTotalNotifications
            // 
            this.labelTotalNotifications.AutoSize = true;
            this.labelTotalNotifications.Location = new System.Drawing.Point(462, 76);
            this.labelTotalNotifications.Name = "labelTotalNotifications";
            this.labelTotalNotifications.Size = new System.Drawing.Size(13, 15);
            this.labelTotalNotifications.TabIndex = 13;
            this.labelTotalNotifications.Text = "0";
            // 
            // labelTotalPlayerConsults
            // 
            this.labelTotalPlayerConsults.AutoSize = true;
            this.labelTotalPlayerConsults.Location = new System.Drawing.Point(462, 46);
            this.labelTotalPlayerConsults.Name = "labelTotalPlayerConsults";
            this.labelTotalPlayerConsults.Size = new System.Drawing.Size(13, 15);
            this.labelTotalPlayerConsults.TabIndex = 12;
            this.labelTotalPlayerConsults.Text = "0";
            // 
            // labelTotalTrackingGuilds
            // 
            this.labelTotalTrackingGuilds.AutoSize = true;
            this.labelTotalTrackingGuilds.Location = new System.Drawing.Point(179, 76);
            this.labelTotalTrackingGuilds.Name = "labelTotalTrackingGuilds";
            this.labelTotalTrackingGuilds.Size = new System.Drawing.Size(13, 15);
            this.labelTotalTrackingGuilds.TabIndex = 11;
            this.labelTotalTrackingGuilds.Text = "0";
            // 
            // labelTotalGuildConsults
            // 
            this.labelTotalGuildConsults.AutoSize = true;
            this.labelTotalGuildConsults.Location = new System.Drawing.Point(462, 17);
            this.labelTotalGuildConsults.Name = "labelTotalGuildConsults";
            this.labelTotalGuildConsults.Size = new System.Drawing.Size(13, 15);
            this.labelTotalGuildConsults.TabIndex = 10;
            this.labelTotalGuildConsults.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(327, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Total Notifications:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Current Tracking Guilds:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total Player Consults:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(327, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total Guild Consults:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(98, 46);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(125, 15);
            this.labelStartTime.TabIndex = 5;
            this.labelStartTime.Text = "21/07/2022 - 08:50 AM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Running Since:";
            // 
            // labelTrackStatus
            // 
            this.labelTrackStatus.AutoSize = true;
            this.labelTrackStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrackStatus.Location = new System.Drawing.Point(97, 15);
            this.labelTrackStatus.Name = "labelTrackStatus";
            this.labelTrackStatus.Size = new System.Drawing.Size(60, 19);
            this.labelTrackStatus.TabIndex = 2;
            this.labelTrackStatus.Text = "Stopped";
            // 
            // buttonStartStopTracking
            // 
            this.buttonStartStopTracking.Location = new System.Drawing.Point(181, 13);
            this.buttonStartStopTracking.Name = "buttonStartStopTracking";
            this.buttonStartStopTracking.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStopTracking.TabIndex = 0;
            this.buttonStartStopTracking.Text = "Start";
            this.buttonStartStopTracking.UseVisualStyleBackColor = true;
            this.buttonStartStopTracking.Click += new System.EventHandler(this.buttonStartStopTracking_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Current Status:";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.groupBox2);
            this.tabList.Controls.Add(this.groupBoxAddGuild);
            this.tabList.Location = new System.Drawing.Point(4, 24);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(762, 392);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClearTrackingList);
            this.groupBox2.Controls.Add(this.buttonRemoveFromTrackingList);
            this.groupBox2.Controls.Add(this.listBoxCurrentTracking);
            this.groupBox2.Location = new System.Drawing.Point(376, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 379);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Tracking";
            // 
            // buttonClearTrackingList
            // 
            this.buttonClearTrackingList.Location = new System.Drawing.Point(299, 344);
            this.buttonClearTrackingList.Name = "buttonClearTrackingList";
            this.buttonClearTrackingList.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTrackingList.TabIndex = 6;
            this.buttonClearTrackingList.Text = "Clear";
            this.buttonClearTrackingList.UseVisualStyleBackColor = true;
            this.buttonClearTrackingList.Click += new System.EventHandler(this.buttonClearTrackingList_Click);
            // 
            // buttonRemoveFromTrackingList
            // 
            this.buttonRemoveFromTrackingList.Enabled = false;
            this.buttonRemoveFromTrackingList.Location = new System.Drawing.Point(6, 344);
            this.buttonRemoveFromTrackingList.Name = "buttonRemoveFromTrackingList";
            this.buttonRemoveFromTrackingList.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveFromTrackingList.TabIndex = 5;
            this.buttonRemoveFromTrackingList.Text = "Remove";
            this.buttonRemoveFromTrackingList.UseVisualStyleBackColor = true;
            this.buttonRemoveFromTrackingList.Click += new System.EventHandler(this.buttonRemoveFromTrackingList_Click);
            // 
            // listBoxCurrentTracking
            // 
            this.listBoxCurrentTracking.FormattingEnabled = true;
            this.listBoxCurrentTracking.ItemHeight = 15;
            this.listBoxCurrentTracking.Location = new System.Drawing.Point(6, 22);
            this.listBoxCurrentTracking.Name = "listBoxCurrentTracking";
            this.listBoxCurrentTracking.Size = new System.Drawing.Size(368, 304);
            this.listBoxCurrentTracking.TabIndex = 0;
            this.listBoxCurrentTracking.SelectedIndexChanged += new System.EventHandler(this.CheckSelectedGuild);
            // 
            // groupBoxAddGuild
            // 
            this.groupBoxAddGuild.Controls.Add(this.groupBox3);
            this.groupBoxAddGuild.Controls.Add(this.label2);
            this.groupBoxAddGuild.Controls.Add(this.label1);
            this.groupBoxAddGuild.Controls.Add(this.comboBoxServerName);
            this.groupBoxAddGuild.Controls.Add(this.textBoxGuildName);
            this.groupBoxAddGuild.Controls.Add(this.buttonSearchGuild);
            this.groupBoxAddGuild.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddGuild.Name = "groupBoxAddGuild";
            this.groupBoxAddGuild.Size = new System.Drawing.Size(364, 379);
            this.groupBoxAddGuild.TabIndex = 5;
            this.groupBoxAddGuild.TabStop = false;
            this.groupBoxAddGuild.Text = "Add Guild";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxSearchResults);
            this.groupBox3.Controls.Add(this.buttonAddResultGuild);
            this.groupBox3.Location = new System.Drawing.Point(6, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 270);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Results";
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.ItemHeight = 15;
            this.listBoxSearchResults.Location = new System.Drawing.Point(6, 22);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(340, 199);
            this.listBoxSearchResults.TabIndex = 5;
            this.listBoxSearchResults.SelectedIndexChanged += new System.EventHandler(this.CheckSelectedGuild);
            // 
            // buttonAddResultGuild
            // 
            this.buttonAddResultGuild.Enabled = false;
            this.buttonAddResultGuild.Location = new System.Drawing.Point(193, 240);
            this.buttonAddResultGuild.Name = "buttonAddResultGuild";
            this.buttonAddResultGuild.Size = new System.Drawing.Size(153, 23);
            this.buttonAddResultGuild.TabIndex = 6;
            this.buttonAddResultGuild.Text = "Add Selected Guild ->";
            this.buttonAddResultGuild.UseVisualStyleBackColor = true;
            this.buttonAddResultGuild.Click += new System.EventHandler(this.buttonAddResultGuild_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guild Name:";
            // 
            // comboBoxServerName
            // 
            this.comboBoxServerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxServerName.DisplayMember = "Awell";
            this.comboBoxServerName.FormattingEnabled = true;
            this.comboBoxServerName.Items.AddRange(new object[] {
            "Awell",
            "Migal",
            "Midranda",
            "Valento",
            "Cronus"});
            this.comboBoxServerName.Location = new System.Drawing.Point(107, 48);
            this.comboBoxServerName.Name = "comboBoxServerName";
            this.comboBoxServerName.Size = new System.Drawing.Size(146, 23);
            this.comboBoxServerName.TabIndex = 3;
            this.comboBoxServerName.ValueMember = "Awell";
            // 
            // textBoxGuildName
            // 
            this.textBoxGuildName.Location = new System.Drawing.Point(107, 19);
            this.textBoxGuildName.MaxLength = 30;
            this.textBoxGuildName.Name = "textBoxGuildName";
            this.textBoxGuildName.Size = new System.Drawing.Size(146, 23);
            this.textBoxGuildName.TabIndex = 1;
            // 
            // buttonSearchGuild
            // 
            this.buttonSearchGuild.Location = new System.Drawing.Point(275, 47);
            this.buttonSearchGuild.Name = "buttonSearchGuild";
            this.buttonSearchGuild.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchGuild.TabIndex = 2;
            this.buttonSearchGuild.Text = "Search";
            this.buttonSearchGuild.UseVisualStyleBackColor = true;
            this.buttonSearchGuild.Click += new System.EventHandler(this.buttonSearchGuild_Click);
            // 
            // tabNotifications
            // 
            this.tabNotifications.Controls.Add(this.groupBox7);
            this.tabNotifications.Location = new System.Drawing.Point(4, 24);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.Size = new System.Drawing.Size(762, 392);
            this.tabNotifications.TabIndex = 2;
            this.tabNotifications.Text = "Notifications";
            this.tabNotifications.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxOtherMaps);
            this.groupBox7.Controls.Add(this.checkBoxAb3);
            this.groupBox7.Controls.Add(this.checkBoxAb2);
            this.groupBox7.Controls.Add(this.checkBoxAb1);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(756, 386);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Maps";
            // 
            // checkBoxOtherMaps
            // 
            this.checkBoxOtherMaps.AutoSize = true;
            this.checkBoxOtherMaps.Location = new System.Drawing.Point(6, 97);
            this.checkBoxOtherMaps.Name = "checkBoxOtherMaps";
            this.checkBoxOtherMaps.Size = new System.Drawing.Size(88, 19);
            this.checkBoxOtherMaps.TabIndex = 3;
            this.checkBoxOtherMaps.Text = "Other maps";
            this.checkBoxOtherMaps.UseVisualStyleBackColor = true;
            // 
            // checkBoxAb3
            // 
            this.checkBoxAb3.AutoSize = true;
            this.checkBoxAb3.Location = new System.Drawing.Point(6, 72);
            this.checkBoxAb3.Name = "checkBoxAb3";
            this.checkBoxAb3.Size = new System.Drawing.Size(47, 19);
            this.checkBoxAb3.TabIndex = 2;
            this.checkBoxAb3.Text = "AB3";
            this.checkBoxAb3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAb2
            // 
            this.checkBoxAb2.AutoSize = true;
            this.checkBoxAb2.Location = new System.Drawing.Point(6, 47);
            this.checkBoxAb2.Name = "checkBoxAb2";
            this.checkBoxAb2.Size = new System.Drawing.Size(47, 19);
            this.checkBoxAb2.TabIndex = 1;
            this.checkBoxAb2.Text = "AB2";
            this.checkBoxAb2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAb1
            // 
            this.checkBoxAb1.AutoSize = true;
            this.checkBoxAb1.Location = new System.Drawing.Point(6, 22);
            this.checkBoxAb1.Name = "checkBoxAb1";
            this.checkBoxAb1.Size = new System.Drawing.Size(47, 19);
            this.checkBoxAb1.TabIndex = 0;
            this.checkBoxAb1.Text = "AB1";
            this.checkBoxAb1.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox5);
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(762, 392);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxAccessPass);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textBoxAccessEmail);
            this.groupBox5.Controls.Add(this.textBoxLoginEndpoint);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBoxPlayerEndpoint);
            this.groupBox5.Controls.Add(this.textBoxGuildEndpoint);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxWebsiteAddress);
            this.groupBox5.Location = new System.Drawing.Point(6, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(753, 136);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Access";
            // 
            // textBoxAccessPass
            // 
            this.textBoxAccessPass.Location = new System.Drawing.Point(483, 45);
            this.textBoxAccessPass.MaxLength = 30;
            this.textBoxAccessPass.Name = "textBoxAccessPass";
            this.textBoxAccessPass.Size = new System.Drawing.Size(162, 23);
            this.textBoxAccessPass.TabIndex = 11;
            this.textBoxAccessPass.Text = "priston@123";
            this.textBoxAccessPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAccessPass.UseSystemPasswordChar = true;
            this.textBoxAccessPass.TextChanged += new System.EventHandler(this.SaveSettings);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "E-mail:";
            // 
            // textBoxAccessEmail
            // 
            this.textBoxAccessEmail.Location = new System.Drawing.Point(483, 16);
            this.textBoxAccessEmail.MaxLength = 200;
            this.textBoxAccessEmail.Name = "textBoxAccessEmail";
            this.textBoxAccessEmail.Size = new System.Drawing.Size(162, 23);
            this.textBoxAccessEmail.TabIndex = 9;
            this.textBoxAccessEmail.Text = "bpristont8@gmail.com";
            this.textBoxAccessEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAccessEmail.TextChanged += new System.EventHandler(this.SaveSettings);
            // 
            // textBoxLoginEndpoint
            // 
            this.textBoxLoginEndpoint.Enabled = false;
            this.textBoxLoginEndpoint.Location = new System.Drawing.Point(137, 103);
            this.textBoxLoginEndpoint.MaxLength = 5;
            this.textBoxLoginEndpoint.Name = "textBoxLoginEndpoint";
            this.textBoxLoginEndpoint.Size = new System.Drawing.Size(161, 23);
            this.textBoxLoginEndpoint.TabIndex = 7;
            this.textBoxLoginEndpoint.Text = "/priston/login.php";
            this.textBoxLoginEndpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Login Endpoint:";
            // 
            // textBoxPlayerEndpoint
            // 
            this.textBoxPlayerEndpoint.Enabled = false;
            this.textBoxPlayerEndpoint.Location = new System.Drawing.Point(136, 74);
            this.textBoxPlayerEndpoint.MaxLength = 5;
            this.textBoxPlayerEndpoint.Name = "textBoxPlayerEndpoint";
            this.textBoxPlayerEndpoint.Size = new System.Drawing.Size(161, 23);
            this.textBoxPlayerEndpoint.TabIndex = 5;
            this.textBoxPlayerEndpoint.Text = "/priston/ranking.php";
            this.textBoxPlayerEndpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGuildEndpoint
            // 
            this.textBoxGuildEndpoint.Enabled = false;
            this.textBoxGuildEndpoint.Location = new System.Drawing.Point(136, 45);
            this.textBoxGuildEndpoint.MaxLength = 5;
            this.textBoxGuildEndpoint.Name = "textBoxGuildEndpoint";
            this.textBoxGuildEndpoint.Size = new System.Drawing.Size(162, 23);
            this.textBoxGuildEndpoint.TabIndex = 4;
            this.textBoxGuildEndpoint.Text = "/priston/clans.php";
            this.textBoxGuildEndpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Players Endpoint:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Guilds Endpoint:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Website Address:";
            // 
            // textBoxWebsiteAddress
            // 
            this.textBoxWebsiteAddress.Enabled = false;
            this.textBoxWebsiteAddress.Location = new System.Drawing.Point(136, 16);
            this.textBoxWebsiteAddress.MaxLength = 5;
            this.textBoxWebsiteAddress.Name = "textBoxWebsiteAddress";
            this.textBoxWebsiteAddress.Size = new System.Drawing.Size(162, 23);
            this.textBoxWebsiteAddress.TabIndex = 1;
            this.textBoxWebsiteAddress.Text = "https://zenit.games";
            this.textBoxWebsiteAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxConsultInterval);
            this.groupBox4.Location = new System.Drawing.Point(6, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consult Interval:";
            // 
            // textBoxConsultInterval
            // 
            this.textBoxConsultInterval.Location = new System.Drawing.Point(136, 16);
            this.textBoxConsultInterval.MaxLength = 5;
            this.textBoxConsultInterval.Name = "textBoxConsultInterval";
            this.textBoxConsultInterval.Size = new System.Drawing.Size(65, 23);
            this.textBoxConsultInterval.TabIndex = 1;
            this.textBoxConsultInterval.Text = "30";
            this.textBoxConsultInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConsultInterval.TextChanged += new System.EventHandler(this.SaveSettings);
            // 
            // workerConsult
            // 
            this.workerConsult.WorkerSupportsCancellation = true;
            this.workerConsult.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Start);
            this.workerConsult.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Completed);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Priston Tale Player Tracker";
            this.notifyIcon.Click += new System.EventHandler(this.RemoveFromTray);
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priston Tale Player Tracker";
            this.Resize += new System.EventHandler(this.SendToTray);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTrack.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLastConsults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxAddGuild.ResumeLayout(false);
            this.groupBoxAddGuild.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabNotifications.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabTrack;
        private Label labelTrackStatus;
        private Button buttonStartStopTracking;
        private TabPage tabList;
        private GroupBox groupBox2;
        private Button buttonClearTrackingList;
        private Button buttonRemoveFromTrackingList;
        private ListBox listBoxCurrentTracking;
        private GroupBox groupBoxAddGuild;
        private GroupBox groupBox3;
        private ListBox listBoxSearchResults;
        private Button buttonAddResultGuild;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxServerName;
        private TextBox textBoxGuildName;
        private Button buttonSearchGuild;
        private TabPage tabNotifications;
        private TabPage tabSettings;
        private System.ComponentModel.BackgroundWorker workerConsult;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox textBoxConsultInterval;
        private GroupBox groupBox5;
        private TextBox textBoxAccessPass;
        private Label label10;
        private Label label9;
        private TextBox textBoxAccessEmail;
        private TextBox textBoxLoginEndpoint;
        private Label label8;
        private TextBox textBoxPlayerEndpoint;
        private TextBox textBoxGuildEndpoint;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxWebsiteAddress;
        private Label label7;
        private NotifyIcon notifyIcon;
        private GroupBox groupBox6;
        private GroupBox groupBox1;
        private Label labelTotalNotifications;
        private Label labelTotalPlayerConsults;
        private Label labelTotalTrackingGuilds;
        private Label labelTotalGuildConsults;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label labelStartTime;
        private Label label12;
        private Label label11;
        private GroupBox groupBox7;
        private CheckBox checkBoxOtherMaps;
        private CheckBox checkBoxAb3;
        private CheckBox checkBoxAb2;
        private CheckBox checkBoxAb1;
        private DataGridViewTextBoxColumn gridDateColumn;
        private DataGridViewTextBoxColumn gridGuildColumn;
        private DataGridViewTextBoxColumn gridPlayerColumn;
        private DataGridViewTextBoxColumn gridCurrentLocationColumn;
        private DataGridViewTextBoxColumn gridLastLocationColumn;
        public DataGridView dataGridLastConsults;
        private System.ComponentModel.BackgroundWorker workerFillHistory;
    }
}