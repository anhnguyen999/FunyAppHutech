namespace UngDungMayTinh
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.btnPhepCong = new System.Windows.Forms.Button();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnPhepTru = new System.Windows.Forms.Button();
            this.btnPhepNhan = new System.Windows.Forms.Button();
            this.btnPhepChia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng Dụng Máy Tính";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(479, 205);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(443, 26);
            this.txtSoA.TabIndex = 1;
            // 
            // btnPhepCong
            // 
            this.btnPhepCong.Location = new System.Drawing.Point(536, 300);
            this.btnPhepCong.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPhepCong.Name = "btnPhepCong";
            this.btnPhepCong.Size = new System.Drawing.Size(43, 42);
            this.btnPhepCong.TabIndex = 4;
            this.btnPhepCong.Text = "+";
            this.btnPhepCong.UseVisualStyleBackColor = true;
            this.btnPhepCong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(479, 264);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(443, 26);
            this.txtSoB.TabIndex = 2;
            // 
            // btnPhepTru
            // 
            this.btnPhepTru.Location = new System.Drawing.Point(613, 300);
            this.btnPhepTru.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPhepTru.Name = "btnPhepTru";
            this.btnPhepTru.Size = new System.Drawing.Size(44, 42);
            this.btnPhepTru.TabIndex = 4;
            this.btnPhepTru.Text = "-";
            this.btnPhepTru.UseVisualStyleBackColor = true;
            this.btnPhepTru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepNhan
            // 
            this.btnPhepNhan.Location = new System.Drawing.Point(687, 300);
            this.btnPhepNhan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPhepNhan.Name = "btnPhepNhan";
            this.btnPhepNhan.Size = new System.Drawing.Size(45, 42);
            this.btnPhepNhan.TabIndex = 4;
            this.btnPhepNhan.Text = "*";
            this.btnPhepNhan.UseVisualStyleBackColor = true;
            this.btnPhepNhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepChia
            // 
            this.btnPhepChia.Location = new System.Drawing.Point(768, 300);
            this.btnPhepChia.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPhepChia.Name = "btnPhepChia";
            this.btnPhepChia.Size = new System.Drawing.Size(45, 42);
            this.btnPhepChia.TabIndex = 4;
            this.btnPhepChia.Text = "/";
            this.btnPhepChia.UseVisualStyleBackColor = true;
            this.btnPhepChia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "KQ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(479, 372);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(443, 26);
            this.txtKetQua.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số B";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1040, 504);
            this.Controls.Add(this.btnPhepChia);
            this.Controls.Add(this.btnPhepNhan);
            this.Controls.Add(this.btnPhepTru);
            this.Controls.Add(this.btnPhepCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "UngDungMayTinh";
            this.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button btnPhepCong;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnPhepTru;
        private System.Windows.Forms.Button btnPhepNhan;
        private System.Windows.Forms.Button btnPhepChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

