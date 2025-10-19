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

namespace Clock
{
    public partial class MainForm : Form
    {
        ThemeManager _themesManager;
        TimerManager _timerManager;
        ChronoManager _chronoManager;

        class CountDownTimer
        {
            TimeSpan _targetDuration;
            Stopwatch _elapsedDurationStopWatch = new Stopwatch();
            bool _isFinished = false;
            bool _isPaused= false;

            public CountDownTimer(int days, int hours, int minutes, int seconds, int miliseconds)
            {
                _targetDuration = new TimeSpan(days, hours, minutes, seconds, miliseconds);
            }

            void UpdateStatus()
            {
                if (_elapsedDurationStopWatch.Elapsed >= _targetDuration)
                {
                    _elapsedDurationStopWatch.Stop();
                    _isFinished = true;
                }
            }

            public TimeSpan Remaind
            {
                get
                {
                    UpdateStatus();
                    if (_isFinished)
                        return new TimeSpan(0, 0, 0, 0, 0);
                    return _targetDuration.Subtract(_elapsedDurationStopWatch.Elapsed);
                }
            }

            public TimeSpan Elapsed
            {
                get
                {
                    return _elapsedDurationStopWatch.Elapsed;
                }
            }

            public bool IsFinished
            {
                get
                {
                    if (!_isFinished)
                        UpdateStatus();
                    return _isFinished;
                }
            }

            public TimeSpan InitialDuration
            {
                get
                {
                    return _targetDuration;
                }
            }

            public void Reset()
            {
                _elapsedDurationStopWatch.Reset();
                _targetDuration = new TimeSpan(0, 0, 0, 0, 0);
                _isFinished = false;
                _isPaused = false; 
            }

            public void Start()
            {
                if (!_elapsedDurationStopWatch.IsRunning)
                {
                    _isPaused = false;
                    _elapsedDurationStopWatch.Start();
                }
            }

            public void Stop()
            {
                if (IsRunning)
                {
                    _isPaused = true;
                    _elapsedDurationStopWatch.Stop();
                }
            }
        
            public bool IsRunning
            {
                get { return _elapsedDurationStopWatch.IsRunning; }
            }
        
            public bool IsPaused
            {
                get
                {
                    return _isPaused;
                }
            }
        }

        class Theme
        {
            public Color primaryColor;
            public Color secondaryColor;

            public Theme(Color primary_color ,Color secondary_color)
            {
                primaryColor = primary_color;
                secondaryColor = secondary_color;
            }
        }

        class ThemeManager
        {
            TabControl _tabControl;
            string _currentThemeKey;
            Theme _currentTheme;
            Dictionary<string, Theme> _themes = new Dictionary<string, Theme>();

            public ThemeManager( TabControl tab_control)
            {
                _tabControl = tab_control;
            }

            void SetChildsTheme(Control cntrl, Theme theme_to_apply)
            {
                foreach (Control child in cntrl.Controls)
                {
                    child.BackColor = theme_to_apply.secondaryColor;
                    child.ForeColor = theme_to_apply.primaryColor;
                    SetChildsTheme(child, theme_to_apply);
                }
            }

            void SwitchThemeTo(Theme theme)
            {
                foreach (TabPage tab in _tabControl.TabPages)
                {
                    tab.BackColor = theme.primaryColor;
                    SetChildsTheme(tab, theme);
                }
            }

            public bool Add(Color primary_color, Color secondary_color, string key)
            {
                if (key == "")
                    return false;
                _themes.Add(key, new Theme(primary_color,secondary_color));
                return true;
            }

            public bool SwitchTo(string theme_key)
            {
                if (!_themes.ContainsKey(theme_key))
                    return false;
                _currentTheme = _themes[theme_key];
                _currentThemeKey = theme_key;
                SwitchThemeTo(_currentTheme);
                return true;
            }

            public bool IsExistWith(string key)
            {
                return _themes.ContainsKey(key);
            }
        
            public string CurrentThemeKey
            {
                get 
                {
                    return _currentThemeKey;
                }
            }
        }
     
        class TimerManager
        {
            CountDownTimer _timer;
            MaskedTextBox _timerTxtBx;
            Button _startBtn, _stopBtn, _snapshotBtn, _resetBtn, _clearSnapshotsBtn;
            ProgressBar _prgrssBr;
            ComboBox _snapshotsCmbBx;
            NotifyIcon notifyIcon = new NotifyIcon();
            System.Windows.Forms.Timer _updateUITimer = new System.Windows.Forms.Timer();
            enum Status {Start, Stop, Reset, ClearSnapshots, Done};

            void initNotifyicon()
            {
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Timer Timeout";
                notifyIcon.Icon = SystemIcons.Information;
            }

            public TimerManager(MaskedTextBox timer_txtBx,Button start_btn,Button stop_btn,Button snapshot_btn,Button reset_btn,ProgressBar prgrssBr,ComboBox snapshots_cmbBx,Button clear_snapshots_btn)
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

        class ChronoManager
        {
            Stopwatch _chrono = new Stopwatch();
            Label _label;
            Button _startBtn, _stopBtn, _snapshotBtn, _resetBtn,_clearSnapshotsBtn;
            ComboBox _snapshotsCmbBx;
            System.Windows.Forms.Timer _updateUITimer = new System.Windows.Forms.Timer();
            enum Status { Start, Stop, Reset };

            public ChronoManager(Label time_lbl, Button start_btn,Button stop_btn,Button snapshot_btn,Button reset_btn,Button clear_snapshots_btn,ComboBox snapshots_cmboBx)
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
