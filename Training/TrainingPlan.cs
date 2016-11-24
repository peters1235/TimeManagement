using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training
{
    class TrainingPlan
    {
        public int FirstSpan { get; set; }

        public int SecondSpan { get; set; }

        public int ThirdSpan { get; set; }

        public void GetPlan()
        {
            this.FirstSpan = int.Parse(Training.Properties.Resources.FirstTimeSpan);
            this.SecondSpan = int.Parse(Training.Properties.Resources.SecondTimeSpan);
            this.ThirdSpan = int.Parse(Training.Properties.Resources.ThirdTimeSpan);
        }
    }
}
