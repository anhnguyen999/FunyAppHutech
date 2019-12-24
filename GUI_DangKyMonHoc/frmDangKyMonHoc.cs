using System;
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

namespace GUI_DangKyMonHoc
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
            cbmChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbmChuyenNganh.ValueMember = "MaChuyenNganh";
            lstMonHoc.DisplayMember = "TenMonHoc";
            lstMonHocChon.DisplayMember = "TenMonHoc";
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            cbmChuyenNganh.DataSource = busChuyenNganh.GetAll();
            LoadDanhSachDangKy();
        }

        private void LoadDanhSachDangKy()
        {
            //dua danh sach vao datagridview
            DataGridViewRow row = (DataGridViewRow)dgvDanhSachDangKy.Rows[0].Clone();
            var listDangKy = busDangKyMonHoc.GetAll();
            foreach (var item in listDangKy)
            {
                row.Cells[0].Value = item.MaSV;
                row.Cells[1].Value = item.HoTen;
                row.Cells[2].Value = item.TenChuyenNganh;
                row.Cells[3].Value = item.GioiTinh;
                dgvDanhSachDangKy.Rows.Add(row);
            }
        }

        private void cbmChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maChuyenNganh = (cbmChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;
            LoadMonHocTheoChuyenNganh(maChuyenNganh);
        }

        private void LoadMonHocTheoChuyenNganh(int maChuyenNganh)
        {
            lstMonHoc.Items.Clear();
            var listMonHoc = busMonHoc.GetByMaChuyenNganh(maChuyenNganh);
            foreach (var item in listMonHoc)
            {
                if (lstMonHocChon.Items.Contains(item))               
                    continue;                
                lstMonHoc.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lstMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon mon hoc de dang ky");
                return;
            }
            var item = lstMonHoc.SelectedItem;
            lstMonHocChon.Items.Add(item);
            lstMonHoc.Items.Remove(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMonHocChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon mon hoc de huy");
                return;
            }
            var item = lstMonHocChon.SelectedItem;
            lstMonHocChon.Items.Remove(item);
            lstMonHoc.Items.Add(item);
        }
    }
}
