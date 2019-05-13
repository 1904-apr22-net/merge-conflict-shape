using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {

        public int sideA { get; set; }
        
        public int sideB { get; set; }

        public int sideC { get; set; }

        public double perimeter => sideA + sideB + sideC;

        public double area => Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));





    }
}
