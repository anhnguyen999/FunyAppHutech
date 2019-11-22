using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    class OverseasCustomer : Customer
    {
        public String Nation { get; set; }

        public override double Money()
        {
            return KWamount * Price;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nation: ");
            Nation = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Nation: " + Nation);
            Console.WriteLine("Thanh tien: " + Money());
        }
    }

}
