using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    class OR : LogicGate
    {
        public OR()
        {

        }
        public OR(LogicGate input1, LogicGate input2)
        {
            previous_1 = input1;
            previous_2 = input2;

            previous_1.StatusChange += OutputChange;
            previous_2.StatusChange += OutputChange;

            Output = previous_1.Output || previous_2.Output;

        }

        public override bool getOutput()
        {
            return Output;
        }

        private void OutputChange()
        {
            //Console.WriteLine("Działam");
            Console.WriteLine(previous_1.Output);
            Console.WriteLine(previous_2.Output);
            Output = previous_1.Output || previous_2.Output;
            //Console.WriteLine("wynik " + Output);
        }
    }
}
