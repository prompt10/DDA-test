using System;

namespace DDA_test
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, dx, dy, step;
            string x1s, y1s, x2s, y2s;
            x1s = Console.ReadLine();
            y1s = Console.ReadLine();
            x2s = Console.ReadLine();
            y2s = Console.ReadLine();
            double x1 = double.Parse(x1s);
            double y1 = double.Parse(y1s);
            double x2 = double.Parse(x2s);
            double y2 = double.Parse(y2s);
            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                double i;
                for (i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                }
            }
            else
            {
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
                double i;
                for (i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                }
            }
            

        }
    }
}
