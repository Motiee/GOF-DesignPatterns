﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyA:Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
