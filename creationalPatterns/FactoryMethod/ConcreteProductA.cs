using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProductA:Product
    {
        public override void Show()
        {
            Console.WriteLine("I'm ConcreteProductA");
        }
    }
}
