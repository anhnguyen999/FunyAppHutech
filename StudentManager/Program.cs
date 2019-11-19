using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Nhom ACB: Nguyen Nhat Nam, Giang Van Sieu 
/// Bai tap so 03
/// </summary>
namespace StudentManager
{
    /// <summary>
    /// Y1. Bai tap so 3: viet ham tim kiem sinh vien thuoc khoa cntt va in ra man hinh
    /// </summary>
    class Program
    {
        static List<Student> studentList;

        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numOfStudent;
            
            do
            {
                Console.Write("Num of Student = ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));
            //Tao danh sach sinh vien
            InputStudentList(numOfStudent);
            OutputStudentList();
            Console.ReadKey();
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
                foreach (Student student in studentList)
                {
                    student.Output();
                }
               
            }

        private static void InputStudentList(int numOfStudent)
        {
            //Tao mang luu danh sach sinh vien
            studentList = new List<Student>();
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                student.Input();
                studentList[i] = student;
            }
        }
    }
}
