using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ConcreteCommand2 : Command
    {

        public override void Execute()
        {
            Console.WriteLine("ConcreteCommand2.Execute()");
            var receiver = ServiceLocator.GetService<IReceiver2>();
            DoSomething();
            receiver.Action2();
        }

        private void DoSomething()
        {
            Console.WriteLine("ConcreteCommand2.DoSomething()");
        }
    }
}
