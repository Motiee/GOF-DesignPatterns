﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ConcreteFactory1:AbstractFactory
    {
        public override void Start()
        {
            Console.WriteLine("ConcreteFactory1");
        }

        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
