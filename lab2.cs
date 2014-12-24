using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Запрашивает с клавиатуры два вещественных числа, и выводит 
    /// на экран результат деления первого числа на второе (вещественные
    /// числа выводятся с точностью до 3 знаков после запятой)
    /// </summary>
    class lab2
    {
        public lab2()
        {
            Console.Write("a/b = ?\na = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());

            double c = a / b;

            Console.WriteLine("{0:0.000} / {1:0.000} = {2:0.000}", a, b, c);
        }
    }
}
