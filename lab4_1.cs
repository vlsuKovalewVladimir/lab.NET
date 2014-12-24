using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Дана точка на плоскости с координатами (х, у). Составить программу, 
    /// которая выдает одно из сообщений «Да», «Нет», «На границе» в зависимости 
    /// от того, лежит ли точка внутри заштрихованной области, вне заштрихованной 
    /// области или на ее границе. 
    /// </summary>
    class lab4_1
    {
        public lab4_1()
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 49 && x * x + y * y > 9)
                Console.WriteLine("внутри");
            else if (x * x + y * y > 49 || x * x + y * y < 9)
                Console.WriteLine("вне");
                else Console.WriteLine("на границе");
        }
    }
}
