﻿using System;
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
        private string messageError;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPhepTinh_Click(object sender, EventArgs e)
        {
            if(!ValidateInputNumber(out float soA, out float soB))
            {
                MessageBox.Show(messageError, "thong bao ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Chuyển sender về button
            Button btnPhepTinh = (Button)sender;
            //Xac dinh phep tinh duoc chon dua theo tên của sender
            string phepTinh = btnPhepTinh.Name;
            //lấy giá trị nhập
            float ketQua = 0;
            //Thuc hien phép tính bằng cấu trúc lựa chọn
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


        private bool ValidateInputNumber(out float soA, out float soB)
        {
            messageError = "";
            if(!float.TryParse(txtSoA.Text, out soA))
            {
                messageError = "So A nhap Khong Hop Ly";
            }
            if (!float.TryParse(txtSoB.Text, out soB))
            {
                messageError += "\nSo B nhap Khong Hop Ly";
            }
            if (messageError == "")
                return true;
            return false;
                
            
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Buoc 1: Chuyển sender thành textbox
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
