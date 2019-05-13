using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class TriangleRepo:ITriangle
    {
        public double Area(int Tbase, int height)
        {
            return (Tbase * height) / 2;
        }
    }
}
