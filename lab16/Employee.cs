using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab16
{
    class Employeem : IComparable
    {
        private string lastName;
        private string yearOfEmployment;
        private string post;
        private uint salary;
        private int experience;

        public uint Salary
        {
            get { return salary; }
        }

        public Employeem(string lastName, string yearOfEmployment, string post, uint salary, int experience)
        {
            this.lastName = lastName;
            this.yearOfEmployment = yearOfEmployment;
            this.post = post;
            this.salary = salary;
            this.experience = experience;
        }

        public void print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return String.Format(
                    "lastName: {0}\nyearOfEmployment: {1}\npost: {2}\nsalary: {3}\nexperience: {4}",
                    lastName, yearOfEmployment, post, salary, experience
                    );
        }

        public int CompareTo(object obj)
        {
            Employeem e = (Employeem)obj;
            if (this.experience > e.experience)
                return 1;
            if (this.experience < e.experience)
                return -1;
            return 0;
        }
    }
}
