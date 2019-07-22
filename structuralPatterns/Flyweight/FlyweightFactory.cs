using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class FlyweightFactory
    {

        private Dictionary<char, Flyweight> flyweights = new Dictionary<char, Flyweight>();
       
        public FlyweightFactory()
        {
            flyweights.Add('a', new ConcreteFlyWeight('a'));
            flyweights.Add('b', new ConcreteFlyWeight('b'));
            flyweights.Add('c', new ConcreteFlyWeight('c'));
        }

        public Flyweight GetFlyweight(char key)
        {
            return flyweights[key];
        }

      

      
    }
}
