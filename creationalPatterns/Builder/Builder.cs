using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
   abstract class Builder
   {
       protected Product Product;

       public Builder()
       {
           Product=new Product();
       }

       public abstract void BuildPart1();
       public abstract void BuildPart2();

       public virtual Product GetResult()
       {
           return Product;
       }


   }
}
