using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    internal class ConcreteFlyWeight:Flyweight
    {
        private char intrinsicState;

        public ConcreteFlyWeight(char intrinsicState)
        {
            this.intrinsicState = intrinsicState;
        }

        public override void Operation(string extrinsicState)
        {
            Console.WriteLine("ConcreteFlyWeight('"+intrinsicState+"'):\""+extrinsicState+"\"");
        }
    }
}
