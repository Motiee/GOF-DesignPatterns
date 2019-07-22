using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string extrinsicstate = "THIS IS A BIG EXTRINSIC STATE";
            FlyweightFactory factory=new FlyweightFactory();
           
            UnsharedConcreteFlyWeight flyWeight1=new UnsharedConcreteFlyWeight(new Flyweight[]
            {
                factory.GetFlyweight('a'),
                factory.GetFlyweight('a'),
                factory.GetFlyweight('b'),
                factory.GetFlyweight('c'),
                factory.GetFlyweight('a'),
                factory.GetFlyweight('c'),
            });

            UnsharedConcreteFlyWeight flyWeight2 = new UnsharedConcreteFlyWeight(new Flyweight[]
            {
                factory.GetFlyweight('c'),
                factory.GetFlyweight('b'),
                factory.GetFlyweight('b'),
                factory.GetFlyweight('a'),
                factory.GetFlyweight('c'),
                factory.GetFlyweight('b'),
            });

            flyWeight1.Operation(extrinsicstate);
            flyWeight2.Operation(extrinsicstate);


            Console.ReadKey();
        }
    }
}
