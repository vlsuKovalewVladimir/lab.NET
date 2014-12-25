using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab16
{
    /// <summary>
    /// Замечания:
    ///     1.	Во всех задачах данного раздела подразумевается, что исходная информация
    ///         хранится в текстовом файле input.txt, каждая строка которого содержит полную 
    ///         информацию о некотором объекте, результирующая информация должна быть записана 
    ///         в файл output.txt.
    ///     2.	Для хранения данных внутри программы организовать массив структур. 
    ///     3.	В типе структура реализуется метод CompareTo интерфейса IComparable, 
    ///         перегружается метод ToString базового класса object и необходимые операции 
    ///         отношения, поля данных и дополнительные методы продумайте самостоятельно.
    ///        
    /// Задание:
    ///     	На основе данных входного файла составить список сотрудников учреждения, 
    ///     	включив следующие данные: ФИО,  год принятия на работу, должность, зарплата,  
    ///     	рабочий стаж. Вывести в новый файл информацию о сотрудниках, имеющих зарплату ниже 
    ///     	определенного уровня, отсортировав их по рабочему стажу.
    /// </summary>
    class lab16
    {
        public lab16()
        {
            List<Employeem> listEmployeem1 = new List<Employeem>();

            StreamReader fileIn = new StreamReader("input.txt");
            while (!fileIn.EndOfStream)
            {
                string s = fileIn.ReadLine();
                string[] arr = s.Split('|');

                Employeem e = new Employeem(arr[0], arr[1], arr[2], UInt32.Parse(arr[3]), Int32.Parse(arr[4]));
                listEmployeem1.Add(e);
            }
            fileIn.Close();

            foreach (Employeem e in listEmployeem1)
            {
                Console.WriteLine("--------------------------");
                e.print();
            }

            
            StreamWriter fileOut = new StreamWriter("output.txt", false);
            List<Employeem> listEmployeem2 = new List<Employeem>();
            Console.Write("\n\nВведите уровень зарплаты: ");
            uint a = UInt32.Parse(Console.ReadLine());
            foreach (Employeem e in listEmployeem1)
                if (e.Salary <= a)
                    listEmployeem2.Add(e);

            listEmployeem2.Sort();
            foreach (Employeem e in listEmployeem2)
            {
                fileOut.WriteLine(e.ToString() + "\n----------------------");
                Console.WriteLine("--------------------------");
                e.print();
            }
            Console.WriteLine("Создан output.txt");

            fileOut.Close();
        }
    }
}
