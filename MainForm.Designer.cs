namespace Clock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChronoLbl = new System.Windows.Forms.Label();
            this.chronoSnapshotsCmbBx = new System.Windows.Forms.ComboBox();
            this.startChronoBtn = new System.Windows.Forms.Button();
            this.snapshotLbl = new System.Windows.Forms.Label();
            this.stopChronoBtn = new System.Windows.Forms.Button();
            this.snapshotChronoBtn = new System.Windows.Forms.Button();
            this.clearChronoSnapshotsBtn = new System.Windows.Forms.Button();
            this.resetChronoBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chronoTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timerTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMskdTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.timerPrgrssBr = new System.Windows.Forms.ProgressBar();
            this.resetTimerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clearTimerSnapshotsBtn = new System.Windows.Forms.Button();
            this.startTimerBtn = new System.Windows.Forms.Button();
            this.timerSnapshotsCmbBx = new System.Windows.Forms.ComboBox();
            this.stopTimerBtn = new System.Windows.Forms.Button();
            this.snapshotTimerBtn = new System.Windows.Forms.Button();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.themeCmbBx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.chronoTab.SuspendLayout();
            this.timerTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChronoLbl
            // 
            this.ChronoLbl.AutoSize = true;
            this.ChronoLbl.BackColor = System.Drawing.Color.Transparent;
            this.ChronoLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChronoLbl.Font = new System.Drawing.Font("MS Gothic", 25F);
            this.ChronoLbl.ForeColor = System.Drawing.Color.White;
            this.ChronoLbl.Location = new System.Drawing.Point(139, 37);
            this.ChronoLbl.Name = "ChronoLbl";
            this.ChronoLbl.Size = new System.Drawing.Size(287, 34);
            this.ChronoLbl.TabIndex = 0;
            this.ChronoLbl.Text = "000:00:00:00:000";
            this.ChronoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chronoSnapshotsCmbBx
            // 
            this.chronoSnapshotsCmbBx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chronoSnapshotsCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chronoSnapshotsCmbBx.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.chronoSnapshotsCmbBx.FormattingEnabled = true;
            this.chronoSnapshotsCmbBx.Location = new System.Drawing.Point(138, 108);
            this.chronoSnapshotsCmbBx.Name = "chronoSnapshotsCmbBx";
            this.chronoSnapshotsCmbBx.Size = new System.Drawing.Size(224, 27);
            this.chronoSnapshotsCmbBx.TabIndex = 3;
            // 
            // startChronoBtn
            // 
            this.startChronoBtn.BackColor = System.Drawing.Color.DimGray;
            this.startChronoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startChronoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startChronoBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.startChronoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.startChronoBtn.Location = new System.Drawing.Point(7, 6);
            this.startChronoBtn.Name = "startChronoBtn";
            this.startChronoBtn.Size = new System.Drawing.Size(124, 29);
            this.startChronoBtn.TabIndex = 1;
            this.startChronoBtn.Text = "Start";
            this.startChronoBtn.UseVisualStyleBackColor = false;
            this.startChronoBtn.Click += new System.EventHandler(this.OnStartChronoBtnClicked);
            // 
            // snapshotLbl
            // 
            this.snapshotLbl.AutoSize = true;
            this.snapshotLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotLbl.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.snapshotLbl.ForeColor = System.Drawing.Color.White;
            this.snapshotLbl.Location = new System.Drawing.Point(138, 91);
            this.snapshotLbl.Name = "snapshotLbl";
            this.snapshotLbl.Size = new System.Drawing.Size(70, 14);
            this.snapshotLbl.TabIndex = 4;
            this.snapshotLbl.Text = "Snapshots";
            this.snapshotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopChronoBtn
            // 
            this.stopChronoBtn.BackColor = System.Drawing.Color.DimGray;
            this.stopChronoBtn.Enabled = false;
            this.stopChronoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopChronoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopChronoBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.stopChronoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stopChronoBtn.Location = new System.Drawing.Point(8, 41);
            this.stopChronoBtn.Name = "stopChronoBtn";
            this.stopChronoBtn.Size = new System.Drawing.Size(124, 29);
            this.stopChronoBtn.TabIndex = 2;
            this.stopChronoBtn.Text = "Stop";
            this.stopChronoBtn.UseVisualStyleBackColor = false;
            this.stopChronoBtn.Click += new System.EventHandler(this.OnStopChronoBtnClicked);
            // 
            // snapshotChronoBtn
            // 
            this.snapshotChronoBtn.BackColor = System.Drawing.Color.DimGray;
            this.snapshotChronoBtn.Enabled = false;
            this.snapshotChronoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.snapshotChronoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotChronoBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.snapshotChronoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.snapshotChronoBtn.Location = new System.Drawing.Point(8, 76);
            this.snapshotChronoBtn.Name = "snapshotChronoBtn";
            this.snapshotChronoBtn.Size = new System.Drawing.Size(124, 29);
            this.snapshotChronoBtn.TabIndex = 5;
            this.snapshotChronoBtn.Text = "Snapshot";
            this.snapshotChronoBtn.UseVisualStyleBackColor = false;
            this.snapshotChronoBtn.Click += new System.EventHandler(this.OnChronoSnapshotBtnClicked);
            // 
            // clearChronoSnapshotsBtn
            // 
            this.clearChronoSnapshotsBtn.BackColor = System.Drawing.Color.DimGray;
            this.clearChronoSnapshotsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearChronoSnapshotsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearChronoSnapshotsBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.clearChronoSnapshotsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.clearChronoSnapshotsBtn.Location = new System.Drawing.Point(368, 108);
            this.clearChronoSnapshotsBtn.Name = "clearChronoSnapshotsBtn";
            this.clearChronoSnapshotsBtn.Size = new System.Drawing.Size(54, 29);
            this.clearChronoSnapshotsBtn.TabIndex = 8;
            this.clearChronoSnapshotsBtn.Text = "Clear";
            this.clearChronoSnapshotsBtn.UseVisualStyleBackColor = false;
            this.clearChronoSnapshotsBtn.Click += new System.EventHandler(this.OnClearChronoSnapshotsBtnClicked);
            // 
            // resetChronoBtn
            // 
            this.resetChronoBtn.BackColor = System.Drawing.Color.DimGray;
            this.resetChronoBtn.Enabled = false;
            this.resetChronoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetChronoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetChronoBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.resetChronoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.resetChronoBtn.Location = new System.Drawing.Point(8, 108);
            this.resetChronoBtn.Name = "resetChronoBtn";
            this.resetChronoBtn.Size = new System.Drawing.Size(124, 29);
            this.resetChronoBtn.TabIndex = 6;
            this.resetChronoBtn.Text = "Reset";
            this.resetChronoBtn.UseVisualStyleBackColor = false;
            this.resetChronoBtn.Click += new System.EventHandler(this.OnResetChronoBtnClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.chronoTab);
            this.tabControl1.Controls.Add(this.timerTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 170);
            this.tabControl1.TabIndex = 9;
            // 
            // chronoTab
            // 
            this.chronoTab.BackColor = System.Drawing.Color.Gray;
            this.chronoTab.Controls.Add(this.label8);
            this.chronoTab.Controls.Add(this.label9);
            this.chronoTab.Controls.Add(this.label10);
            this.chronoTab.Controls.Add(this.label11);
            this.chronoTab.Controls.Add(this.label12);
            this.chronoTab.Controls.Add(this.ChronoLbl);
            this.chronoTab.Controls.Add(this.resetChronoBtn);
            this.chronoTab.Controls.Add(this.snapshotLbl);
            this.chronoTab.Controls.Add(this.clearChronoSnapshotsBtn);
            this.chronoTab.Controls.Add(this.startChronoBtn);
            this.chronoTab.Controls.Add(this.chronoSnapshotsCmbBx);
            this.chronoTab.Controls.Add(this.stopChronoBtn);
            this.chronoTab.Controls.Add(this.snapshotChronoBtn);
            this.chronoTab.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chronoTab.Location = new System.Drawing.Point(4, 4);
            this.chronoTab.Name = "chronoTab";
            this.chronoTab.Padding = new System.Windows.Forms.Padding(3);
            this.chronoTab.Size = new System.Drawing.Size(428, 144);
            this.chronoTab.TabIndex = 0;
            this.chronoTab.Text = "Chrono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(360, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 10);
            this.label8.TabIndex = 29;
            this.label8.Text = "Miliseconds";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(309, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 10);
            this.label9.TabIndex = 28;
            this.label9.Text = "Seconds";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(259, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 10);
            this.label10.TabIndex = 27;
            this.label10.Text = "Minutes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(213, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 10);
            this.label11.TabIndex = 26;
            this.label11.Text = "Hours";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(157, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 10);
            this.label12.TabIndex = 25;
            this.label12.Text = "Days";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTab
            // 
            this.timerTab.BackColor = System.Drawing.Color.Gray;
            this.timerTab.Controls.Add(this.label7);
            this.timerTab.Controls.Add(this.label6);
            this.timerTab.Controls.Add(this.label5);
            this.timerTab.Controls.Add(this.label4);
            this.timerTab.Controls.Add(this.label1);
            this.timerTab.Controls.Add(this.timerMskdTxtBx);
            this.timerTab.Controls.Add(this.timerPrgrssBr);
            this.timerTab.Controls.Add(this.resetTimerBtn);
            this.timerTab.Controls.Add(this.label2);
            this.timerTab.Controls.Add(this.clearTimerSnapshotsBtn);
            this.timerTab.Controls.Add(this.startTimerBtn);
            this.timerTab.Controls.Add(this.timerSnapshotsCmbBx);
            this.timerTab.Controls.Add(this.stopTimerBtn);
            this.timerTab.Controls.Add(this.snapshotTimerBtn);
            this.timerTab.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTab.Location = new System.Drawing.Point(4, 4);
            this.timerTab.Name = "timerTab";
            this.timerTab.Padding = new System.Windows.Forms.Padding(3);
            this.timerTab.Size = new System.Drawing.Size(428, 144);
            this.timerTab.TabIndex = 1;
            this.timerTab.Text = "Timer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(360, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 10);
            this.label7.TabIndex = 24;
            this.label7.Text = "Miliseconds";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 10);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seconds";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(259, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 10);
            this.label5.TabIndex = 22;
            this.label5.Text = "Minutes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 10);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hours";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 7F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 10);
            this.label1.TabIndex = 20;
            this.label1.Text = "Days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMskdTxtBx
            // 
            this.timerMskdTxtBx.Font = new System.Drawing.Font("MS Gothic", 24F);
            this.timerMskdTxtBx.Location = new System.Drawing.Point(137, 30);
            this.timerMskdTxtBx.Mask = "\\000:00:00:00:000";
            this.timerMskdTxtBx.Name = "timerMskdTxtBx";
            this.timerMskdTxtBx.Size = new System.Drawing.Size(285, 39);
            this.timerMskdTxtBx.TabIndex = 19;
            this.timerMskdTxtBx.Tag = "\\000:00:00:00:000";
            this.timerMskdTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerMskdTxtBx.TextChanged += new System.EventHandler(this.OnTimerTxtBxTextChanged);
            // 
            // timerPrgrssBr
            // 
            this.timerPrgrssBr.BackColor = System.Drawing.Color.Red;
            this.timerPrgrssBr.Location = new System.Drawing.Point(138, 71);
            this.timerPrgrssBr.Name = "timerPrgrssBr";
            this.timerPrgrssBr.Size = new System.Drawing.Size(284, 5);
            this.timerPrgrssBr.TabIndex = 18;
            this.timerPrgrssBr.Value = 100;
            // 
            // resetTimerBtn
            // 
            this.resetTimerBtn.BackColor = System.Drawing.Color.DimGray;
            this.resetTimerBtn.Enabled = false;
            this.resetTimerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTimerBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.resetTimerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.resetTimerBtn.Location = new System.Drawing.Point(8, 109);
            this.resetTimerBtn.Name = "resetTimerBtn";
            this.resetTimerBtn.Size = new System.Drawing.Size(124, 29);
            this.resetTimerBtn.TabIndex = 15;
            this.resetTimerBtn.Text = "Reset";
            this.resetTimerBtn.UseVisualStyleBackColor = false;
            this.resetTimerBtn.Click += new System.EventHandler(this.OnResetBtnClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Snapshots";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearTimerSnapshotsBtn
            // 
            this.clearTimerSnapshotsBtn.BackColor = System.Drawing.Color.DimGray;
            this.clearTimerSnapshotsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearTimerSnapshotsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTimerSnapshotsBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.clearTimerSnapshotsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.clearTimerSnapshotsBtn.Location = new System.Drawing.Point(368, 109);
            this.clearTimerSnapshotsBtn.Name = "clearTimerSnapshotsBtn";
            this.clearTimerSnapshotsBtn.Size = new System.Drawing.Size(54, 29);
            this.clearTimerSnapshotsBtn.TabIndex = 17;
            this.clearTimerSnapshotsBtn.Text = "Clear";
            this.clearTimerSnapshotsBtn.UseVisualStyleBackColor = false;
            this.clearTimerSnapshotsBtn.Click += new System.EventHandler(this.OnClearTimerSnapshotsBtnClicked);
            // 
            // startTimerBtn
            // 
            this.startTimerBtn.BackColor = System.Drawing.Color.DimGray;
            this.startTimerBtn.Enabled = false;
            this.startTimerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTimerBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.startTimerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.startTimerBtn.Location = new System.Drawing.Point(7, 7);
            this.startTimerBtn.Name = "startTimerBtn";
            this.startTimerBtn.Size = new System.Drawing.Size(124, 29);
            this.startTimerBtn.TabIndex = 10;
            this.startTimerBtn.Text = "Start";
            this.startTimerBtn.UseVisualStyleBackColor = false;
            this.startTimerBtn.Click += new System.EventHandler(this.OnStartTimerBtnClicked);
            // 
            // timerSnapshotsCmbBx
            // 
            this.timerSnapshotsCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timerSnapshotsCmbBx.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.timerSnapshotsCmbBx.FormattingEnabled = true;
            this.timerSnapshotsCmbBx.Location = new System.Drawing.Point(138, 109);
            this.timerSnapshotsCmbBx.Name = "timerSnapshotsCmbBx";
            this.timerSnapshotsCmbBx.Size = new System.Drawing.Size(224, 27);
            this.timerSnapshotsCmbBx.TabIndex = 12;
            // 
            // stopTimerBtn
            // 
            this.stopTimerBtn.BackColor = System.Drawing.Color.DimGray;
            this.stopTimerBtn.Enabled = false;
            this.stopTimerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopTimerBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.stopTimerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stopTimerBtn.Location = new System.Drawing.Point(8, 42);
            this.stopTimerBtn.Name = "stopTimerBtn";
            this.stopTimerBtn.Size = new System.Drawing.Size(124, 29);
            this.stopTimerBtn.TabIndex = 11;
            this.stopTimerBtn.Text = "Stop";
            this.stopTimerBtn.UseVisualStyleBackColor = false;
            this.stopTimerBtn.Click += new System.EventHandler(this.OnStopTimerBtnClicked);
            // 
            // snapshotTimerBtn
            // 
            this.snapshotTimerBtn.BackColor = System.Drawing.Color.DimGray;
            this.snapshotTimerBtn.Enabled = false;
            this.snapshotTimerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.snapshotTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotTimerBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.snapshotTimerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.snapshotTimerBtn.Location = new System.Drawing.Point(8, 77);
            this.snapshotTimerBtn.Name = "snapshotTimerBtn";
            this.snapshotTimerBtn.Size = new System.Drawing.Size(124, 29);
            this.snapshotTimerBtn.TabIndex = 14;
            this.snapshotTimerBtn.Text = "Snapshot";
            this.snapshotTimerBtn.UseVisualStyleBackColor = false;
            this.snapshotTimerBtn.Click += new System.EventHandler(this.OnSnapshotTimerBtnClicked);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.themeCmbBx);
            this.SettingsTab.Controls.Add(this.label3);
            this.SettingsTab.Location = new System.Drawing.Point(4, 4);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(428, 144);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // themeCmbBx
            // 
            this.themeCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeCmbBx.FormattingEnabled = true;
            this.themeCmbBx.Location = new System.Drawing.Point(65, 8);
            this.themeCmbBx.Name = "themeCmbBx";
            this.themeCmbBx.Size = new System.Drawing.Size(344, 21);
            this.themeCmbBx.TabIndex = 10;
            this.themeCmbBx.SelectedIndexChanged += new System.EventHandler(this.OnSelectedThemeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Theme";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(457, 186);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SClock";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabControl1.ResumeLayout(false);
            this.chronoTab.ResumeLayout(false);
            this.chronoTab.PerformLayout();
            this.timerTab.ResumeLayout(false);
            this.timerTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ChronoLbl;
        private System.Windows.Forms.ComboBox chronoSnapshotsCmbBx;
        private System.Windows.Forms.Button startChronoBtn;
        private System.Windows.Forms.Label snapshotLbl;
        private System.Windows.Forms.Button stopChronoBtn;
        private System.Windows.Forms.Button snapshotChronoBtn;
        private System.Windows.Forms.Button clearChronoSnapshotsBtn;
        private System.Windows.Forms.Button resetChronoBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chronoTab;
        private System.Windows.Forms.TabPage timerTab;
        private System.Windows.Forms.Button resetTimerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearTimerSnapshotsBtn;
        private System.Windows.Forms.Button startTimerBtn;
        private System.Windows.Forms.ComboBox timerSnapshotsCmbBx;
        private System.Windows.Forms.Button stopTimerBtn;
        private System.Windows.Forms.Button snapshotTimerBtn;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox timerMskdTxtBx;
        private System.Windows.Forms.ProgressBar timerPrgrssBr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox themeCmbBx;
    }
}

