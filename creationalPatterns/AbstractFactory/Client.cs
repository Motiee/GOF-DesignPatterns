using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        private AbstractFactory factory;

        public void SetFactory(AbstractFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            factory.Start();
            var p1 = factory.CreateProductA();
            var p2 = factory.CreateProductB();
            p1.Display();
            p2.Show();
        }
    }
}
