using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ConcreteCommand1 : Command
    {
        private IReceiver1 receiver;
        public ConcreteCommand1(IReceiver1 receiver)
        {
            this.receiver = receiver;
        }

        public override void Execute()
        {
            Console.WriteLine("ConcreteCommand1.Execute()");
            this.receiver.Action1();
        }
    }
}
