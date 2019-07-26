using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ComplexInvoker
    {
        private List<Command> commands;
        public ComplexInvoker()
        {
            commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void Consume()
        {
            Console.WriteLine("\nComplexInvoker.Consume()");
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
