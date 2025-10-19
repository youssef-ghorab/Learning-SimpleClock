using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Core
{

    public class TimerManager
    {
        CountDownTimer _timer;
        MaskedTextBox _timerTxtBx;
        Button _startBtn, _stopBtn, _snapshotBtn, _resetBtn, _clearSnapshotsBtn;
        ProgressBar _prgrssBr;
        ComboBox _snapshotsCmbBx;
        NotifyIcon notifyIcon = new NotifyIcon();
        System.Windows.Forms.Timer _updateUITimer = new System.Windows.Forms.Timer();
        enum Status { Start, Stop, Reset, ClearSnapshots, Done };

        void initNotifyicon()
        {
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Timer Timeout";
            notifyIcon.Icon = SystemIcons.Information;
        }

        public TimerManager(MaskedTextBox timer_txtBx, Button start_btn, Button stop_btn, Button snapshot_btn, Button reset_btn, ProgressBar prgrssBr, ComboBox snapshots_cmbBx, Button clear_snapshots_btn)
        {
            _timerTxtBx = timer_txtBx;
            _startBtn = start_btn;
            _stopBtn = stop_btn;
            _snapshotBtn = snapshot_btn;
            _resetBtn = reset_btn;
            _clearSnapshotsBtn = clear_snapshots_btn;
            _prgrssBr = prgrssBr;
            _snapshotsCmbBx = snapshots_cmbBx;
            _updateUITimer.Interval = 50;
            _updateUITimer.Tick += UpdateUI;
            initNotifyicon();
        }

        void showTimeoutNotification(int duration)
        {
            notifyIcon.BalloonTipText = $"Duration ({TimeSpanToString(_timer.InitialDuration)}) is timeout .";
            notifyIcon.ShowBalloonTip(duration);
        }

        void ChangeStatus(Status status)
        {
            switch (status)
            {
                case Status.Start:
                    _startBtn.Text = "Resume";
                    _stopBtn.Enabled = true;
                    _snapshotBtn.Enabled = true;
                    _resetBtn.Enabled = true;
                    _timerTxtBx.Enabled = false;
                    _timerTxtBx.Mask = "";
                    _startBtn.Enabled = false;
                    break;
                case Status.Stop:
                    _stopBtn.Enabled = false;
                    _startBtn.Enabled = true;
                    break;
                case Status.ClearSnapshots:
                    _clearSnapshotsBtn.Enabled = false;
                    break;
                case Status.Reset:
                    _startBtn.Text = "Start";
                    _startBtn.Enabled = true;
                    _stopBtn.Enabled = false;
                    _snapshotBtn.Enabled = false;
                    _resetBtn.Enabled = false;
                    _timerTxtBx.Text = "";
                    _timerTxtBx.Mask = (string)_timerTxtBx.Tag;
                    _timerTxtBx.Enabled = true;
                    _prgrssBr.Value = 0;
                    break;
                case Status.Done:
                    _startBtn.Text = "Start";
                    _startBtn.Enabled = true;
                    _stopBtn.Enabled = false;
                    _snapshotBtn.Enabled = false;
                    _resetBtn.Enabled = true;
                    _timerTxtBx.Mask = (string)_timerTxtBx.Tag;
                    _timerTxtBx.Enabled = true;
                    break;
            }
        }

        int StrToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        TimeSpan GetTimerTimeSpan()
        {
            string[] parts = _timerTxtBx.Text.Split(':');
            return new TimeSpan(StrToInt(parts[0]), StrToInt(parts[1]), StrToInt(parts[2]), StrToInt(parts[3]), StrToInt(parts[4]));
        }

        string TimeSpanToString(TimeSpan ts)
        {
            return $"{ts.Days:D3}:{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}:{ts.Milliseconds:D3}";
        }

        private void UpdateTimerLbl(TimeSpan ts)
        {
            _timerTxtBx.Text = TimeSpanToString(ts);
        }

        private void updateTimerPrgrssBr()
        {
            int initialDuaration;
            _prgrssBr.Value = (initialDuaration = (int)_timer.InitialDuration.TotalMilliseconds) == 0 ? 0 : (int)_timer.Remaind.TotalMilliseconds * 100 / initialDuaration;
        }

        void StartResumTimer(TimeSpan timerTimeSnap)
        {
            if (_timer == null || !_timer.IsPaused)
                _timer = new CountDownTimer(timerTimeSnap.Days, timerTimeSnap.Hours, timerTimeSnap.Minutes, timerTimeSnap.Seconds, timerTimeSnap.Milliseconds);
            _timer.Start();
        }

        public void Start()
        {
            TimeSpan timerTimeSnap = GetTimerTimeSpan();
            if (timerTimeSnap.TotalMilliseconds == 0)
                return;

            StartResumTimer(timerTimeSnap);
            ChangeStatus(Status.Start);
            UpdateTimerLbl(timerTimeSnap);
            _updateUITimer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
            _updateUITimer.Stop();
            ChangeStatus(Status.Stop);
        }

        public void Snapshot()
        {
            _snapshotsCmbBx.Items.Add(_timerTxtBx.Text);
            if (!_clearSnapshotsBtn.Enabled)
                _clearSnapshotsBtn.Enabled = true;
        }

        public void ClearSnapshots()
        {
            _snapshotsCmbBx.Items.Clear();
            ChangeStatus(Status.ClearSnapshots);
        }

        public void Reset()
        {
            _updateUITimer.Stop();
            _timer = null;
            ChangeStatus(Status.Reset);
        }

        private void UpdateUI(object sender, EventArgs e)
        {
            UpdateTimerLbl(_timer.Remaind);
            updateTimerPrgrssBr();
            if (_timer.IsFinished)
            {
                showTimeoutNotification(30);
                _updateUITimer.Stop();
                ChangeStatus(Status.Done);
            }
        }

        public void TxtBxTextChanged()
        {
            if (_timer == null || !_timer.IsRunning)
                _startBtn.Enabled = _timerTxtBx.MaskFull;
        }
    }

}
