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
            this.components = new System.ComponentModel.Container();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.timeLbl = new System.Windows.Forms.Label();
            this.snapshotsCmbBx = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.snapshotLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.snapshotBtn = new System.Windows.Forms.Button();
            this.clearSnapshotsBtn = new System.Windows.Forms.Button();
            this.switchThemeBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Interval = 50;
            this.tmr.Tick += new System.EventHandler(this.onTimerTick);
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.DimGray;
            this.timeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeLbl.Font = new System.Drawing.Font("MS Gothic", 30F);
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(139, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(284, 64);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "00:00:00:000";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // snapshotsCmbBx
            // 
            this.snapshotsCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.snapshotsCmbBx.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.snapshotsCmbBx.FormattingEnabled = true;
            this.snapshotsCmbBx.Location = new System.Drawing.Point(139, 115);
            this.snapshotsCmbBx.Name = "snapshotsCmbBx";
            this.snapshotsCmbBx.Size = new System.Drawing.Size(224, 27);
            this.snapshotsCmbBx.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DimGray;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.startBtn.ForeColor = System.Drawing.Color.Transparent;
            this.startBtn.Location = new System.Drawing.Point(9, 9);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(124, 29);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.onStartBtnClicked);
            // 
            // snapshotLbl
            // 
            this.snapshotLbl.AutoSize = true;
            this.snapshotLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotLbl.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.snapshotLbl.ForeColor = System.Drawing.Color.White;
            this.snapshotLbl.Location = new System.Drawing.Point(143, 94);
            this.snapshotLbl.Name = "snapshotLbl";
            this.snapshotLbl.Size = new System.Drawing.Size(70, 14);
            this.snapshotLbl.TabIndex = 4;
            this.snapshotLbl.Text = "Snapshots";
            this.snapshotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.DimGray;
            this.stopBtn.Enabled = false;
            this.stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.stopBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stopBtn.Location = new System.Drawing.Point(9, 44);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(124, 29);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.onStopBtnClicked);
            // 
            // snapshotBtn
            // 
            this.snapshotBtn.BackColor = System.Drawing.Color.DimGray;
            this.snapshotBtn.Enabled = false;
            this.snapshotBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.snapshotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.snapshotBtn.ForeColor = System.Drawing.Color.Transparent;
            this.snapshotBtn.Location = new System.Drawing.Point(9, 79);
            this.snapshotBtn.Name = "snapshotBtn";
            this.snapshotBtn.Size = new System.Drawing.Size(124, 29);
            this.snapshotBtn.TabIndex = 5;
            this.snapshotBtn.Text = "Snapshot";
            this.snapshotBtn.UseVisualStyleBackColor = false;
            this.snapshotBtn.Click += new System.EventHandler(this.onSnapshotBtn);
            // 
            // clearSnapshotsBtn
            // 
            this.clearSnapshotsBtn.BackColor = System.Drawing.Color.DimGray;
            this.clearSnapshotsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearSnapshotsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSnapshotsBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.clearSnapshotsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.clearSnapshotsBtn.Location = new System.Drawing.Point(369, 113);
            this.clearSnapshotsBtn.Name = "clearSnapshotsBtn";
            this.clearSnapshotsBtn.Size = new System.Drawing.Size(54, 29);
            this.clearSnapshotsBtn.TabIndex = 8;
            this.clearSnapshotsBtn.Text = "Clear";
            this.clearSnapshotsBtn.UseVisualStyleBackColor = false;
            this.clearSnapshotsBtn.Click += new System.EventHandler(this.onClearSnapshotsBtnClicked);
            // 
            // switchThemeBtn
            // 
            this.switchThemeBtn.BackColor = System.Drawing.Color.White;
            this.switchThemeBtn.BackgroundImage = global::Clock.Properties.Resources.LightThemeIcon;
            this.switchThemeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switchThemeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.switchThemeBtn.FlatAppearance.BorderSize = 3;
            this.switchThemeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.switchThemeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.switchThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchThemeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchThemeBtn.ForeColor = System.Drawing.Color.White;
            this.switchThemeBtn.Location = new System.Drawing.Point(394, 79);
            this.switchThemeBtn.Name = "switchThemeBtn";
            this.switchThemeBtn.Size = new System.Drawing.Size(29, 29);
            this.switchThemeBtn.TabIndex = 7;
            this.switchThemeBtn.Tag = "d";
            this.switchThemeBtn.UseVisualStyleBackColor = false;
            this.switchThemeBtn.Click += new System.EventHandler(this.onSwitchModeBtnClicked);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DimGray;
            this.ResetBtn.Enabled = false;
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("MS Gothic", 10F);
            this.ResetBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ResetBtn.Location = new System.Drawing.Point(9, 114);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(124, 29);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.onResetBtnClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(429, 148);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.switchThemeBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.clearSnapshotsBtn);
            this.Controls.Add(this.snapshotsCmbBx);
            this.Controls.Add(this.snapshotBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.snapshotLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.ComboBox snapshotsCmbBx;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label snapshotLbl;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button snapshotBtn;
        private System.Windows.Forms.Button clearSnapshotsBtn;
        private System.Windows.Forms.Button switchThemeBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

