using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Facade facade   =new Facade();
            facade.ServiceX();
            facade.ServiceY();
            facade.ServiceZ();

        Console.ReadKey();
        }
    }
}
