using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student : Person
    {
        //ctrl + k + C: Comment 
        //ctrl + k + U: UnComment 
        //ctrl + k + D: Format code 
        public int StudentID { get; set; }
        public float Mark { get; set; }
        public Student()
        {
        }
    
        public Student(int studentID, float mark, string fullName, string faculty) : base(fullName,faculty)
        {
            StudentID = studentID;
            Mark = mark;
        }

        internal void Input()
        {
            Console.WriteLine("-----Begin-----");
            Console.Write("Student ID = ");
            StudentID = int.Parse(Console.ReadLine());
            Console.Write("Full Name = ");
            FullName = Console.ReadLine();
            Console.Write("Mark = ");
            Mark = float.Parse(Console.ReadLine());
            Console.Write("Falculty = ");
            Falculty = Console.ReadLine();
            Console.WriteLine("-----End-----");
        }
        internal void Output()
        {
            Console.WriteLine("Student ID = " + this.StudentID);
            Console.WriteLine("FullName = " + this.FullName);
            Console.WriteLine("Mark = " + this.Mark);
            Console.WriteLine("Falculty = " + this.Falculty);
        }
    }
}
