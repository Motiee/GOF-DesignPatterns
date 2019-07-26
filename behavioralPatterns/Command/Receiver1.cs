using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Receiver1 : IReceiver1
    {
        public void Action1()
        {
           Console .WriteLine("Receiver1.Action1()");
        }
    }
}
