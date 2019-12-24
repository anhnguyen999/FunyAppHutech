namespace GUI_QuanLySinhVien
{
    partial class frmDangKyMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDanhSachMonHocChuaChon = new System.Windows.Forms.ListBox();
            this.lstDanhSachMonHocDaChon = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhSachDangKy = new System.Windows.Forms.DataGridView();
            this.colMSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSV";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(293, 18);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(246, 36);
            this.txtMaSV.TabIndex = 1;
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(293, 113);
            this.cbxChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(246, 37);
            this.cbxChuyenNganh.TabIndex = 2;
            this.cbxChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cbxChuyenNganh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(293, 62);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 36);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên Ngành";
            // 
            // lstDanhSachMonHocChuaChon
            // 
            this.lstDanhSachMonHocChuaChon.FormattingEnabled = true;
            this.lstDanhSachMonHocChuaChon.ItemHeight = 16;
            this.lstDanhSachMonHocChuaChon.Location = new System.Drawing.Point(69, 194);
            this.lstDanhSachMonHocChuaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDanhSachMonHocChuaChon.Name = "lstDanhSachMonHocChuaChon";
            this.lstDanhSachMonHocChuaChon.Size = new System.Drawing.Size(262, 132);
            this.lstDanhSachMonHocChuaChon.TabIndex = 3;
            // 
            // lstDanhSachMonHocDaChon
            // 
            this.lstDanhSachMonHocDaChon.FormattingEnabled = true;
            this.lstDanhSachMonHocDaChon.ItemHeight = 16;
            this.lstDanhSachMonHocDaChon.Location = new System.Drawing.Point(429, 194);
            this.lstDanhSachMonHocDaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDanhSachMonHocDaChon.Name = "lstDanhSachMonHocDaChon";
            this.lstDanhSachMonHocDaChon.Size = new System.Drawing.Size(262, 132);
            this.lstDanhSachMonHocDaChon.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(346, 210);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(346, 268);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 44);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách môn học";
            // 
            // dgvDanhSachDangKy
            // 
            this.dgvDanhSachDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSV,
            this.colHoTen,
            this.colChuyenNganh,
            this.colGioiTinh});
            this.dgvDanhSachDangKy.Location = new System.Drawing.Point(69, 357);
            this.dgvDanhSachDangKy.Name = "dgvDanhSachDangKy";
            this.dgvDanhSachDangKy.RowHeadersWidth = 51;
            this.dgvDanhSachDangKy.RowTemplate.Height = 24;
            this.dgvDanhSachDangKy.Size = new System.Drawing.Size(622, 150);
            this.dgvDanhSachDangKy.TabIndex = 5;
            // 
            // colMSV
            // 
            this.colMSV.HeaderText = "MSV";
            this.colMSV.MinimumWidth = 6;
            this.colMSV.Name = "colMSV";
            this.colMSV.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 125;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.HeaderText = "Chuyên Ngành";
            this.colChuyenNganh.MinimumWidth = 6;
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.Width = 125;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 125;
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 530);
            this.Controls.Add(this.dgvDanhSachDangKy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lstDanhSachMonHocDaChon);
            this.Controls.Add(this.lstDanhSachMonHocChuaChon);
            this.Controls.Add(this.cbxChuyenNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangKyMonHoc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbxChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDanhSachMonHocChuaChon;
        private System.Windows.Forms.ListBox lstDanhSachMonHocDaChon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSachDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
    }
}

