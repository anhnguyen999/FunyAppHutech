using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student : Person
    {
        public int StudentID { get; set; }
        public float Mark { get; set; }
        public Student()
        {
        }
        public Student(int studentID, float mark, string fullName, string faculty) : base(fullName, faculty)
        {
            StudentID = studentID;
            Mark = mark;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Student ID = ");
            StudentID = int.Parse(Console.ReadLine());
            Console.Write("Mark = ");
            Mark = float.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            Console.WriteLine("Student ID = " + this.StudentID);
            Console.WriteLine("Mark = " + this.Mark);
            base.Output();
        }
    }
}
