using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Triangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public double Perimeter => Side1 + Side2 + Side3;

        public double Area => Math.Sqrt(Perimeter / 2 *
            (Perimeter / 2 - Side1) * (Perimeter / 2 - Side2) * (Perimeter / 2 - Side3));

        public TriangleType Type
        {
            get
            {
                // code like this gets nicer with upcoming
                // "switch expression" feature in C# 8.0,
                // coming in September...
                var numEqualSides = new[] { Side1, Side2, Side3 }.Distinct().Count();
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
