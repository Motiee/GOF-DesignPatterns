using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class SubSystemB
    {
        public void OperationB1()
        {
            Console.WriteLine("\tSubsystemA.OperationB1()");
        }
        public void OperationB2()
        {
            Console.WriteLine("\tSubsystemA.OperationB2()");
        }
    }
}
