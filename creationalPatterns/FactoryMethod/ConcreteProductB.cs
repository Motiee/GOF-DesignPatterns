using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProductB : Product
    {
        public override void Show()
        {
            Console.WriteLine("I'm ConcreteProductB");
        }
    }
}
