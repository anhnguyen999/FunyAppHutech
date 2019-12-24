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

namespace GUI_QuanLySinhVien
{
    public partial class frmDangKyMonHoc : Form
    {
        BUS_ChuyenNghanh busChuyenNghanh = new BUS_ChuyenNghanh();
        public frmDangKyMonHoc()
        {
            InitializeComponent();
            ControlConfig();
            this.Load += frmDangKyMonHoc_Load;

        }

        private void ControlConfig()
        {
            cbxChuyenNghanh.DisplayMember = "TenChuyenNghanh";
            cbxChuyenNghanh.ValueMember = "MaChuyenNghanh";
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {

            cbxChuyenNghanh.DataSource = busChuyenNghanh.GetAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
