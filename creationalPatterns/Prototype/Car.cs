using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    [Serializable]
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int Year { get; set; }
    }
}
