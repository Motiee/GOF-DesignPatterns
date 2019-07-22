using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
   abstract class Decorator:Component
   {

       protected Component Component;

        public Decorator(Component component)
        {
           this.Component = component;
        }

       public override void Operation()
       {
           Component.Operation();
       }
   }
}
