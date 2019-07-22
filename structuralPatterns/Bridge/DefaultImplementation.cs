using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class DefaultImplementation : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("DefaultImplementation.OperationImp()");
        }
    }
}
