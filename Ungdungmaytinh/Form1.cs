using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ungdungmaytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyển sender thành Button
            Button btnPhepTinh = (Button)sender;
            //xac dinh phep tinh duoc chon dua theo ten sender
            string pheptinh = btnPhepTinh.Name;
            float soA = float.Parse(txtsoA.Text);
            float soB = float.Parse(txtsoB.Text);
            float ketQua = 0;
            //Thuc hien phep chia tinh bang cau truc lua chon
            switch (pheptinh)
            {
                case "btnphepcong":
                    ketQua = soA + soB; break;
                case "btnpheptru":
                    ketQua = soA - soB; break;
                case "btnphepchia":
                    ketQua = soA / soB; break;
                case "btnphepnhan":

                    ketQua = soA * soB; break;



                default:
                    break;
            }
            txtketQua.Text = ketQua.ToString();

        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
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
