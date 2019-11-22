using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    class KhachHangVN : KhachHang
    {
        public String DoiTuongKhachHang { get; set; }
        public double DinhMuc { get; set; }

        public KhachHangVN()
        {

        }
        public override double ThanhTien()
        {
            if (SoLuongKW <= DinhMuc)
            {
                return SoLuongKW * DonGia;
            }
            else
            {
                return SoLuongKW * DonGia * DinhMuc + ((SoLuongKW - DinhMuc) * DonGia * 2.5);
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Doi tuong khach hang: \n");
            int chon;
            do
            {
                menu();
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        DoiTuongKhachHang = "Sinh hoat";
                        break;
                    case 2:
                        DoiTuongKhachHang = "Kinh doanh";
                        break;
                    case 3:
                        DoiTuongKhachHang = "San xuat";
                        break;
                    default:
                        Console.WriteLine("Hay chon dung!");
                        break;
                }
            } while (chon == 0);
            Console.Write("Dinh muc: ");
            DinhMuc = Convert.ToDouble(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Doi tuong khach hang: " + DoiTuongKhachHang);
            Console.WriteLine("Dinh muc:" + DinhMuc);
            Console.WriteLine("Thanh tien: " + ThanhTien());
        }
        public void menu()
        {
            Console.WriteLine("1. Sinh hoat");
            Console.WriteLine("2. Kinh doanh");
            Console.WriteLine("3. San xuat");
            Console.Write("Chon loai doi tuong KH: ");
        }
    }
}