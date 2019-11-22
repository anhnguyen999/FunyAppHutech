using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Teacher : Person
    {
        public double Salary { get; set; }
        public float Mark { get; set; }

        public Person(string fullName, string faculty)
        {
            this.Faculty = faculty;
            this.Fullname = fullName;
        }
    }
}