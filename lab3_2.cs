using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Оканчивается ли данное целое число цифрой 7
    /// </summary>
    class lab3_2
    {
        public lab3_2()
        {
            Console.WriteLine("Оканчивается ли данное целое число цифрой 7 ?");
            int a = Int32.Parse(Console.ReadLine());

            char ch = a.ToString()[a.ToString().Length-1];

            Console.WriteLine(ch == '7');
        }
    }
}
