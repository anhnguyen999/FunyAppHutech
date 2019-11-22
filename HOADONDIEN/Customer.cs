using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonDien
{
    abstract class Customer
    {
        public int CustomerID { get; set; }
        public String FullName { get; set; }
        public DateTime BillDate { get; set; }
        public int KWamount { get; set; }
        public double Price { get; set; }

        public abstract double Money();
        public virtual void Input()
        {
            Console.Write("Customer ID: ");
            this.CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer Name: ");
            this.FullName = Console.ReadLine();
            Console.Write("Bill Date: ");
            this.BillDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("KW amount: ");
            this.KWamount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            this.Price = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name: " + FullName);
            Console.WriteLine("Bill Date: " + BillDate);
            Console.WriteLine("KW amount: " + KWamount);
            Console.WriteLine("Price: " + Price);
        }
    }
}
