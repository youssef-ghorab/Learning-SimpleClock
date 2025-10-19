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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clock.Core;

namespace Clock
{
    public partial class MainForm : Form
    {
        ThemeManager _themesManager;
        TimerManager _timerManager;
        ChronoManager _chronoManager;


        Color HexToColor(string hex_string)
        {
            return ColorTranslator.FromHtml(hex_string);
        }


        //Constractor
        public MainForm()
        {
            InitializeComponent();
        }


        //EVENTS
        //On form load event
        private void OnLoad(object sender, EventArgs e)
        {
            _themesManager = new ThemeManager(tabControl1);
            _timerManager = new TimerManager(timerMskdTxtBx, startTimerBtn, stopTimerBtn, snapshotTimerBtn, resetTimerBtn, timerPrgrssBr, timerSnapshotsCmbBx, clearChronoSnapshotsBtn);
            _chronoManager = new ChronoManager(ChronoLbl, startChronoBtn, stopChronoBtn, snapshotChronoBtn, resetChronoBtn, clearChronoSnapshotsBtn, chronoSnapshotsCmbBx);
            _themesManager.Add(HexToColor("#272829"), HexToColor("#D8D9DA"), "Dark");
            _themesManager.Add(HexToColor("#D8D9DA"), HexToColor("#272829"), "Light");
            themeCmbBx.Items.Add("Dark");
            themeCmbBx.Items.Add("Light");
            themeCmbBx.SelectedIndex = 0;
            _themesManager.SwitchTo("Dark");
        }

        //chrono events
        private void OnStartChronoBtnClicked(object sender, EventArgs e)
        {
            _chronoManager.Start();
        }

        private void OnStopChronoBtnClicked(object sender, EventArgs e)
        {
            _chronoManager.Stop();
        }

        private void OnChronoSnapshotBtnClicked(object sender, EventArgs e)
        {
            _chronoManager.Snapshot();
        }

        private void OnResetChronoBtnClicked(object sender, EventArgs e)
        {
            _chronoManager.Reset();
        }

        private void OnClearChronoSnapshotsBtnClicked(object sender, EventArgs e)
        {
            _chronoManager.ClearSnapshots();
        }

        //Timer events
        private void OnSelectedThemeChanged(object sender, EventArgs e)
        {
            _themesManager.SwitchTo(themeCmbBx.SelectedItem.ToString());
        }

        private void OnStartTimerBtnClicked(object sender, EventArgs e)
        {
            _timerManager.Start();
        }

        private void OnStopTimerBtnClicked(object sender, EventArgs e)
        {
            _timerManager.Stop();
        }

        private void OnSnapshotTimerBtnClicked(object sender, EventArgs e)
        {
            _timerManager.Snapshot();
        }

        private void OnResetBtnClicked(object sender, EventArgs e)
        {
            _timerManager.Reset();
        }

        private void OnTimerTxtBxTextChanged(object sender, EventArgs e)
        {
            _timerManager.TxtBxTextChanged();
        }

        private void OnClearTimerSnapshotsBtnClicked(object sender, EventArgs e)
        {
            _timerManager.ClearSnapshots();
        }
    }
}
