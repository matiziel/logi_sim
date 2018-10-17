using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    class NOT : LogicGate
    {
        public NOT(LogicGate input)
        {
            previous_1 = input;
            previous_2 = null;

            previous_1.StatusChange += OutputChange;
            
            Output = !previous_1.Output;

        }
        public override void SetOutput(bool value)
        {
            throw new NotImplementedException();
        }

        protected override void OutputChange()
        {
            Output = !previous_1.Output;
        }
    }
}
