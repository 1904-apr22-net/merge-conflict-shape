using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double Perimeter => A + B + C;

        public double Area => Math.Sqrt(Perimeter / 2 *
            (Perimeter / 2 - A) * (Perimeter / 2 - B) * (Perimeter / 2 - C));

        public TriangleType Type
        {
            get
            {
                var numEqualSides = new[] { A, B, C }.Distinct().Count();
                switch (numEqualSides)
                {
                    case 1: return TriangleType.Equilateral;
                    case 2: return TriangleType.Isosceles;
                    default: return TriangleType.Scalene;
                }
            }
        }
    }
}
