using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Nhom CongChuaBongBong: Nguyen Van A, Nguyen Van B
/// Bai tap so 03
/// </summary>
namespace StudentManager
{
    /// <summary>
    /// Y1. Bai tap so 3: Viet ham tim kiem sinh vien thuoc khoa bat ky do user nhap vao (cntt, qtkd) thong va in ra man hinh
    /// </summary>
    class Program
    {
        static List<Student> studentList;

        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numOfStudent = 0;
            do
            {
                Console.Write("Num of Student = ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));

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
                studentList.Add(student);
            }
        }
    }
}
