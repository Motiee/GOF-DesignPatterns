using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class MachineEndState:MachineState
    {

        public override void Start(Machine machine)
        {
            Console.WriteLine("State Changed=>START");
            Console.WriteLine("Machine started");
            machine.State = new MachineStartState();
        }

        public override void Process(Machine machine, string data)
        {
            Console.WriteLine("Machine has not started yet!!");
        }

        public override void End(Machine machine)
        {
            Console.WriteLine("Machine is ended already!!");
        }
    }
}
