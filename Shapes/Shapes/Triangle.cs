using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle
    {
        public static double tHeight = 3.0;
        public static double tBase = 2.0;
        private string _color;
        private double _sideA;
        private double _SideB;
        public static double SideA { get; set; }
        public static double SideB { get; set; }

        public string Color { get; set; }

        public double answer1 = TriangleArea(tHeight, tBase);

        public double answer2 = TrianglePerimeter(tBase, SideA, SideB);

        private static double TrianglePerimeter(double tBase, double sideA, double sideB)
        {
            return tBase + sideA + sideB;
        }

        public static double TriangleArea(double tHeight, double tBase)
        {
            return .5 * (tHeight * tBase);
        }
    }
}
