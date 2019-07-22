using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
   public abstract class Abstraction

   {
       private Implementor implementor;

       public Abstraction()
       {
           this.implementor = Implementation.GetImplementation();
       }

       public virtual void Operation()
       {
           Console.WriteLine("Abstraction.Operation()");
           Console.WriteLine("calling implementation using implementor...");
           implementor.OperationImp();
       }

   }
}
