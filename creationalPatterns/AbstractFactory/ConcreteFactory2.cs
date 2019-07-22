﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ConcreteFactory2:AbstractFactory
    {
        public override void Start()
        {
            Console.WriteLine("ConcreteFactory2");
        }

        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
