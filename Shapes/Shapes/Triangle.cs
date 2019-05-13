using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public enum TriangleType
    {
        Scalene = 1, // no two sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Equilateral = 3, // all sides are the same length
        Error = 4 // inputs can't produce a triangle
    }
    public class Triangle
    {
        public string color { get; set; }
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double baseT { get; set; }
        public double height { get; set; }
        public TriangleType TriangleType { get; private set; }

        public double GetArea()
        {
            return (this.baseT * this.height) / 2;
        }
        public double GetPerimeter()
        {
            return sideA + sideB + baseT;
        }


        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            baseT = c;
            TriangleType = GetTriangleType(a, b, c);
        }
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            // There should also be a side length check
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            if (a == b && a == c) // These could also be their own methods
            {
                return TriangleType.Equilateral;
            }
            else if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
        
    }
}
