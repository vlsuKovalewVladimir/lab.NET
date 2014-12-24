using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class lab12
    {
        /// <summary>
        /// Программным путем:
        ///     1. В папке С:\temp создайте папки К1 и К2.
        ///     2. В папке К1:
        ///         a) создайте файл t1.txt, в который запишите следующий текст : 
        ///            Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
        ///         b) создайте файл t2.txt,  в который запишите следующий текст:
        ///            Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
        ///     3. В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
        ///     4. Выведите развернутую информацию о созданных файлах.
        ///     5. Файл t2.txt перенесите в папку K2.
        ///     6. Файл  t1.txt скопируйте в папку K2.
        ///     7. Папку K2 переименуйте в ALL,  а папку K1 удалите.
        ///     8. Вывести полную информацию о файлах папки All.
        /// </summary>
        public lab12()
        {
            Console.WriteLine("Создание директорий");

            Directory.CreateDirectory(@"C:\temp");
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(@"Создание и заполнение файла C:\temp\K1\t1.txt");

            FileInfo f1 = new FileInfo(@"C:\temp\K1\t1.txt");
            if (!f1.Exists)
            {
                StreamWriter sw = f1.CreateText();
                sw.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                sw.Close();
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(@"Создание и заполнение файла C:\temp\K1\t2.txt");

            FileInfo f2 = new FileInfo(@"C:\temp\K1\t2.txt");
            if (!f2.Exists)
            {
                StreamWriter sw = f2.CreateText();
                sw.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                sw.Close();
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(@"Создание и заполнение файла C:\temp\K2\t3.txt");

            FileInfo f3 = new FileInfo(@"C:\temp\K2\t3.txt");
            if (!f3.Exists)
            {
                StreamReader sw1 = f1.OpenText();
                StreamReader sw2 = f2.OpenText();

                string s1 = sw1.ReadLine();
                string s2 = sw2.ReadLine();

                sw1.Close();
                sw2.Close();

                StreamWriter sw = f3.CreateText();
                sw.WriteLine(s1 + " " + s2);
                sw.Close();
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Информация о файлах");

            Console.WriteLine();
            Console.WriteLine("Содержимое файла " + f1.FullName + ": ");
            StreamReader sr1 = f1.OpenText();
            Console.WriteLine(sr1.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Содержимое файла " + f2.FullName + ": ");
            StreamReader sr2 = f2.OpenText();
            Console.WriteLine(sr2.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Содержимое файла " + f3.FullName + ": ");
            StreamReader sr3 = f3.OpenText();
            Console.WriteLine(sr3.ReadLine());

            sr1.Close();
            sr2.Close();
            sr3.Close();


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Перемещение файлов t1 и t2 в папку K2");

            f1.MoveTo(f3.DirectoryName + "//" + f1.Name);
            f2.MoveTo(f3.DirectoryName + "//" + f2.Name);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Переименование папки K3 в All");
            Directory.Move(@"C:\temp\K2", @"C:\temp\All");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Удаление папки K1");
            Directory.Delete(@"C:\temp\K1");

            Console.ReadKey();
        }
    }
}
