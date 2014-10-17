using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IClockSetupState
    {

            void PreviousValue();

            void NextValue();

            void SelectValue();

            int SelectedValue { get; }

        
    }
}
