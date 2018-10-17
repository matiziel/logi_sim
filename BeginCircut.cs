using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    class BeginCircut : LogicGate
    {

        public BeginCircut(bool value)
        {
            previous_1 = null;
            previous_2 = null;
            Output = value;
        }

        public override void SetOutput(bool value) { Output = value; }
        protected override void OutputChange()
        {
            throw new NotImplementedException();
        }


    }
}
