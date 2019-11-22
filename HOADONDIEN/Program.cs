using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    /// <summary>
    /// NHÓM VIP NGUYỄN THANH HOÀI - ĐINH ANH HÙNG - HUỲNH NGỌC VŨ
    /// Bài tập 03 lab 01
    /// </summary>
    class Program
    {
        static List<Customer> listCustomer = new List<Customer>();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            int chon;
            do
            {
                Console.WriteLine("-----Menu------");
                Console.WriteLine("1. Customer List Insert");
                Console.WriteLine("2. Customer List Out");
                Console.WriteLine("3. Find Bill: ");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("---------------");
                Console.Write("Vui long chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        InputDanhSach();
                        break;
                    case 2:
                        OutputDanhSach(listCustomer);
                        break;
                    case 3:
                        Console.Write("insert mm/yyyy bill to find: ");
                        DateTime NgayHoaDonNeedFind = Convert.ToDateTime(Console.ReadLine());
                        List<Customer> result = FindKhachHangByNgayHoaDon(NgayHoaDonNeedFind);
                        Console.WriteLine("Bill List: " + NgayHoaDonNeedFind);
                        OutputDanhSach(result);
                        break;
                    default:
                        Console.WriteLine("Still update pick again!");
                        break;
                }
            } while (chon != 0);
        }
        private static void InputDanhSach()
        {
            int chon;
            Customer KH;
            do
            {
                Console.WriteLine("-----Menu------");
                Console.WriteLine("1. Vietnam Customer");
                Console.WriteLine("2. Forreigner");
                Console.WriteLine("0. Exit!");
                Console.WriteLine("---------------");
                Console.Write("What you want?:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        KH = new VietnamCustomer();
                        KH.Input();
                        listCustomer.Add(KH);
                        break;
                    case 2:
                        KH = new OverseasCustomer();
                        KH.Input();
                        listCustomer.Add(KH);
                        break;
                    default:
                        Console.WriteLine("1-3 please pick again -_-");
                        break;
                }
            } while (chon != 0);
        }
        public static void OutputDanhSach(List<Customer> listInput)
        {
            foreach (var item in listInput)
            {
                item.Output();
            }
        }
        public static List<Customer> FindKhachHangByNgayHoaDon(DateTime dateTimeHoaDon)
        {
            return listCustomer.Where(kh => kh.BillDate == dateTimeHoaDon).ToList();
        }
    }
}
