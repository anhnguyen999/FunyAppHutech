namespace GUI_DangKyMonHoc
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
            this.dgvDanhSachDangKy = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.lstMonHocChon = new System.Windows.Forms.ListBox();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.cbmChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachDangKy
            // 
            this.dgvDanhSachDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colName,
            this.colFaculty,
            this.colGioiTinh,
            this.colSoMon});
            this.dgvDanhSachDangKy.Location = new System.Drawing.Point(12, 389);
            this.dgvDanhSachDangKy.Name = "dgvDanhSachDangKy";
            this.dgvDanhSachDangKy.RowHeadersWidth = 51;
            this.dgvDanhSachDangKy.RowTemplate.Height = 24;
            this.dgvDanhSachDangKy.Size = new System.Drawing.Size(1082, 210);
            this.dgvDanhSachDangKy.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chkNu);
            this.groupBox1.Controls.Add(this.chkNam);
            this.groupBox1.Controls.Add(this.lstMonHocChon);
            this.groupBox1.Controls.Add(this.lstMonHoc);
            this.groupBox1.Controls.Add(this.cbmChuyenNganh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa chọn";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu Thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(478, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(48, 38);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(478, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(497, 172);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(48, 21);
            this.chkNu.TabIndex = 15;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNam.Location = new System.Drawing.Point(390, 172);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(59, 21);
            this.chkNam.TabIndex = 16;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // lstMonHocChon
            // 
            this.lstMonHocChon.FormattingEnabled = true;
            this.lstMonHocChon.ItemHeight = 16;
            this.lstMonHocChon.Location = new System.Drawing.Point(572, 233);
            this.lstMonHocChon.Name = "lstMonHocChon";
            this.lstMonHocChon.Size = new System.Drawing.Size(257, 84);
            this.lstMonHocChon.TabIndex = 13;
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.FormattingEnabled = true;
            this.lstMonHoc.ItemHeight = 16;
            this.lstMonHoc.Location = new System.Drawing.Point(215, 233);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.Size = new System.Drawing.Size(220, 84);
            this.lstMonHoc.TabIndex = 14;
            // 
            // cbmChuyenNganh
            // 
            this.cbmChuyenNganh.FormattingEnabled = true;
            this.cbmChuyenNganh.Location = new System.Drawing.Point(345, 120);
            this.cbmChuyenNganh.Name = "cbmChuyenNganh";
            this.cbmChuyenNganh.Size = new System.Drawing.Size(289, 24);
            this.cbmChuyenNganh.TabIndex = 12;
            this.cbmChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cbmChuyenNganh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn các môn học tham gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(345, 43);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(181, 22);
            this.txtMSSV.TabIndex = 6;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ Và Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Chuyên Ngành";
            this.colFaculty.MinimumWidth = 6;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 125;
            // 
            // colSoMon
            // 
            this.colSoMon.HeaderText = "Số Môn";
            this.colSoMon.MinimumWidth = 6;
            this.colSoMon.Name = "colSoMon";
            this.colSoMon.Width = 125;
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDanhSachDangKy);
            this.Name = "frmDangKyMonHoc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDangKy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachDangKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.ListBox lstMonHocChon;
        private System.Windows.Forms.ListBox lstMonHoc;
        private System.Windows.Forms.ComboBox cbmChuyenNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoMon;
    }
}

