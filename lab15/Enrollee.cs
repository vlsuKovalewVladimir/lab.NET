using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab15
{
    class Enrollee : Persona
    {
        public Enrollee(string lastName, Faculty faculty, DateTime dateOfBirth)
            : base(lastName, faculty, dateOfBirth)
        {
            
        }
    }
}
