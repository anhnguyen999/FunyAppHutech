using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    abstract class Person
    {
        public string Faculty { get; set; }
        public string FullName { get; set; }

        public Person()
        {

        }
        public Person(string fullName, string faculty)
        {
            this.Faculty = faculty;
            this.FullName = fullName;
        }
        public virtual void Input()
        {
            Console.Write("Full Name = ");
            FullName = Console.ReadLine();
            Console.Write("Faculty = ");
            Faculty = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("FullName = " + this.FullName);
            Console.WriteLine("Faculty = " + this.Faculty);
        }
    }
}
