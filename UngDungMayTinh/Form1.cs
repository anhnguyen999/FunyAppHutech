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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //chuyển sender về nút button
            Button btnPhepTinh = (Button)sender;
            //xác định phép tính được chọn dựa theo tên của sender
            string phepTinh = btnPhepTinh.Name;
            //lấy giá trị nhập
            float soA = float.Parse(txtSoa.Text);
            float soB = float.Parse(txtSob.Text);
            float KQ = 0;
            //Thực hiện phep tính bằng cấu trúc lựa chọn
            switch (phepTinh)
            {
                case "btnPhepCong":
                    KQ = soA + soB;
                    break;
                case "btnPhepTru":
                    KQ = soA - soB;
                    break;
                case "btnPhepNhan":
                    KQ = soA * soB;
                    break;
                case "btnPhepChia":
                    KQ = soA / soB;
                    break;

                default:
                    break;
            }
            //đưa kết quả ra
            txtKetqua.Text = KQ.ToString();
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //buoc 1 : chuyển sender thành textbox
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