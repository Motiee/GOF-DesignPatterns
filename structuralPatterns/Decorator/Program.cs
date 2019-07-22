using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent cc=new ConcreteComponent();
            cc.Operation();
            Console.WriteLine();

            ConcreteDecoratorA cd1 = new ConcreteDecoratorA(cc);
            cd1.Operation();
            Console.WriteLine();

            ConcreteDecoratorB cd2 = new ConcreteDecoratorB(cc);
            cd2.Operation();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
