﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_DangkyMonHoc
    {
        DAL_DangKyMonHoc dalDangkyMonHoc = new DAL_DangKyMonHoc();

        public BUS_DangkyMonHoc()
        {

        }

        public List<DAL_DangKyMonHoc> GetAll()
        {
            return DAL_ChuyenNganh.GetAll();
        }
    }
}
