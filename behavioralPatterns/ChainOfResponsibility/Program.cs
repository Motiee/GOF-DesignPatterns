using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2(h1);
            var h3 = new ConcreteHandler3(h2);

            h3.HandleRequest(8);
            h3.HandleRequest(12);
            h3.HandleRequest(3);
            h3.HandleRequest(24);
            h3.HandleRequest(19);
            h3.HandleRequest(33);
            h3.HandleRequest(17);
            h3.HandleRequest(1);
            h3.HandleRequest(15);
            h3.HandleRequest(28);


            Console.ReadKey();
        }
    }
}
