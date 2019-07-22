using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            Component c=new Composite("root",new Component[]
                {
                    new Leaf("leaf A"), 
                    new Leaf("leaf B"), 
                    new Composite("Composite x",new Component[]
                    {
                        new Leaf("leaf XA"),
                        new Leaf("leaf XB"), 
                    }), 

                    new Leaf("leaf c"), 
                }
                
                );

            c.Display(0);

            Console.ReadKey();
        }
    }
}
