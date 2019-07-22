using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1=new ConcreteFactory1();
            var client=new Client();
            client.SetFactory(factory1);
            client.Run();

            Console.WriteLine();

            var factory2 = new ConcreteFactory2();
            client.SetFactory(factory2);
            client.Run();



            Console.ReadKey();
        }
    }
}
