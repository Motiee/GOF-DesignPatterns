using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class MachineProcessingState:MachineState
    {
        public override void Start(Machine machine)
        {
         Console.WriteLine("Machine is already started!!");
        }

        public override void Process(Machine machine, string data)
        {
            Console.WriteLine("State Changed=>PROCESSING");
            Console.WriteLine("The length of '{0}' is: {1}",data,data.Length);
            Console.WriteLine("data processed successfully");
        }

        public override void End(Machine machine)
        {
            Console.WriteLine("State Changed=>END");
            Console.WriteLine("Machine ended");
            machine.State=new MachineEndState();
        }
    }
}
