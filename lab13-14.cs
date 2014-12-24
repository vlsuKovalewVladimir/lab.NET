using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    /// <summary>
    /// Создать класс для работы с одномерным массивом целых чисел. Разработать следующие элементы класса:
    ///     a.  Поля:
    ///         •	int [] IntArray;
    ///         •	int n.
    ///     b. Конструктор, позволяющий создать массив размерности n.
    ///     c. Методы, позволяющие:
    ///         •	ввести элементы массива с клавиатуры;
    ///         •	вывести элементы массива на экран;
    ///         •	отсортировать элементы массива в порядке возрастания.
    ///     d. Свойства:
    ///         •	возвращающее размерность массива (доступное только для чтения);
    ///         •	позволяющее домножить все элементы массива на скаляр (доступное только для записи).
    ///         
    /// Добавить в класс для работы с одномерным массивом целых чисел:    
    ///     a.	Индексатор, позволяющий по индексу обращаться к соответствующему элементу массива.
    ///     b.	Перегрузку:
    ///         •	операции ++ (--): одновременно увеличивает (уменьшает) значение всех элементов массива на 1;
    ///         •	операции !: возвращает значение true, если элементы массива не упорядочены по возрастанию, иначе false;
    ///         •	операции бинарный *:  домножить все элементы массива на скаляр;
    ///         •	преобразования класса массив в одномерный массив (и наоборот).
    /// </summary>
    class lab13
    {
        private int[] IntArray;
        private int n;

        public lab13()
        {
            lab13 l = new lab13(10);
            l.print();
            l.sort();
            l.print();
        }

        public lab13(int n) 
        {
            Random rand = new Random();
            this.n = n;
            IntArray = new int[n];
            for (int i = 0; i < n; ++i)
                IntArray[i] = rand.Next(100);
        }

        public void inputMas()
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write("IntArray[{0}]= ", i);
                IntArray[i] = int.Parse(Console.ReadLine());
            }
        }

        public void print()
        {
            if (IntArray == null) return;
            for (int i = 0; i < IntArray.Length; ++i)
                Console.Write("{0} ", IntArray[i]);
            Console.WriteLine();
        }

        public void sort()
        {
            if (IntArray == null) return;
            Array.Sort(IntArray);
        }

        public int length
        {
            get {return n;}
        }

        public void multiply(int a)
        {
            for (int i = 0; i < n; ++i)
                IntArray[i] *= a;
        }
    }
}
