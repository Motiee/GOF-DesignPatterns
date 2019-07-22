using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class UnsharedConcreteFlyWeight:Flyweight
    {
        private IEnumerable<Flyweight> flyweights;

        public UnsharedConcreteFlyWeight(IEnumerable<Flyweight> flyweights)
        {
            this.flyweights = flyweights;
        }

        public override void Operation(string extrinsicState)
        {
            Console.WriteLine("UnsharedConcreteFlyWeight:");
            foreach (Flyweight Flyweight in flyweights)
            {
               Flyweight.Operation(extrinsicState);
            }
            Console.WriteLine();
        }
    }
}
