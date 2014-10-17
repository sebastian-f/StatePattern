using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class FinishedSetupState : IClockSetupState
    {
        ClockSetup clockSetup;

        public FinishedSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public void PreviousValue()
        {
            
        }

        public void NextValue()
        {
            
        }

        public void SelectValue()
        {
            clockSetup.State = clockSetup.YearState;
        }

        public int SelectedValue
        {
            get
            {
                throw new System.NotSupportedException("Clock setup finished");

            }
        }
    }
}
