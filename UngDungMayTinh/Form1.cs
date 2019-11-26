using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            //chuyen sender ve button
            Button btnPhepTinh = (Button)sender;
            //xac dinh phep tinh duoc chon dua theo ten cua sender
            string phepTinh = btnPhepTinh.Name;
            //lay gia tri nhap
            float soA = float.Parse(txtSoA.Text);
            float soB = float.Parse(txtSoB.Text);
            float ketQua = 0;
            // thuc hein phep tinh bang cau truc lua chon
            switch (phepTinh)
            {
                case "btnPhepCong":
                    ketQua = soA + soB;
                    break;
                case "btnPhepTru":
                    ketQua = soA - soB;
                    break;
                case "btnPhepNhan":
                    ketQua = soA * soB;
                    break;
                case "btnPhepChia":
                    ketQua = soA / soB;
                    break;
                default:
                    break;

            }
            txtKetQua.Text = ketQua.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //buoc 1: chuyen sender thanh textbox
            TextBox txtNumber = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
                errorProvider.SetError(txtNumber, "Không được nhập chữ hoặc khoảng trắng");
            }
            else
            {
                errorProvider.SetError(txtNumber, null);
            }
        }
    }
}
