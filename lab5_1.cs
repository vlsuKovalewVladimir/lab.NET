using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Разработать метод f(x), который вычисляет значение по следующей 
    /// формуле: f(x)=cos(2x)+sin(x-3). Определить, в какой из точек а или b, 
    /// функция принимает наименьшее значение.
    /// </summary>
    class lab5_1
    {
        public lab5_1()
        {
            Console.Write(
                "Разработать метод f(x), который вычисляет значение по следующей " +
                "формуле: f(x)=cos(2x)+sin(x-3). Определить, в какой из точек а или b,\n" +
                "функция принимает наименьшее значение.\na = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());

            double f_a = f(a);
            double f_b = f(b);
            Console.WriteLine("f(a) = {0:0.00}\nf(b) = {1:0.00}", f_a, f_b);
            if (f_a < f_b)
                Console.WriteLine("В точке а");
            else
                Console.WriteLine("В точке b");
            
        }

        private double f(double x)
        {
            return Math.Cos(2 * x) + Math.Sin(x - 3);
        }
    }
}
