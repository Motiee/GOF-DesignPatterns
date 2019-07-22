using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorA:Decorator
    {
       public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.operation()");
        }
    }
}
