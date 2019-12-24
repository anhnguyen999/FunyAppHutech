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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSV";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(330, 22);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(276, 41);
            this.txtMaSV.TabIndex = 1;
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(330, 141);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(276, 44);
            this.cbxChuyenNganh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(330, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(276, 41);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên Ngành";
            // 
            // lstDanhSachMonHocChuaChon
            // 
            this.lstDanhSachMonHocChuaChon.FormattingEnabled = true;
            this.lstDanhSachMonHocChuaChon.ItemHeight = 20;
            this.lstDanhSachMonHocChuaChon.Location = new System.Drawing.Point(78, 242);
            this.lstDanhSachMonHocChuaChon.Name = "lstDanhSachMonHocChuaChon";
            this.lstDanhSachMonHocChuaChon.Size = new System.Drawing.Size(294, 164);
            this.lstDanhSachMonHocChuaChon.TabIndex = 3;
            this.lstDanhSachMonHocChuaChon.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachMonHocChuaChon_SelectedIndexChanged);
            // 
            // lstDanhSachMonHocDaChon
            // 
            this.lstDanhSachMonHocDaChon.FormattingEnabled = true;
            this.lstDanhSachMonHocDaChon.ItemHeight = 20;
            this.lstDanhSachMonHocDaChon.Location = new System.Drawing.Point(483, 242);
            this.lstDanhSachMonHocDaChon.Name = "lstDanhSachMonHocDaChon";
            this.lstDanhSachMonHocDaChon.Size = new System.Drawing.Size(294, 164);
            this.lstDanhSachMonHocDaChon.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(389, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(389, 335);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 55);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách môn học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmasv,
            this.colhoten});
            this.dataGridView1.Location = new System.Drawing.Point(79, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(698, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // colmasv
            // 
            this.colmasv.HeaderText = "Mã SV";
            this.colmasv.MinimumWidth = 8;
            this.colmasv.Name = "colmasv";
            this.colmasv.Width = 150;
            // 
            // colhoten
            // 
            this.colhoten.HeaderText = "Họ Tên";
            this.colhoten.MinimumWidth = 8;
            this.colhoten.Name = "colhoten";
            this.colhoten.Width = 150;
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 601);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "frmDangKyMonHoc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhoten;
    }
}

