using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
