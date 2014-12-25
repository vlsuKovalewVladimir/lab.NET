using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab15
{
    class Student : Persona
    {
        private byte course;

        public Student(string lastName, Faculty faculty, DateTime dateOfBirth, byte course)
            : base(lastName, faculty, dateOfBirth)
        {
            this.course = course;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(String.Format("course: {0}", course));
        }
    }
}
