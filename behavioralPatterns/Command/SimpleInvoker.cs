using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class SimpleInvoker
    {
        private Command command;
        public SimpleInvoker(Command command)
        {
            this.command = command;
        }
        public void Consume()
        {
            Console.WriteLine("\nSimpleInvoker.Consume()");
            command.Execute();
        }
    }
}
