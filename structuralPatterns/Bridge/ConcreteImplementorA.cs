using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class ConcreteImplementorA:Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA.OperationImp()");
        }
    }
}
