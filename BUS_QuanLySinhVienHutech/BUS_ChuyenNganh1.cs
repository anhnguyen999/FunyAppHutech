using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;

public class BUS_QuanLySinhVienHutech
{
    DAL_ChuyenNganh dataChuyenNganh = new DAL_ChuyenNganh();
    public class BUS_ChuyenNganh1
    {

    }
    public List<ChuyenNganh> GetAll()
    {
        return dataChuyenNganh.GetAll();
    }
}
