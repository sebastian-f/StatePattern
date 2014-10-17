using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class DayState : IClockSetupState
    {
        ClockSetup clockSetup;
        int day;

        public DayState(ClockSetup clockSetup, int day)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
            }
            else
            {
                day = 1;
            }
            this.clockSetup = clockSetup;
        }
        public void PreviousValue()
        {
            if(day>1)
            day--;
        }

        public void NextValue()
        {
            if(day<31)
            day++;
        }

        public void SelectValue()
        {
            clockSetup.State = clockSetup.FinishedState;
        }

        public int SelectedValue
        {
            get { return day; }
        }
    }
}
