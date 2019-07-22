using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Facade
    {
        private SubSystemA ssa;
        private SubSystemB ssb;
        private SubSystemC ssc;

        public Facade()
        {
            ssa = new SubSystemA();
            ssb = new SubSystemB();
            ssc = new SubSystemC();
        }

        public void ServiceX()
        {
            Console.WriteLine("\nFacade.ServiceX()...");
            ssa.OperationA();
            ssb.OperationB2();
        }

        public void ServiceY()
        {
            Console.WriteLine("\nFacade.ServiceY()...");
            ssc.OperationC3();
            ssb.OperationB1();
            ssb.OperationB2();
        }

        public void ServiceZ()
        {
            Console.WriteLine("\nFacade.ServiceZ()...");
            ssb.OperationB2();
            ssa.OperationA();
            ssc.OperationC2();
            ssc.OperationC1();
        }

    }
}
