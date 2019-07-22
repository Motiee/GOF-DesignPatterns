using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Builder1:Builder      
    {
        public override void BuildPart1()
        {
            Product.Part1 = "Part-A";
            Console.WriteLine("Part1 Created");
        }

        public override void BuildPart2()
        {
            Product.Part2 = "Part-B";
            Console.WriteLine("Part2 Created");
        }

        public override Product GetResult()
        {
            Product.Name = "Product I";
            Console.WriteLine(Product.Name+" Created");
            return base.GetResult();
        }
    }
}
