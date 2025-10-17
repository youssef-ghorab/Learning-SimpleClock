using Clock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        Stopwatch stpWtch = new Stopwatch();
        Theme darkTheme;
        Theme lightTheme;
        List<Button> allBtns;
        Theme currentTheme;

        class Theme
        {
            public Color BackColor;
            public Color timeTextColor;
            public Color snapshotLblForeColor;
            public Color btnsBackColor;
            public Color btnsForeColor;
            public Color timeTextBackColor;

            public Theme(Color form_bg_Color, Color time_lbl_color,Color snapshot_lbl_color,Color btns_bg_color, Color btns_fore_color,Color time_text_back_color)
            {
                BackColor = form_bg_Color;
                timeTextColor = time_lbl_color;
                snapshotLblForeColor = snapshot_lbl_color;
                btnsBackColor = btns_bg_color;
                btnsForeColor = btns_fore_color;
                timeTextBackColor = time_text_back_color;
            }
        }

        Color hexToColor(string hex_string)
        {
            return ColorTranslator.FromHtml(hex_string);
        }

        public MainForm()
        {
            InitializeComponent();
            darkTheme = new Theme(hexToColor("#272829"),hexToColor("#272829"),hexToColor("#D8D9DA"), hexToColor("#D8D9DA"), hexToColor("#272829"), hexToColor("#D8D9DA"));
            lightTheme =new Theme(hexToColor("#D8D9DA"),hexToColor("#D8D9DA"),hexToColor("#272829"), hexToColor("#272829"), hexToColor("#D8D9DA"), hexToColor("#272829"));
            currentTheme = darkTheme;
        }

        private void onStartBtnClicked(object sender, EventArgs e)
        {
            stpWtch.Start();
            tmr.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            snapshotBtn.Enabled = true;
            ResetBtn.Enabled = true;
        }

        private void updateChronoLbl(Stopwatch sw)
        {
            TimeSpan ep = sw.Elapsed;
            timeLbl.Text = $"{ep.Hours:D2}:{ep.Minutes:D2}:{ep.Seconds:D2}:{ep.Milliseconds:D3}";
        }

        private void onTimerTick(object sender, EventArgs e)
        {
            updateChronoLbl(stpWtch);
        }

        private void onStopBtnClicked(object sender, EventArgs e)
        {
            stpWtch.Stop();
            tmr.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
        }

        private void onSnapshotBtn(object sender, EventArgs e)
        {
            snapshotsCmbBx.Items.Add(timeLbl.Text);
            if (!clearSnapshotsBtn.Enabled)
                clearSnapshotsBtn.Enabled = true;
        }

        private void onResetBtnClicked(object sender, EventArgs e)
        {
            stpWtch.Reset();
            tmr.Stop();
            updateChronoLbl(stpWtch);
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            snapshotBtn.Enabled = false;
            ResetBtn.Enabled = false;
        }

        void switchThemeTo(Theme theme)
        {
            BackColor = theme.BackColor;
            timeLbl.ForeColor = theme.timeTextColor;
            snapshotLbl.ForeColor = theme.snapshotLblForeColor;
            timeLbl.BackColor = theme.timeTextBackColor;
            foreach (Button btn in allBtns)
            {
                btn.BackColor = theme.btnsBackColor;
                btn.ForeColor = theme.btnsForeColor;
            }
        }

        private void onSwitchModeBtnClicked(object sender, EventArgs e) 
        {
            currentTheme = currentTheme == darkTheme ? lightTheme : darkTheme;
            switchThemeBtn.BackgroundImage = currentTheme == darkTheme ? Resources.LightThemeIcon : Resources.DarkThemeIcon; 
            switchThemeTo(currentTheme);
        }

        private void onLoad(object sender, EventArgs e)
        {
            allBtns = new List<Button>() { snapshotBtn, stopBtn, startBtn, ResetBtn, clearSnapshotsBtn };
            switchThemeTo(darkTheme);
        }

        private void onClearSnapshotsBtnClicked(object sender, EventArgs e)
        {
            snapshotsCmbBx.Items.Clear();
            clearSnapshotsBtn.Enabled = false;
        }
    }
}
