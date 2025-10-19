using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Core
{
    public class ChronoManager
    {
        Stopwatch _chrono = new Stopwatch();
        Label _label;
        Button _startBtn, _stopBtn, _snapshotBtn, _resetBtn, _clearSnapshotsBtn;
        ComboBox _snapshotsCmbBx;
        System.Windows.Forms.Timer _updateUITimer = new System.Windows.Forms.Timer();
        enum Status { Start, Stop, Reset };

        public ChronoManager(Label time_lbl, Button start_btn, Button stop_btn, Button snapshot_btn, Button reset_btn, Button clear_snapshots_btn, ComboBox snapshots_cmboBx)
        {
            _label = time_lbl;
            _startBtn = start_btn;
            _stopBtn = stop_btn;
            _snapshotBtn = snapshot_btn;
            _resetBtn = reset_btn;
            _clearSnapshotsBtn = clear_snapshots_btn;
            _snapshotsCmbBx = snapshots_cmboBx;
            _updateUITimer.Interval = 50;
            _updateUITimer.Tick += OnUpdateUITimerTick;
        }

        private void UpdateChronoLbl(Stopwatch sw)
        {
            TimeSpan ep = sw.Elapsed;
            _label.Text = $"{ep.Days:D3}:{ep.Hours:D2}:{ep.Minutes:D2}:{ep.Seconds:D2}:{ep.Milliseconds:D3}";
        }

        void ChangeStatus(Status status)
        {
            switch (status)
            {
                case Status.Start:
                    _startBtn.Enabled = false;
                    _stopBtn.Enabled = true;
                    _snapshotBtn.Enabled = true;
                    _resetBtn.Enabled = true;
                    _startBtn.Text = "Resume";
                    break;
                case Status.Stop:
                    _stopBtn.Enabled = false;
                    _startBtn.Enabled = true;
                    break;
                case Status.Reset:
                    _startBtn.Enabled = true;
                    _stopBtn.Enabled = false;
                    _snapshotBtn.Enabled = false;
                    _resetBtn.Enabled = false;
                    _startBtn.Text = "Start";
                    break;
            }
        }

        public void Start()
        {
            _chrono.Start();
            _updateUITimer.Start();
            ChangeStatus(Status.Start);
        }

        private void UpdateUI()
        {
            UpdateChronoLbl(_chrono);
        }

        public void Stop()
        {
            _chrono.Stop();
            _updateUITimer.Stop();
            ChangeStatus(Status.Stop);
        }

        public void Snapshot()
        {
            _snapshotsCmbBx.Items.Add(_label.Text);
            if (!_clearSnapshotsBtn.Enabled)
                _clearSnapshotsBtn.Enabled = true;
        }

        private void OnUpdateUITimerTick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void Reset()
        {
            _chrono.Reset();
            _updateUITimer.Stop();
            UpdateChronoLbl(_chrono);
            ChangeStatus(Status.Reset);
        }

        public void ClearSnapshots()
        {
            _snapshotsCmbBx.Items.Clear();
            _clearSnapshotsBtn.Enabled = false;
        }
    }
}
