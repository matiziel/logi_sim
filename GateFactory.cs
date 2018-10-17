using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    enum Type { OR,NOR,AND,NAND};
    class GateFactory
    {
        
        public static LogicGate CreateGate(LogicGate input1, LogicGate input2, Type name)
        {
            switch (name)
            {
                case Type.OR: 
                    return new OR(input1, input2);
                case Type.NOR:
                    return new NOR(input1, input2);
                case Type.AND:
                    return new AND(input1, input2);
                case Type.NAND:
                    return new NAND(input1, input2);
                default:
                    throw new ArgumentException();
                    
            }
        }
        public static LogicGate CreateGate(LogicGate input)
        {
            return new NOT(input);
        }
    }
}
