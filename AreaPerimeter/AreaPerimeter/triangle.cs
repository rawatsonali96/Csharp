using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Triangle : IShape
    {
        public int a, b, c;
        public Triangle(int A, int B, int C)
        {
            a = A;
            b = B;
            c = C;

        }
        public double area()
        {
            int s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); ;
        }

        public double perimeter()
        {
            return a + b + c;
        }
    }
}
