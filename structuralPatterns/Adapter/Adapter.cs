using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Adapter:Target

    {
        private Adaptee adaptee=new Adaptee();
        public override void Request()
        {
           Console.WriteLine("Adapter.Request()");
           Console.WriteLine("Redirecting Requet To the Adaptee...");
           adaptee.SpecificRequest();
        }
    }
}
