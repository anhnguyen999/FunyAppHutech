using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLySinhVien
{
    public class DAL_DangKyMonHoc
    {
        QuanLySinhVienHutechEntities dbContext = new QuanLySinhVienHutechEntities();
        //CRUD
        public List<DAL_DangKyMonHoc> GetAll()
        {
            var listDangKyMonHoc = (from DangKyMonHoc in DbContext.DangKyMonHocs select new
                DTO_DangKyMonHoc {
                MaSV = DangKyMonHoc.MaSinhVien,
                HoTen = DangKyMonHoc.SinhVien.HoTen,
                GioiTinh = DangKyMonHoc.SinhVien.GioiTinh == true ? "Nam" : "NU" }).ToList();

        }
    }
}
