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

namespace GUI_QuanLySinhVien
{
    public partial class frmDangKyMonHoc : Form
    {
        BUS_ChuyenNganh busChuyenNganh = new BUS_ChuyenNganh();
        BUS_MonHoc busMonHoc = new BUS_MonHoc()
        BUS_MonHoc busDangKyMonHoc = new BUS_DangKyMonHoc();
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
            DataGridViewRow row = (DataGridViewRow)dgvDanhSachDangKy.Rows[0].Clone();
            var listDangky = busDangKyMonHoc.GetAll();
            foreach (var item in listDangky)
            {
                row.Cells[0].Value = item.MasSV;
                row.Cells[1].Value = item.HoTen;
                row.Cells[2].Value = item.TenChuyenNganh;
                row.Cells[3].Value = item.GioiTinh;
                dgvDanhSachDangKy.Rows
            }
        }

        private void LoadMonHocTheoChuyenNganh(int maChuyenNganh)
        {
            lstDanhSachMonHocChuaChon.Items.Clear();
            var listMonHoc = busMonHoc.GetByMaChuyenNganh(maChuyenNganh);
            foreach (var item in listMonHoc)
            {
                if (!lstDanhSachMonHocDaChon.Items.Contains(item))
                {
                    lstDanhSachMonHocChuaChon.Items.Add(item);
                }
                
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lstDanhSachMonHocChuaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lOng CHon Mon Hoc Da Dang Ky");
                return;
            }
            var item = lstDanhSachMonHocChuaChon.SelectedItem;
            lstDanhSachMonHocDaChon.Items.Add(item);
            lstDanhSachMonHocDaChon.Items.Remove(item);
        }

        private void cbxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maChuyenNganh = (cbxChuyenNganh.SelectedItem as ChuyenNganh).MaChuyenNganh;
            LoadMonHocTheoChuyenNganh(maChuyenNganh);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSachMonHocDaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lOng CHon Mon Hoc Da Huy");
                return;
            }
            var item = lstDanhSachMonHocDaChon.SelectedItem;
            lstDanhSachMonHocDaChon.Items.Remove(item);
            lstDanhSachMonHocDaChon.Items.Add(item);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
