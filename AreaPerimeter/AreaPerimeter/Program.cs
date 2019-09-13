using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, r, l, b, x, y, z;
            List<IShape> shape = new List<IShape>();
            for (i = 0; i < 5; i++)
            {
                Random rnd = new Random(i + 1);
                l = rnd.Next(1, 10);
                b = rnd.Next(1, 10);
                shape.Add(new Rectangle(l, b));
            }
            for (i = 0; i < 5; i++)
            {
                Random rnd = new Random(i + 1);
                r = rnd.Next(1, 10);
                shape.Add(new Circle(r));
            }
            for (i = 1; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Random rnd = new Random(i + 2);
                    x = rnd.Next(1, 10);
                    y = rnd.Next(1, 10);
                    z = rnd.Next(1, 10);
                }

                else
                {
                    Random rnd = new Random(i + 4);
                    x = rnd.Next(1, 10);
                    y = rnd.Next(1, 10);
                    z = rnd.Next(1, 10);
                }

                shape.Add(new Triangle(x, y, z));
            }
            Console.WriteLine("Area is:");
            foreach (var item in shape)
            {
                Console.WriteLine(item.area());
            }
            Console.WriteLine("Perimeter is:");
            foreach (var item in shape)
            {
                Console.WriteLine(item.perimeter());
            }
        }
    }
}
