using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("\nAbstractClass.TemplateMethod() started");
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
    }
}
