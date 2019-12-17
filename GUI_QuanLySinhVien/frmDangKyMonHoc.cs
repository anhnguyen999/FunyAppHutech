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
        BUS_ChuyenNganh busChuyenNganh = new BUS_ChuyenNganh();
        public frmDangKyMonHoc()
        {
            InitializeComponent();
            ControlConfig();


            this.Load += frmDangKyMonHoc_Load;
        }

        private void ControlConfig()
        {
            cmbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cmbChuyenNganh.ValueMember = "MaChuyenNganh";
         
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            cmbChuyenNganh.DataSource = busChuyenNganh.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
