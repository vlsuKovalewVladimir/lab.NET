using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.lab15
{
    class Teach : Persona
    {
        private Post post;
        private int experience;

        public Teach(string lastName, Faculty faculty, DateTime dateOfBirth, Post post, int experience)
            : base(lastName, faculty, dateOfBirth)
        {
            this.post = post;
            this.experience = experience;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(String.Format("post: {0}\nexperience: {1}", post, experience));
        }
    }
}
