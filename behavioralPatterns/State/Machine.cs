using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;


namespace State
{
    class Machine
    {
        public MachineState State { get; set; }

        public Machine()
        {
            State = new MachineEndState();
        }

        public void Start()
        {
            Console.WriteLine();
            State.Start(this);
        }
        public void Process(string data)
        {
            Console.WriteLine();
            State.Process(this,data);
        }
        public void End()
        {
            Console.WriteLine();
            State.End(this);
        }
    }
}
