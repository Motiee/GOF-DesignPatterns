using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director=new Director();

            var b1=new Builder1();
            var b2=new Builder2();

            director.SetBuilder(b1);
            director.Construct();
            var p1 = b1.GetResult();
            p1.Display();

            director.SetBuilder(b2);
            director.Construct();
            var p2 = b2.GetResult();
            p2.Display();

            Console.ReadKey();
        }
    }
}
