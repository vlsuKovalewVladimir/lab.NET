﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Подсчитывает количество букв в строке
    /// </summary>
    class lab9_1
    {
        public lab9_1()
        {
            Console.WriteLine("Подсчитывает количество букв в строке");
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    ind++;
            }
            Console.WriteLine("Количество букв равно {0}", ind);
        }
    }
}
