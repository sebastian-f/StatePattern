using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class MonthState : IClockSetupState
    {
        ClockSetup clockSetup;
        int month;

        public MonthState(ClockSetup clockSetup, int month)
        {
            if (month >= 1 && month <= 12)
            {
                this.month = month;
            }
            else
            {
                month = 1;
            }
            this.clockSetup = clockSetup;
        }
        public void PreviousValue()
        {
            if (month > 1)
                month++;
        }

        public void NextValue()
        {
            if(month<12)
                month++;
        }

        public void SelectValue()
        {
            clockSetup.State = clockSetup.DayState;
        }

        public int SelectedValue
        {
            get { return month; }
        }
    }
}
