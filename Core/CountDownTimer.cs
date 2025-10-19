using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Core
{
    public class CountDownTimer
    {
        TimeSpan _targetDuration;
        Stopwatch _elapsedDurationStopWatch = new Stopwatch();
        bool _isFinished = false;
        bool _isPaused = false;

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
}
