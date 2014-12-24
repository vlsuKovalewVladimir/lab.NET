using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Среднее геометрическое модулей двух данных чисел
    /// </summary>
    class lab3_1
    {
        public lab3_1()
        {
            Console.Write("Среднее геометрическое модулей a и b\na = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Abs(a) * Math.Abs(b));

            Console.WriteLine("(|{0}| * |{1}|)^(1/2) = {2:0.000}", a, b, c);
        }
    }
}
