using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ;

namespace GUI_QuanLySinhVien
{
    public partial class FrmDangKiMonHoc : Form
    {
        BUS_ChuyenNganh
        public FrmDangKiMonHoc()
        {
            InitializeComponent();
            Controlconfi();
            this.Load += FrmDangKiMonHoc_Load1; 
        }

        private void Controlconfi()
        {
            cbxChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbxChuyenNganh.ValueMember = "MaChuyenNganh";
        }

        private void FrmDangKiMonHoc_Load1(object sender, EventArgs e)
        {
           cbxChuyenNganh.DataSource = 
        }

    
    }
}
