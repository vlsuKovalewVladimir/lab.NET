using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class main
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ch = new ConsoleKeyInfo();
            menu(out ch);
            while (ch.KeyChar != 'e')
            {
                try
                {
                    switch (ch.KeyChar)
                    {
                        case '1': lab1   lab1   = new lab1();   break;
                        case '2': lab2   lab2   = new lab2();   break;
                        case '3': lab3_1 lab3_1 = new lab3_1(); break;
                        case '4': lab3_2 lab3_2 = new lab3_2(); break;
                        case '5': lab4_1 lab4_1 = new lab4_1(); break;
                        case '6': lab4_2 lab4_2 = new lab4_2(); break;
                        case '7': lab5_1 lab5_1 = new lab5_1(); break;
                        case '8': lab5_2 lab5_2 = new lab5_2(); break;
                        case '9': lab6_1 lab6_1 = new lab6_1(); break;
                        case '0': lab6_2 lab6_2 = new lab6_2(); break;
                        case '-': lab7   lab7   = new lab7();   break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ошибка: {0}", e.Message);
                }

                Console.WriteLine("Нажмите на любую клавишу...");
                Console.ReadKey();
                menu(out ch);
            }          
        }

        static void menu(out ConsoleKeyInfo ch)
        {
            Console.Clear();          
            Console.WriteLine(
                "1 : lab1\n" +
                "2 : lab2\n" +
                "3 : lab3_1\n" +
                "4 : lab3_2\n" +
                "5 : lab4_1\n" +
                "6 : lab4_2\n" +
                "7 : lab5_1\n" +
                "8 : lab5_2\n" +
                "9 : lab6_1\n" +
                "0 : lab6_2\n" +
                "- : lab7\n");
            ch = Console.ReadKey();
            Console.Clear(); 
        }
    }
}
