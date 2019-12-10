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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //chuyen sender về button
            Button btnPhepTinh = (Button)sender;
            //xác định phép tính được chọn dựa theo tên của sender
            string phepTinh = btnPhepTinh.Name;
            //lấy giá trị nhập
            float soA = float.Parse(txtSoA.Text);
            float soB = float.Parse(txtSoB.Text);
            float ketQua = 0;
            //thực hiện phép tính bằng cấu trúc lựa chọn
            switch (phepTinh)
            {
                case "btnphepcong":
                    ketQua = soA + soB;
                    break;
                case "btnpheptru":
                    ketQua = soA - soB;
                    break;
                case "btnphepnhan":
                    ketQua = soA * soB;
                    break;
                case "btnphepchia":
                    ketQua = soA / soB;
                    break;
                default:
                    break;
            }
            txtKQ.Text = ketQua.ToString();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bước 1: Chuyển sender thành textbox
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
