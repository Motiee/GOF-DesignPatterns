using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.operation()");
        }
    }
}
