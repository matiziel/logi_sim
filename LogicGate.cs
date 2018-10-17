using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSim
{
    abstract class LogicGate
    {
        //Delegata do obługi zmiany stanu bramki
        public delegate void StatusChangeDelegate();
        //Zdarzenie obsługujące zmianę stanu bramki
        public event StatusChangeDelegate StatusChange;

        //Zmienia stan bramki, implementowana tylko dla BeginCircut
        //dla innych zwraca wyjątek
        public abstract void SetOutput(bool value);
        public bool Output
        {
            get { return output_; }
            protected set
            {
                output_ = value;
                if (StatusChange != null)
                    StatusChange();
            }
        }
        //wyjście 
        protected bool output_;
        //wejścia
        protected LogicGate previous_1, previous_2;

        //Metoda realizująca zdarzenie StatusChange
        protected abstract void OutputChange();
    }
}
