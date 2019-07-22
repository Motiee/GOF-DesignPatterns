using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB.OperationImp()");
        }
    }
}
