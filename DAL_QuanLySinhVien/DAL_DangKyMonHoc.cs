using DTO_QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLySinhVien
{
    public class DAL_DangKyMonHoc
    {
        QuanLySinhVienHutechEntities dbContext = new QuanLySinhVienHutechEntities();

        public List<DTO_DangKyMonHoc> GetAll()
        {
            var listDangKyMonHoc = (from dkmh in dbContext.DangKyMonHocs
                                    select new DTO_DangKyMonHoc
                                    {
                                        MaSV = dkmh.MaSinhVien,
                                        GioiTinh = dkmh.SinhVien.GioiTinh == true ? "Nam" : "Nữ",
                                        HoTen = dkmh.SinhVien.HoTen,
                                        TenChuyenNganh = dkmh.MonHoc.ChuyenNganh.TenChuyenNganh
                                    }).ToList();

            return listDangKyMonHoc;
        }
    }
}
