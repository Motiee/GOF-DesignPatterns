using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Receiver2 : IReceiver2
    {
        public void Action2()
        {
            Console.WriteLine("Receiver2.Action2()");
        }
    }
}
