using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Nhóm THC : Nguyễn Công Quốc - Vũ Văn Thời - Ngô Tuấn Trung
/// Bài tập 03
/// </summary>
namespace StudentManager
{/// <summary>
/// Y1. Bai tap so 3: Viet ham tim kiem sinh vien thuoc khoa bat ki do user nhap vao va in ra man hinh
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
            Find();
            Console.ReadKey();
        }

        /// <summary>
        /// Hàm xuất danh sách sinh viên
        /// </summary>
        private static void OutputStudentList()
        {
            foreach (var student in studentList)
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
        private static void Find()
        {
            Student student = new Student();
            Console.WriteLine("Nhap khoa can tim: ");
            String y = Console.ReadLine();
            for (int i = 0; i < studentList.Count; i++)
            {
                if(studentList[i].Falculty == y)
                {
                    Console.WriteLine(studentList[i]);
                }
            }
        }
    }
}
