using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoa_don_tien_dien
{
    abstract class KhachHang
    {
        public int IDKhachHang { get; set; }
        public String TenKhachHang { get; set; }
        public DateTime NgayHoaDon { get; set; }
        public int SoLuongKW { get; set; }
        public double DonGia { get; set; }

        public abstract double ThanhTien();
        public virtual void Input()
        {
            Console.Write("ID Khach Hang: ");
            this.IDKhachHang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ten Khach Hang: ");
            this.TenKhachHang = Console.ReadLine();
            Console.Write("Ngay Hoa Don: ");
            this.NgayHoaDon = Convert.ToDateTime(Console.ReadLine());
            Console.Write("So Luong KW dien: ");
            this.SoLuongKW = Convert.ToInt32(Console.ReadLine());
            Console.Write("Don gia: ");
            this.DonGia = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine("ID Khach Hang: " + IDKhachHang);
            Console.WriteLine("Ten Khach Hang: " + TenKhachHang);
            Console.WriteLine("Ngay Hoa Don: " + NgayHoaDon);
            Console.WriteLine("So Luong KW dien: " + SoLuongKW);
            Console.WriteLine("Don gia: " + DonGia);
        }
    }
}
