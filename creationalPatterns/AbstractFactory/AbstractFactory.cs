using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
  abstract  class AbstractFactory
  {
      public abstract void Start();
      public abstract AbstractProductA CreateProductA();
      public abstract AbstractProductB CreateProductB();
  }
}
