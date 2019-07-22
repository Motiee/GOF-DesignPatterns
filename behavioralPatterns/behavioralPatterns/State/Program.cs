using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var c=new Machine();
            c.Start();
            c.Process("Hello World");
            c.Process("This is a test");
            c.Process("Another test");
            c.End();

            Console.ReadKey();
        }
    }
}
