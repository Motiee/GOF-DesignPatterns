using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ra=new RefinedAbstraction();
            ra.Operation();

            Console.ReadKey();
        }
    }
}
