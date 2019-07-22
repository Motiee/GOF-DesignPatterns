using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ProductB1:AbstractProductB
    {
        public override void Show()
        {
            Console.WriteLine("ProductB1");
        }
    }
}
