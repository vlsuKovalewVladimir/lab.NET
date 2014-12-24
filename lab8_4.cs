using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Вычислить А*Х, где А – двумерная матрица, X –  вектор
    /// </summary>
    class lab8_4
    {
        public lab8_4()
        {
            Console.WriteLine("Вычислить А*Х, где А – двумерная матрица, X –  вектор");
            int n;
            int[][] a = lab8.inputMatr1(out n);
            int[] x = lab8.inputMas1(n);
            int[] result = new int[n]; 


            lab8.printMas(a);
            Console.WriteLine();
            lab8.printMas(x);
            Console.WriteLine();


            for (int i = 0; i < n; ++i)
            {
                result[i] = 0;
                for (int j = 0; j < n; ++j)
                    result[i] += a[i][j] * x[j];
            }

            lab8.printMas(result);
        }
    }
}
