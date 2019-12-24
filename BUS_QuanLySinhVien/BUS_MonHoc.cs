using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_MonHoc
    {
        DAL_MonHoc dalMonHoc = new DAL_MonHoc();

        public BUS_MonHoc()
        {

        }

        public List<MonHoc> GetByMaChuyenNganh(int maChuyenNganh)
        {
            return dalMonHoc.GetByMaChuyenNganh(maChuyenNganh);
        }
    }
}
