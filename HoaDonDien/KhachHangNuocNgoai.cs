using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    class KhachHangNuocNgoai : KhachHang
    {
        public string QuocTich { get; set; }
        public override double DinhMuc { get; set; }

        public override double ThanhTien()
        {
            return SoLuongKW * DonGia;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Quoc tich: ");
            QuocTich = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Quoc tich: " + QuocTich);
            Console.WriteLine("Thanh tien: " + ThanhTien());
        }
    }

}
