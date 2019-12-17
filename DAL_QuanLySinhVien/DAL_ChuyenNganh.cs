using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QuanLySinhVien
{
    public class DAL_ChuyenNganh
    {
        QuanLySinhVienHutechEntities dbContext = new QuanLySinhVienHutechEntities();
        public List<ChuyenNganh> GetAll()
        {
            return dbContext.ChuyenNganhs.ToList();
        }
    }
}
