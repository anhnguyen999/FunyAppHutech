using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        //ctrl + k + C: Comment 
        //ctrl + k + U: UnComment 
        //ctrl + k + D: Format code 
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark { get; set; }
        public string Falculty { get; set; }

        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = mark;
            Falculty = faculty;
        }

        internal void Input()
        {
            Console.WriteLine("---Begin---");
            Console.Write("Student ID = ");
            this.StudentID = int.Parse(Console.ReadLine());
            Console.Write("FullName = ");
            this.FullName = Console.ReadLine();
            Console.Write("Mark = ");
            this.Mark = float.Parse(Console.ReadLine());
            Console.Write("Faculty = ");
            this.Falculty = Console.ReadLine();
            Console.WriteLine("---End---");
        }

        internal void Output()
        {
            Console.WriteLine("ID: {0}\nFullName: {1}\nMark: {2}\nFaculty: {3}", StudentID, FullName, Mark, Falculty);
        }
    }
}
