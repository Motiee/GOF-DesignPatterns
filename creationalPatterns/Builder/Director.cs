using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Director
    {
        private Builder builder;

        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            Console.WriteLine("Directing building of a product...");
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }
}
