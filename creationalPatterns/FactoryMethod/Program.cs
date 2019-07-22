using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator=new ConcreteCreator();
            Product p;

            p = creator.FactoryMethod(-1);
            p.Show();
            p = creator.FactoryMethod(1);
            p.Show();
            p = creator.FactoryMethod(0);
            p.Show();

            Console.ReadKey();
        }
    }
}
