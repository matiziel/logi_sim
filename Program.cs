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

            BeginCircut w1 = new BeginCircut(false);
            BeginCircut w2 = new BeginCircut(true);
            //BeginCircut w3 = new BeginCircut(false);
            //BeginCircut w4 = new BeginCircut(true);
            OR w5 = new OR(w1, w2);
            //OR w6 = new OR(w3, w4);
            //OR w7 = new OR(w5, w6);
            Console.WriteLine(w5.getOutput());
            w2.SetOutput(false);
            //w2.SetOutput(false);

            
            Console.WriteLine("Wejscia: " + w1.getOutput() + w2.getOutput());
            Console.WriteLine(w5.getOutput());
        }
    }
}
