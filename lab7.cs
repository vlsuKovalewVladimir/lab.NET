using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Постройте таблицу значений функции y=ln(x-1) для  х на [a, b]  с шагом h.
    /// Если в некоторой точке x функция не определена, то выведите на экран 
    /// сообщение об этом.
    /// </summary>
    class lab7
    {
        public lab7()
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());

                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("y({0})={1}", i, e.Message);
                    }
            }

            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            

        }

        private double f(double x)
        {
            if ((x-1) <= 0) throw new Exception("Функция в этой точне не определена!");
            return Math.Log(x - 1);
        }
    }
}
