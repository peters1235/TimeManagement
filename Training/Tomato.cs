using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training
{
    class Tomato
    {        
        public event EventHandler TimeOver;
        
        TimeSpan _timeRemain = TimeSpan.Zero;
        public TimeSpan FocusSpan { get; set; }
        public TimeSpan RelaxSpan { get; set; }

        public TimeSpan TimeRemain 
        {
            get { return _timeRemain; } 
        }

        public Tomato()
        {
            FocusSpan = new TimeSpan(0, 25, 0);
            RelaxSpan = new TimeSpan(0, 5, 0);
        }

        public void StartFocus()
        {
            _timeRemain = FocusSpan;
            
        }

        public void StartLongRelax()
        {
            _timeRemain = new TimeSpan(0, 10, 0); ;
        }

        public void StartRelax()
        {
            _timeRemain = RelaxSpan;
        }

        public void Tick()
        {
            _timeRemain = _timeRemain.Subtract(new TimeSpan(0, 0, 1));
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
