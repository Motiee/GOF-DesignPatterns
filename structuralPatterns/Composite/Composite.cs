using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
   public class Composite:Component
    {
       private List<Component>components=new List<Component>();

        public Composite(string name) : base(name)
        {
        }
        public Composite(string name,Component[] components)
            : base(name)
        {
            foreach (Component component in components)
            {
                Add(component);
            }
        }


        public override void Add(Component c)
        {
            components.Add(c);
        }

        public override void Remove(Component c)
        {
            components.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Component component in components)
            {
                component.Display(depth+2);
            }
        }
    }
}
