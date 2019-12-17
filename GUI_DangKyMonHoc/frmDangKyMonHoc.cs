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

namespace GUI_DangKyMonHoc
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
            cbmChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbmChuyenNganh.ValueMember = "MaChuyenNganh";
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            cbmChuyenNganh.DataSource = busChuyenNganh.GetAll();
        }
    }
}
