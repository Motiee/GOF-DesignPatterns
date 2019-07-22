using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreator:Creator
    {
        public override Product FactoryMethod(int a)
        {
           if(a<0)
               return new ConcreteProductA();
           else if (a>0)
               return new ConcreteProductB();
           else
               return new DefaultProduct();
        }
    }
}
