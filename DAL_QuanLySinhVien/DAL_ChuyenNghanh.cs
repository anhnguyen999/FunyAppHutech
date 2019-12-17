using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QuanLySinhVien
{
    public class DAL_ChuyenNghanh
    {
        QuanLySinhVienHUTECHEntities dbContext = new QuanLySinhVienHUTECHEntities();
        //CRUD
        public List<ChuyenNganh> GetAll()
        {
            return dbContext.ChuyenNganhs.ToList();
        }
    }
}
