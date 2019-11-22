using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    /// <summary>
    /// Nhóm ACB - Nguyễn Nhật Nam - Đặng Đông Thức - Giang Văn Siêu
    /// Bài tập 03 lab 01
    /// </summary>
    class Program
    {
        static List<KhachHang> listKhachHang = new List<KhachHang>();
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
                Console.WriteLine("1. Nhap danh sach khach hang");
                Console.WriteLine("2. Xuat danh sach khach hang");
                Console.WriteLine("3. Xuat hoa don theo thang/nam nhap vao: ");
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
                        OutputDanhSach(listKhachHang);
                        break;
                    case 3:
                        Console.Write("Nhap ngay mm/yyyy can xuat hoa don: ");
                        DateTime NgayHoaDonNeedFind = Convert.ToDateTime(Console.ReadLine());
                        List<KhachHang> result = FindKhachHangByNgayHoaDon(NgayHoaDonNeedFind);
                        Console.WriteLine("Danh sach hoa don: " + NgayHoaDonNeedFind);
                        OutputDanhSach(result);
                        break;
                    default:
                        Console.WriteLine("Chuc nang ban chon khong co. Vui long chon lai!");
                        break;
                }
            } while (chon != 0);
        }
        private static void InputDanhSach()
        {
            int chon;
            KhachHang KH;
            do
            {
                Console.WriteLine("-----Menu------");
                Console.WriteLine("1. Khach hang Viet Nam");
                Console.WriteLine("2. Khach hang nuoc ngoai");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("---------------");
                Console.Write("Vui long chon:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        KH = new KhachHangVN();
                        KH.Input();
                        listKhachHang.Add(KH);
                        break;
                    case 2:
                        KH = new KhachHangNuocNgoai();
                        KH.Input();
                        listKhachHang.Add(KH);
                        break;
                    default:
                        Console.WriteLine("Chi co 2 loai khach hang. Vui long chon lai!");
                        break;
                }
            } while (chon != 0);
        }
        public static void OutputDanhSach(List<KhachHang> listInput)
        {
            foreach (var item in listInput)
            {
                item.Output();
            }
        }
        public static List<KhachHang> FindKhachHangByNgayHoaDon(DateTime dateTimeHoaDon)
        {
            return listKhachHang.Where(kh => kh.NgayHoaDon == dateTimeHoaDon).ToList();
        }
    }
}
