using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
