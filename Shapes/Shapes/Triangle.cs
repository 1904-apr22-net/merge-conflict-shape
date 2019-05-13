using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {
        int Height { get; set; }
        int BaseSide { get; set; }

        int Side1 { get; set;}
        int Side2 { get; set; }

        public int area()
        {
            return ((this.Height * this.BaseSide) / 2);
        }

        public bool isEquilateral()
        {
            if(this.Side1== this.Side2 && this.Side1 == this.BaseSide)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isScalene()
        {
            if (this.Side1 == this.Side2 && this.Side1 != this.BaseSide)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
