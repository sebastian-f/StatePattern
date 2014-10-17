using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ClockSetup
    {
        IClockSetupState currentState;

        public ClockSetup()
        {
            FinishedState = new FinishedSetupState(this);
            currentState = FinishedState;
        }

        public IClockSetupState YearState { get; set; }
        public IClockSetupState MonthState { get; set; }
        public IClockSetupState DayState { get; set; }
        public IClockSetupState FinishedState { get; set; }

        public IClockSetupState State 
        {
            set 
            {
                currentState = value;
            }
        }

        public void PushKnob()
        {

                currentState.SelectValue();

        }

        public DateTime GetSelectedDate()
        {
            return new DateTime(YearState.SelectedValue, MonthState.SelectedValue, DayState.SelectedValue);
        }



        public void RotateRight()
        {
            currentState.NextValue();
        }

        public void RotateLeft()
        {
            currentState.PreviousValue();
        }
    }
}
