using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// <summary>
// VAJ : Duong Quang Vinh, Le Thanh An
// </summary>
namespace StudentManager
{
    // <summary>
    // Y1. Bai tap so 3: Viet ham tim kiem sinh vien thuoc khoa bat ky do user nhap vao (cntt, qtkd) thong va in ra man hinh
    //Y2. Viet them 1 lop (1 file) person lam lop cha cho lop studen, chuyen 1 thuoc tinh FullName qua lop person (ke thua)
    // </summary>
    class Program
    {
        static List<Student> studentList;

        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numOfStudent = 0;
            Console.Write("Num of Student = ");
            do
            {

            }while (!int.TryParse(Console.ReadLine(),out numOfStudent));

          
            //Tao dah sach sinh vien
            InputStudentList(numOfStudent);
            OutputStudentList();
            Console.Write("Nhap khoa can tim: ");
            String Faculty = Console.ReadLine();
            SearchFaculty(Faculty);
            Console.ReadKey();
        }

        private static void SearchFaculty()
        {
           
            foreach(Student item in studentList)
                if
            {

            }
        }

        //
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
            studentList = new List<Student>;
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

