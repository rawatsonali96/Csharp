using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Rectangle : IShape
    {
        public int l, b;
        Random rnd;
        public Rectangle(int L,int B)
        {
            l = L;
            b = B;
        }
        public double area()
        {
            return l*b;
        }

        public double perimeter()
        {
            return l + b;
        }
    }
}
