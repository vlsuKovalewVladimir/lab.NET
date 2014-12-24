using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Удалите из сообщения все знаки препинания.
    /// </summary>
    class lab10
    {
        public lab10()
        {
            Console.WriteLine("Удалите из сообщения все знаки препинания.");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            s.Replace(".", " ");
            s.Replace(",", " ");
            s.Replace("?", " ");
            s.Replace(":", " ");
            s.Replace(";", " ");
            s.Replace("!", " ");
            Console.WriteLine(s.ToString());            
        }
    }
}
