using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side A in full inches");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Side B in full inches");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Side C in full inches");
            int sideC = int.Parse(Console.ReadLine());

            Triangle Tri = new Triangle(sideA, sideB, sideC);



        }
    }
}
