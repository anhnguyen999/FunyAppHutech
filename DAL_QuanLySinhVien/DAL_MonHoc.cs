using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLySinhVien
{
    public class DAL_MonHoc
    {
        QuanLySinhVienHutechEntities dbContext = new QuanLySinhVienHutechEntities();

        public List<MonHoc> GetByMaChuyenNganh(int maChuyenNganh)
        {
            return dbContext.MonHocs.Where(mh => mh.MaChuyenNganh == maChuyenNganh).ToList();
        }
    }
}
