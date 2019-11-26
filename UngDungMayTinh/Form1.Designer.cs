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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.btnPhepCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnPhepTru = new System.Windows.Forms.Button();
            this.btnPhepNhan = new System.Windows.Forms.Button();
            this.btnPhepChia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ỨNG DỤNG MÁY TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(173, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "SỐ A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(290, 98);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(283, 22);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnPhepCong
            // 
            this.btnPhepCong.Location = new System.Drawing.Point(316, 185);
            this.btnPhepCong.Name = "btnPhepCong";
            this.btnPhepCong.Size = new System.Drawing.Size(63, 40);
            this.btnPhepCong.TabIndex = 3;
            this.btnPhepCong.Text = "+";
            this.btnPhepCong.UseVisualStyleBackColor = true;
            this.btnPhepCong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(173, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "SỐ B";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(290, 146);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(283, 22);
            this.txtSoB.TabIndex = 3;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnPhepTru
            // 
            this.btnPhepTru.Location = new System.Drawing.Point(385, 185);
            this.btnPhepTru.Name = "btnPhepTru";
            this.btnPhepTru.Size = new System.Drawing.Size(61, 40);
            this.btnPhepTru.TabIndex = 3;
            this.btnPhepTru.Text = "-";
            this.btnPhepTru.UseVisualStyleBackColor = true;
            this.btnPhepTru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepNhan
            // 
            this.btnPhepNhan.Location = new System.Drawing.Point(452, 185);
            this.btnPhepNhan.Name = "btnPhepNhan";
            this.btnPhepNhan.Size = new System.Drawing.Size(58, 40);
            this.btnPhepNhan.TabIndex = 3;
            this.btnPhepNhan.Text = "*";
            this.btnPhepNhan.UseVisualStyleBackColor = true;
            this.btnPhepNhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepChia
            // 
            this.btnPhepChia.Location = new System.Drawing.Point(516, 185);
            this.btnPhepChia.Name = "btnPhepChia";
            this.btnPhepChia.Size = new System.Drawing.Size(57, 40);
            this.btnPhepChia.TabIndex = 3;
            this.btnPhepChia.Text = "/";
            this.btnPhepChia.UseVisualStyleBackColor = true;
            this.btnPhepChia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(173, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "KQ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(290, 245);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(283, 22);
            this.txtKetQua.TabIndex = 4;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhepChia);
            this.Controls.Add(this.btnPhepNhan);
            this.Controls.Add(this.btnPhepTru);
            this.Controls.Add(this.btnPhepCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button btnPhepCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnPhepTru;
        private System.Windows.Forms.Button btnPhepNhan;
        private System.Windows.Forms.Button btnPhepChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

