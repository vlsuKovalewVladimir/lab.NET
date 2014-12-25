using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab15
{
    /// <summary>
    /// Замечания.:
    ///     1.	Полную структуру классов и их взаимосвязь продумать самостоятельно.
    ///     2.	Для абстрактного класса определить какие методы должны быть абстрактными, а какие обычными. 
    ///     3.	Исходные данные считываются из файла.
    ///     
    /// Задание:
    ///     1)	Создать абстрактный класс Persona с методами, позволяющим вывести на 
    ///         экран информацию о персоне, а также определить ее возраст (на момент текущей даты). 
    ///     2)	Создать производные классы: 
    ///           Абитуриент (фамилия, дата рождения, факультет), 
    ///           Студент (фамилия, дата рождения, факультет, курс), 
    ///           Преподавать (фамилия, дата рождения, факультет, должность, стаж),
    ///           со своими методами вывода информации на экран, и определения возраста. 
    ///     3)	Создать базу (массив) из n персон, вывести полную информацию из базы на экран, 
    ///         а также организовать поиск персон, чей возраст попадает в заданный диапазон. 
    /// </summary>
    class lab15
    {
        public lab15()
        {
            List<Persona> listPersona = new List<Persona>();

            StreamReader fileIn = new StreamReader("persona.txt");
            while (!fileIn.EndOfStream)
            {
                string s = fileIn.ReadLine();
                string[] arr = s.Split('|');
                switch (arr[0])
                {
                    case "e":
                        Enrollee e = new Enrollee(arr[1], faculty(arr[5]), new DateTime(Int32.Parse(arr[2]), Int32.Parse(arr[3]), Int32.Parse(arr[4])));
                        listPersona.Add(e);
                        break;
                    case "s":
                        Student st = new Student(arr[1], faculty(arr[5]), new DateTime(Int32.Parse(arr[2]), Int32.Parse(arr[3]), Int32.Parse(arr[4])), Byte.Parse(arr[6]));
                        listPersona.Add(st);
                        break;
                    case "t":
                        Teach t = new Teach(arr[1], faculty(arr[5]), new DateTime(Int32.Parse(arr[2]), Int32.Parse(arr[3]), Int32.Parse(arr[4])), post(arr[6]), Int32.Parse(arr[7]));
                        listPersona.Add(t);
                        break;
                }
            }
            fileIn.Close();

            foreach(Persona p in listPersona)
            {
                Console.WriteLine("--------------------------");
                p.print();
            }

            Console.WriteLine("\nВведите диапазон: ");
            Console.Write("C: ");
            int a = Int16.Parse(Console.ReadLine());
            Console.Write("До: ");
            int b = Int16.Parse(Console.ReadLine());

            foreach (Persona p in listPersona)
            {
                if (p.age() >= a && p.age() <= b)
                {
                    Console.WriteLine("--------------------------");
                    p.print();
                }
            }
        }

        private Faculty faculty(string s)
        {
            switch(s)
            {
                case "FIT": return Faculty.FIT;
                case "FPMF": return Faculty.FPMF;
            }
            return Faculty.FPMF;
        }

        private Post post(string s)
        {
            switch (s)
            {
                case "Dean": return Post.Dean;
                case "Teach": return Post.Teach;
            }
            return Post.Dean;
        }
    }
}
