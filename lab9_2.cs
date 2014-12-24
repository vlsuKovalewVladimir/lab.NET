using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    /// </summary>
    class lab9_2
    {
        public lab9_2()
        {
            Console.WriteLine("Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            string s = Console.ReadLine();

            string[] words = s.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                Console.WriteLine(words[i]);
        }
    }
}
