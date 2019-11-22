using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    /// <summary>
    /// Nhóm THC - Nguyễn Công Quốc - Vũ Văn Thời - Ngô Tuấn Trung
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
                Console.WriteLine("1. Nhap danh sach khach hang.");
                Console.WriteLine("2. Xuat danh sach khach hang.");
                Console.WriteLine("3. Xuat hoa don theo thang/nam nhap vao.");
                Console.WriteLine("4. Tong KW vuot dinh muc cua khach hang Viet Nam.");
                Console.WriteLine("5. Xuat tong tien hoa don cua ma khach hang x.");
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
                        Console.WriteLine("Danh sach hoa don: " + NgayHoaDonNeedFind.Month + "/"
                            + NgayHoaDonNeedFind.Year + "\n");
                        OutputDanhSach(result);
                        break;
                    case 4:
                        Console.WriteLine("\nTong KW dien vuot dinh muc o Viet Nam: " + TinhTongKWVuotDinhMucVN() + "\n");
                        break;
                    case 5:
                        Console.Write("Nhap ID khach hang can tim: ");
                        int IDKhachHangNeedFind = Convert.ToInt32(Console.ReadLine());
                        List<KhachHang> result1 = FindKhachHangByID(IDKhachHangNeedFind);
                        Console.Write("\nTong cua tien Khach hang co id " + IDKhachHangNeedFind + ": ");
                        Console.WriteLine(XuatTongThanhTienByID(result1) + "\n");
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
                Console.Write("\n");
            }
        }
        public static List<KhachHang> FindKhachHangByNgayHoaDon(DateTime dateTimeHoaDon)
        {
            return listKhachHang.Where(kh => kh.NgayHoaDon.Month == dateTimeHoaDon.Month && kh.NgayHoaDon.Year == dateTimeHoaDon.Year).ToList();
        }
        public static List<KhachHang> FindKhachHangByID(int idKhachHang)
        {
            return listKhachHang.Where(kh => kh.IDKhachHang == idKhachHang).ToList();
        }
        public static double TinhTongKWVuotDinhMucVN()
        {
            double result = 0.0;
            foreach (var item in listKhachHang)
            {
                if(item is KhachHangVN)
                {
                    result = result + (item.SoLuongKW - item.DinhMuc);
                }
            }
            return result;
        }
        public static double XuatTongThanhTienByID(List<KhachHang> listInput)
        {
            double result = 0.0;
            foreach (var item in listInput)
            {
                    result = result + item.ThanhTien();
            }
            return result;
        }
    }
}
