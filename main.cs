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
            while (ch.KeyChar != '=')
            {
                try
                {
                    switch (ch.KeyChar)
                    {
                        case '1': lab1    lab1    = new lab1();    break;
                        case '2': lab2    lab2    = new lab2();    break;
                        case '3': lab3_1  lab3_1  = new lab3_1();  break;
                        case '4': lab3_2  lab3_2  = new lab3_2();  break;
                        case '5': lab4_1  lab4_1  = new lab4_1();  break;
                        case '6': lab4_2  lab4_2  = new lab4_2();  break;
                        case '7': lab5_1  lab5_1  = new lab5_1();  break;
                        case '8': lab5_2  lab5_2  = new lab5_2();  break;
                        case '9': lab6_1  lab6_1  = new lab6_1();  break;
                        case '0': lab6_2  lab6_2  = new lab6_2();  break;
                        case '-': lab7    lab7    = new lab7();    break;
                        case 'q': lab8_1  lab8_1  = new lab8_1();  break;
                        case 'w': lab8_2  lab8_2  = new lab8_2();  break;
                        case 'e': lab8_3  lab8_3  = new lab8_3();  break;
                        case 'r': lab8_4  lab8_4  = new lab8_4();  break;
                        case 't': lab9_1  lab9_1  = new lab9_1();  break;
                        case 'y': lab9_2  lab9_2  = new lab9_2();  break;
                        case 'u': lab10   lab10   = new lab10();   break;
                        case 'i': lab11_1 lab11_1 = new lab11_1(); break;
                        case 'o': lab11_2 lab11_2 = new lab11_2(); break;
                        case 'p': lab12   lab12   = new lab12();   break;
                        case 'a': lab13   lab13   = new lab13();   break;

                        case 's': lab15.lab15 lab15 = new lab15.lab15(); break;
                        case 'd': lab16   lab16   = new lab16();   break;
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
                "- : lab7\n"   +
                "q : lab8_1\n" +
                "w : lab8_2\n" +
                "e : lab8_3\n" +
                "r : lab8_4\n" +
                "t : lab9_1\n" +
                "y : lab9_2\n" +
                "u : lab10\n"  +
                "i : lab11_1\n" +
                "o : lab11_2\n" +
                "p : lab12\n" +
                "a : lab13\n" +
                "s : lab15\n" +
                "d : lab16\n" +
                "= : exit\n");
            ch = Console.ReadKey();
            Console.Clear(); 
        }
    }
}
