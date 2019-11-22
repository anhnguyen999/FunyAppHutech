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
        public Teacher()
        {

        }
        public Teacher(string fullName, double salary, string faculty)
        {
            Salary = salary;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Salary = ");
            Salary = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            Console.WriteLine("Salary = " + this.Salary);
            base.Output();
        }
    }
}
