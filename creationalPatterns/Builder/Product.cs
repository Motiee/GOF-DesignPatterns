using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Product
    {
        public string Name { get; set; }
        public string Part1 { get; set; }
        public string Part2 { get; set; }

        public void Display()
        {
            Console.WriteLine("\nProduct Name:"+this.Name);
            Console.WriteLine("\nPart1:" + this.Part1);
            Console.WriteLine("\nPart2:" + this.Part2);
            Console.WriteLine();
        }
    }
}
