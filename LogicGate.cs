using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    abstract class LogicGate
    {

        public abstract bool getOutput();
        public void SetOutput(bool value) { Output = value; }
        public bool Output
        {
            get { return output_; }
            set
            {
                output_ = value;
                if (StatusChange != null)
                    StatusChange();
            }
        }
        protected bool output_;
        protected LogicGate previous_1, previous_2;

        public delegate void StatusChangeDelegate();
        public event StatusChangeDelegate StatusChange;


    }
}
