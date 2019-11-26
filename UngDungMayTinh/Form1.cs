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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyen sender về nút button
            Button btnPhepTinh = (Button)sender;
            //Xac dinh phep tinh duoc chon dua theo ten cua sender
            string phepTinh = btnPhepTinh.Name;
            //Lay gia tri nhap
            float soA = float.Parse(txtSoA.Text);
            float soB = float.Parse(txtSoB.Text);
            float ketQua = 0;
            //Thuc hien phep tinh bàng cau truc lua chon
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
            txtKQ.Text = ketQua.ToString();
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Buoc 1: Chuyen sender thanh textbox
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
