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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //Chuyen sender về button
            Button btnPhepTinh = (Button)sender;
            //Xác dinh phép tính được chọn dựa theo tên của sender
            string phepTinh = btnPhepTinh.Name;
            //Lấy giá trị nhập
            float SoA = float.Parse(txtSoA.Text);
            float SoB = float.Parse(txtSoB.Text);
            float ketQua = 0;
            //Thực hiện phép tính bằng cấu trúc lựa chọn
            switch (phepTinh)
            {
                case "btnPhepCong":
                    ketQua = SoA + SoB;
                    break;
                case "btnPhepTru":
                    ketQua = SoA - SoB;
                    break;
                case "btnPhepNhan":
                    ketQua = SoA * SoB;
                    break;
                case "btnPhepChia":
                    ketQua = SoA / SoB;
                    break;
                default:
                    break;
            }
            txtKetQua.Text = ketQua.ToString();
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bước 1: Chuyển sender thành textbox
            TextBox txtNumber = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))) { e.Handled = true; errorProvider.SetError(txtNumber, "Không được nhập chữ hoặc khoảng trắng"); } else { errorProvider.SetError(txtNumber, null); }
        }
    }
}
