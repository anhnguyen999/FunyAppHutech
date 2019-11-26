using System;
using System.Windows.Forms;

namespace UngDungMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            //chuyển sender thành button
            Button btnPhepTinh = (Button)sender;
            //Xac dinh phep tinh dc chon dụa theo ten cua sender
            string phepTinh = btnPhepTinh.Name;
            //lay gia tri nhap
            float soA = float.Parse(txtSoA.Text);
            float soB = float.Parse(txtSoB.Text);
            float ketQua = 0;

            // thuc hien phep tinh = cau truc lua chon
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

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chuyen sender thanh textbox
            TextBox txtNumber = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.') || ((e.KeyChar == '.') &&
              ((sender as TextBox).Text.IndexOf('.') > -1)))
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
