using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab15
{
    abstract class Persona
    {
        private string lastName;
        private Faculty faculty;
        private DateTime dateOfBirth;

        public Persona(string lastName, Faculty faculty, DateTime dateOfBirth)
        {
            this.lastName = lastName;
            this.faculty = faculty;
            this.dateOfBirth = dateOfBirth;
        }

        public int age()
        {
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - dateOfBirth.Year;
            if (dateNow.Month < dateOfBirth.Month ||
                (dateNow.Month == dateOfBirth.Month && dateNow.Day < dateOfBirth.Day)) year--;
            return year;
        }

        public virtual void print()
        {
            Console.WriteLine(String.Format("lastName: {0}\nfaculty: {1}\ndateOfBirth: {2}.{3}.{4}", 
                lastName, faculty, dateOfBirth.Day, dateOfBirth.Month, dateOfBirth.Year));
        }
    }
}
