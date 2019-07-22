using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPrototypeManager manager=new CarPrototypeManager();
            manager.add("c1",new Car{Model = "Honda Accord",Year = 2013,Engine = new Engine()});
            manager.add("c2", new Car { Model = "Honda Sonara", Year = 2011, Engine = new Engine() });
            manager.add("c3", new Car { Model = "Toyota Prius", Year = 2013, Engine = new Engine() });

            var c1 = manager.CreateCar("c3");
            var c2 = manager.CreateCar("c3");

            Console.WriteLine("c1.model:{0}",c1.Model);
            Console.WriteLine("c2.model:{0}", c2.Model);
            Console.WriteLine("c1==c2 ? {0}", c1==c2);
            Console.WriteLine("c1.Engine==c2.Engine ? {0}", c1.Engine == c2.Engine);

            Console.ReadKey();
        }
    }
}
