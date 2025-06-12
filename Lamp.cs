using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    enum State { On, Off }
    class Lamp(State State)
    {
        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
        class Switch
        {
            private Lamp lamp;
            public Switch(Lamp device)
            {
                this.lamp = device;
            }
            public void Press()
            {
                lamp.Operate();
            }
        }
    }
}
