using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Nhom HBT: Bui Nguyen Kim Ngan, Truong Vo Khoi
///  Bai tap so 03
/// </summary>
namespace StudentManager
{
    class Program
    {
        static Student[] studentList;

        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numOfStudent;
            Console.Write("Num of Student = ");
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input Number Of Student! - {0}", ex.Message);
                Console.ReadKey();
                return;
            }

            //Tao dah sach sinh vien
            InputStudentList(numOfStudent);
            OutputStudentList();
            Console.ReadKey();
        }

        /// <summary>
        /// Hàm xuất danh sách sinh viên
        /// </summary>
        private static void OutputStudentList()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine("Student ID = {0}", student.StudentID);
                //tuong tu
            }
        }

        private static void InputStudentList(int numOfStudent)
        {
            //Tao mang luu danh sach sinh vien
            studentList = new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("Student ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                //Luu doi tuong sinh vien vao danh sach
                studentList[i] = student;
            }
        }
    }
}
