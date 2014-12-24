using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// </summary>
    class lab5_2
    {
        public lab5_2()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i, a, b));

            Console.WriteLine();

            double y;
            for (double i = a; i <= b; i += h)
            {
                f(i, a, b, out y);
                Console.WriteLine("f({0:f2})={1:f4}", i, y);
            }
                
        }

        protected double f(double x, double a, double b)
        {
            double y;
            double f_x = x * x - 5 * x;

            if (f_x < 0) y = a + b;
            else if (f_x < 10) y = a - b;
            else y = a * b;

            return y;
        }

        private void f(double x, double a, double b, out double y)
        {
            double f_x = x * x - 5 * x;

            if (f_x < 0) y = a + b;
            else if (f_x < 10) y = a - b;
            else y = a * b;
        }
    }
}
