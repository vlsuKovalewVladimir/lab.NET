using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    static class lab8
    {
        public static int[] inputMas(out int n)
        {
            Random rand = new Random();
            Console.WriteLine("Введите размерность массива:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
                a[i] = rand.Next(100);
            return a;
        }

        public static int[] inputMas1(int n)
        {
            Random rand = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
                a[i] = rand.Next(100);
            return a;
        }

        public static int[,] inputMas(out int n, out int m)
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    a[i, j] = rand.Next(100);

            return a;
        }

        public static int[,] inputMatr(out int n)
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    a[i, j] = rand.Next(100);

            return a;
        }

        public static int[][] inputMatr1(out int n)
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                    a[i][j] = rand.Next(100);
            }
            return a;
        }


        public static void printMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write("{0} ", mas[i]);
            Console.WriteLine();
        }

        public static void printMas(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < mas.GetLength(1); ++j)
                    Console.Write("{0,5} ", mas[i, j]);
            Console.WriteLine("\n");
        }

        public static void printMas(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

    }
}
