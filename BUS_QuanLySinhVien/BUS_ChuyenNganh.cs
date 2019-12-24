using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_ChuyenNganh
    {
        DAL_ChuyenNganh dataChuyenNganh = new DAL_ChuyenNganh();

        public BUS_ChuyenNganh()
        {

        }

        public List<ChuyenNganh> GetAll()
        {
            return dataChuyenNganh.GetAll();
        }
    }
}
