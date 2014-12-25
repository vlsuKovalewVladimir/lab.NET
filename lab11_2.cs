using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Дан текстовый файл. Найти номер самой длинной строки.
    /// </summary>
    class lab11_2
    {
        public lab11_2()
        {
            Console.WriteLine("Дан текстовый файл. Найти номер самой длинной строки.");
            StreamReader fileIn = new StreamReader("text.txt");
            int max = 0;
            int i = 0;
            int k = 0;
            while(!fileIn.EndOfStream)
            {
                string s = fileIn.ReadLine();
                int len = s.Length;
                i++;
                if (len > max) 
                {
                    max = len;
                    k = i;
                }
            }
            fileIn.Close();
            Console.WriteLine(k);
        }
    }
}
