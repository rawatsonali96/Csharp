using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Circle : IShape
    {
        public int r;
        public int Seed = 0;
        public Circle(int R)
        {
            r = R;
        }
        public double area()
        {
            return 3.14*r*r;
        }

        public double perimeter()
        {
            return 2*3.14*r;
        }
    }
}
