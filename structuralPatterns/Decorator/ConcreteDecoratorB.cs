using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component): base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB.operation()");
        }
    }
}
