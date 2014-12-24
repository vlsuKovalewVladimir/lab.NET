using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Дана последовательность из n целых чисел. Создать файл и записать в него 
    /// все четные числа последовательности. Вывести содержимое файла на экран.
    /// </summary>
    class lab11_1
    {
        public lab11_1()
        {
            Console.WriteLine("Дана последовательность из n целых чисел. Создать файл и записать в него все четные числа последовательности. Вывести содержимое файла на экран.");
            int n = 10;
            int[] mas = lab8.inputMas1(n);
            lab8.printMas(mas);

            FileStream f = new FileStream("t.dat", FileMode.Create);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
                if ((mas[i] % 2) == 0) fOut.Write(mas[i]);
            fOut.Close();

            f = new FileStream("t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length; 
            for (long i = 0; i < m; i += 4)
            {
                f.Seek(i, SeekOrigin.Begin);
                int a = fIn.ReadInt16();
                Console.Write("{0} ", a);
            }

            fIn.Close();

            f.Close();

            Console.WriteLine();
        }
    }
}
