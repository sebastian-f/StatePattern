using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class YearState : IClockSetupState
    {
        ClockSetup clockSetup;
        int year;

        public YearState(ClockSetup clockSetup, int year)
        {
            this.year = year;
            this.clockSetup = clockSetup;
        }
        public void PreviousValue()
        {
            year--;
        }

        public void NextValue()
        {
            year++;
        }

        public void SelectValue()
        {
            clockSetup.State = clockSetup.MonthState;
        }

        public int SelectedValue
        {
            get { return year; }
        }
    }
}
