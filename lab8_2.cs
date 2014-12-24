using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Поменять местами максимальный элемент и первый.
    /// </summary>
    class lab8_2
    {
        public lab8_2()
        {
            Console.WriteLine("Поменять местами максимальный элемент и первый.");

            int n;
            int[] mas = lab8.inputMas(out n);
            lab8.printMas(mas);

            int max = mas[0];
            int k = 0;
            for (int i = 0; i < n; i++)
                if (mas[i] > max)
                {
                    max = mas[i];
                    k = i;
                }

            int temp = mas[0];
            mas[0] = mas[k];
            mas[k] = temp;

            lab8.printMas(mas);
        }
    }
}
