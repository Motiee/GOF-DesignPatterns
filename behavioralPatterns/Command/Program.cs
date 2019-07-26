using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Register<IReceiver1>(new Receiver1());
            ServiceLocator.Register<IReceiver2>(new Receiver2());



            var receiver1 = ServiceLocator.GetService<IReceiver1>();
            var cmd1 = new ConcreteCommand1(receiver1);

            var invoker1 = new SimpleInvoker(cmd1);
            invoker1.Consume();

            var invoker2 = new ComplexInvoker();
            invoker2.AddCommand(new ConcreteCommand1(receiver1));
            invoker2.AddCommand(new ConcreteCommand2());
            invoker2.Consume();




            Console.ReadKey();
        }
    }
}
