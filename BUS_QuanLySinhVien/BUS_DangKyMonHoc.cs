﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLySinhVien;
using DTO_QuanLySinhVien;

namespace BUS_QuanLySinhVien
{
    public class BUS_DangKyMonHoc
    {
        DAL_DangKyMonHoc dalDangKyMonHoc = new DAL_DangKyMonHoc();

        public BUS_DangKyMonHoc()
        {

        }

        public List<DTO_DangKyMonHoc> GetAll()
        {
            return dalDangKyMonHoc.GetAll();
        }
    }
}