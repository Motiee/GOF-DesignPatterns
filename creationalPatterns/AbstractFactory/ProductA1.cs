using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ProductA1:AbstractProductA
    {
        public override void Display()
        {
          Console.WriteLine("ProductA1");
        }
    }
}
