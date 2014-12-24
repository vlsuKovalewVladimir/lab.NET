using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Дан номер карты k (6 < k < 14), определить достоинство карты. 
    /// Достоинства определяются по следующему правилу: «туз» - 14, 
    /// «король» - 13, «дама» - 12, «валет» - 11, «десятка» - 10, …, «шестерка» - 6.
    /// </summary>
    class lab4_2
    {
        public lab4_2()
        {
            Console.WriteLine(
                "Дан номер карты k (6 < k < 14), определить достоинство карты.\n" +
                "Достоинства определяются по следующему правилу: «туз» - 14,\n" +
                "«король» - 13, «дама» - 12, «валет» - 11, «десятка» - 10, …, «шестерка» - 6.");

            String s = Console.ReadLine();

            switch (s)
            {
                case "6": Console.WriteLine("шестерка"); break;
                case "7": Console.WriteLine("восьмерка"); break;
                case "8": Console.WriteLine("шестерка"); break;
                case "9": Console.WriteLine("девятка"); break;
                case "10": Console.WriteLine("десятка"); break;
                case "11": Console.WriteLine("валет"); break;
                case "12": Console.WriteLine("дама"); break;
                case "13": Console.WriteLine("король"); break;
                case "14": Console.WriteLine("туз"); break;
            }
        }
    }
}
