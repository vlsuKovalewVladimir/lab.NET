using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Разработать рекурсивный метод для вычисления числа 
    /// сочетаний C(n, m) где  0<m<n. 
    /// </summary>
    class lab6_1
    {
        public lab6_1()
        {
            Console.WriteLine("Разработать рекурсивный метод для вычисления числа сочетаний C(n, m)");
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = Int32.Parse(Console.ReadLine());

            Console.WriteLine("C({0},{1}) = {2}", n, m, c(n, m));
        }

        private long c(int n, int m)
        {
            if (!((0 <= m) && (m <= n)))
                throw new Exception(String.Format("не выполняется 0<={0}<={1}", m, n));
            if((n == 0) || (n==m))
                return 1;
            return c(n - 1, m) + c(n - 1, m - 1);
            
        }
    }
}
