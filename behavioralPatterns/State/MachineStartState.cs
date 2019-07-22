using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace State
{
    class MachineStartState:MachineState
    {
        public override void Start(Machine machine)
        {
            Console.WriteLine("Machine is already started !!");
        }

        public override void Process(Machine machine, string data)
        {
          machine.State = new MachineProcessingState();
          machine.State.Process(machine,data);
        }

        public override void End(Machine machine)
        {
            Console.WriteLine("State Changed=>End");
            Console.WriteLine("Machine ended.");
            machine.State=new MachineEndState();
        }
    }
}
