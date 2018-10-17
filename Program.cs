using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    class Program
    {
        static void Main(string[] args)
        {

            LogicGate w1 = new BeginCircut(false);
            LogicGate w2 = new BeginCircut(true);
            LogicGate w3 = new BeginCircut(true);
            LogicGate w4 = new BeginCircut(true);
            LogicGate w5 = new AND(w1, w2);
            LogicGate w6 = new AND(w3, w4);
            LogicGate w8 = new NOT(w6);
            LogicGate w7 = new OR(w5, w8);
            Console.WriteLine(w5.Output);
            Console.WriteLine(w8.Output);
            Console.WriteLine("WYNIK: " + w7.Output);
            w3.SetOutput(false);
            //w6.SetOutput(false);

            Console.WriteLine(w5.Output);
            Console.WriteLine(w8.Output);
            Console.WriteLine("WYNIK: " + w7.Output);
        }
    }
}
