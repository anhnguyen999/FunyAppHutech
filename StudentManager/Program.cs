using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Nhóm VIP : NGUYỄN THANH HOÀI - ĐINH ANH HÙNG - HUỲNH NGỌC VŨ
/// Bài tập 03
/// </summary>
namespace StudentManager
{/// <summary>
/// Y1. Bai tap so 3: Viet ham tim kiem sinh vien thuoc khoa bat ki do user nhap vao va in ra man hinh
/// Y2. Viet them 1 lop Person lam lop cha cho lop Student chuyen 1 thuoc tinh Falculty Qua person
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
            OutputStudentList(studentList);
            Console.WriteLine("Nhap khoa can tim: ");
            String falculty = Console.ReadLine();
            List<Student> result = FindStudentsByFaculty(falculty);
            Console.WriteLine("DS sinh vien thuoc khoa {0}", falculty);
            OutputStudentList(result);
            Console.ReadKey();
        }

        /// <summary>
        /// Hàm xuất danh sách sinh viên
        /// </summary>
        private static void OutputStudentList(List<Student> inputList)
        {
            foreach (var student in inputList)
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
                //Luu doi tuong sinh vien vao danh sach
                studentList.Add(student);
            }
        }
        private static List<Student> FindStudentsByFaculty(String falculty)
        {
            return studentList.Where(s => s.Falculty == falculty.ToLower()).ToList();
        }
    }
}
