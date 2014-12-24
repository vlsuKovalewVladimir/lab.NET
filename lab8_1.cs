using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Все элементы, меньшие заданного числа k, увеличить в два раза.
    /// </summary>
    class lab8_1
    {
        public lab8_1()
        {
            Console.WriteLine("Все элементы, меньшие заданного числа k, увеличить в два раза.");

            int n1, n2, m2;
            int[] mas1 = lab8.inputMas(out n1);
            int[,] mas2 = lab8.inputMas(out n2, out m2);

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            lab8.printMas(mas1);
            for (int i = 0; i < n1; ++i)
                if (mas1[i] < k) mas1[i] *= 2;
            lab8.printMas(mas1);

            lab8.printMas(mas2);
            for (int i = 0; i < n2; ++i)
                for (int j = 0; j < m2; ++j)
                    if (mas2[i,j] < k) mas2[i,j] *= 2;
            lab8.printMas(mas2);

        }
    }
}
