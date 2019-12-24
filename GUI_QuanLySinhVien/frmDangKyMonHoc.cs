﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLySinhVien;
using DAL_QuanLySinhVien;

namespace GUI_QuanLySinhVien
{
    public partial class frmDangKyMonHoc : Form
    {
        BUS_ChuyenNganh busChuyenNganh = new BUS_ChuyenNganh();
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        BUS_DangKyMonHoc busDangKyMonHoc = new BUS_DangKyMonHoc();

        public frmDangKyMonHoc()
        {
            InitializeComponent();
            ControlConfig();
            this.Load += frmDangKyMonHoc_Load;
        }

        private void ControlConfig()
        {
            cbxChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbxChuyenNganh.ValueMember = "MaChuyenNganh";
            lstDanhSachMonHocChuaChon.DisplayMember = "TenMonHoc";
            lstDanhSachMonHocDaChon.DisplayMember = "TenMonHoc";
            
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            cbxChuyenNganh.DataSource = busChuyenNganh.GetAll();
            LoadDanhSachDangKy();
        }

        private void LoadDanhSachDangKy()
        {
            //dua danh sach vao data
            DataGridViewRow row = (DataGridViewRow)dgvDanhSachDangKy.Rows[0].Clone();
            var listDangKy = busDangKyMonHoc.GetAll();
            foreach(var item in listDangKy)
            {
                row.Cells[0].Value = item.MaSV;
                row.Cells[1].Value = item.HoTen;
                row.Cells[2].Value = item.TenChuyenNganh;
                row.Cells[3].Value = item.GioiTinh;
                dgvDanhSachDangKy.Rows.Add(row);
            }
        }

        private void lstDanhSachMonHocChuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maChuyenNganh = (cbxChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;
            LoadMonHocTheoChuyenNganh(maChuyenNganh);
        }

        private void LoadMonHocTheoChuyenNganh(int maChuyenNganh)
        {
            lstDanhSachMonHocChuaChon.Items.Clear();
            var listMonHoc = busMonHoc.GetByMaChuyenNganh(maChuyenNganh);
            foreach(var item in listMonHoc)
            {
                if (lstDanhSachMonHocDaChon.Items.Contains(item))
                    lstDanhSachMonHocChuaChon.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstDanhSachMonHocDaChon)
        }
    }
}
