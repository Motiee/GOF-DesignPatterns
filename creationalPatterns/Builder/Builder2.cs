using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Builder2:Builder
    {
        public override void BuildPart1()
        {
            Product.Part1 = "Part-X";
            Console.WriteLine("Part1 Created");
        }

        public override void BuildPart2()
        {
            Product.Part2 = "Part-Y";
            Console.WriteLine("Part2 Created");
        }

        public override Product GetResult()
        {
            Product.Name = "Product II";
            Console.WriteLine(Product.Name + " Created");
            return base.GetResult();
        }
    }
}
