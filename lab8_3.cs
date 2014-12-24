using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Подсчитать среднее арифметическое элементов, расположенных под побочной диагональю.
    /// </summary>
    class lab8_3
    {
        public lab8_3()
        {
            Console.WriteLine("Подсчитать среднее арифметическое элементов, расположенных под побочной диагональю.");

            int n;
            int[,] mas = lab8.inputMatr(out n);
            lab8.printMas(mas);

            int sum = 0;
            int k = 0;
            for (int i = 0; i < n ; i++)
                for (int j = n - i; j < n; j++)
                {
                    sum += mas[i, j];
                    k++;
                }

            Console.WriteLine("Cреднее арифметическое = {0:0.00}", sum / k);

        }
    }
}
