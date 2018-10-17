using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    class AND : LogicGate
    {
        public AND(LogicGate input1, LogicGate input2)
        {
            previous_1 = input1;
            previous_2 = input2;
           
            previous_1.StatusChange += OutputChange;
            previous_2.StatusChange += OutputChange;

            Output = previous_1.Output && previous_2.Output;

        }
        public override void SetOutput(bool value)
        {
            throw new NotImplementedException();
        }

        protected override void OutputChange()
        {
            Output = previous_1.Output && previous_2.Output;
        }
    }
}
