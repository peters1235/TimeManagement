using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeManagement
{
    class Pomodoro
    {
        public event EventHandler TimeOver;
        
        TimeSpan _timeRemain = TimeSpan.Zero;
        TimeSpan _currentTotalSpan = TimeSpan.Zero;

        TimeSpan LongTimeSpan = new TimeSpan(0, 10, 0);
        TimeSpan TickSpan = new TimeSpan(0, 0,1);

        public TimeSpan FocusSpan { get; set; }
        public TimeSpan RelaxSpan { get; set; }
        public TimeSpan CurrentTotalSpan
        {
            get
            {
                return _currentTotalSpan;
            }
        }

        public TimeSpan TimeRemain
        {
            get { return _timeRemain; }
        }

        public Pomodoro()
        {
            FocusSpan = new TimeSpan(0, 25, 0);
            RelaxSpan = new TimeSpan(0, 5, 0);
            _timeRemain = FocusSpan;
            _currentTotalSpan = FocusSpan;
        }

        public void StartFocus()
        {
            StartSpan(FocusSpan);            
        }

        private void StartSpan(TimeSpan span)
        {
            _timeRemain = span;
            _currentTotalSpan = span;
        }

        public void StartLongRelax()
        {
            StartSpan(LongTimeSpan);            
       }

        public void StartRelax()
        {
            StartSpan(RelaxSpan);         
        }

        public void Tick()
        {
            _timeRemain = _timeRemain.Subtract(TickSpan);
            if (_timeRemain.TotalSeconds == 0)
            {
                if (TimeOver != null)
                {
                    TimeOver(this, null);
                }
            }
        }
    }
}
