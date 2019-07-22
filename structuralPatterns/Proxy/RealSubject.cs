using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class RealSubject:Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }
}
