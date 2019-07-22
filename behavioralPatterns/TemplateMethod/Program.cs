using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1=new ConcreteClassA();
            c1.TemplateMethod();

            var c2 = new ConcreteClassB();
            c2.TemplateMethod();

            Console.ReadKey();
        }
    }
}
