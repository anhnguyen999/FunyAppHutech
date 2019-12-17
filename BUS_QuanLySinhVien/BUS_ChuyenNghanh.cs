using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_ChuyenNghanh
    {
        DAL_ChuyenNghanh dataChuyenNghanh = new DAL_ChuyenNghanh();
        public BUS_ChuyenNghanh()
        {

        }
        public List<ChuyenNganh> GetAll()
        {
            return dataChuyenNghanh.GetAll();
        }
    }
}
