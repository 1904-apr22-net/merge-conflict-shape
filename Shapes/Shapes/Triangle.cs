using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public Triangle(int side1, int side2, int side3)
        {
            side1 = this.side1;
            side2 = this.side2;
            side3 = this.side3;
        }
        public int Perimeter()
        {
            return side1 + side2 + side3;
        }

        public void Type()
        {
            if(side1 == side2 && side3 == side2 && side1 == side3)
            {
                Console.WriteLine("Equilateral");
            }
            else if(side1 != side2 && side3 != side2 && side1 != side3)
            {
                Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Isosceles");
            }
        }
    }
}
