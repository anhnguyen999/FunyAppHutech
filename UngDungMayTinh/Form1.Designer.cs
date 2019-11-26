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
            this.btnPhepCong = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPhepTru = new System.Windows.Forms.Button();
            this.btnPhepNhan = new System.Windows.Forms.Button();
            this.btnPhepChia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(228, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng Dụng Máy Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            // 
            // btnPhepCong
            // 
            this.btnPhepCong.Location = new System.Drawing.Point(155, 175);
            this.btnPhepCong.Name = "btnPhepCong";
            this.btnPhepCong.Size = new System.Drawing.Size(78, 52);
            this.btnPhepCong.TabIndex = 2;
            this.btnPhepCong.Text = "+";
            this.btnPhepCong.UseVisualStyleBackColor = true;
            this.btnPhepCong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(155, 82);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(189, 26);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(155, 127);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(189, 26);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số B";
            // 
            // btnPhepTru
            // 
            this.btnPhepTru.Location = new System.Drawing.Point(239, 175);
            this.btnPhepTru.Name = "btnPhepTru";
            this.btnPhepTru.Size = new System.Drawing.Size(78, 52);
            this.btnPhepTru.TabIndex = 2;
            this.btnPhepTru.Text = "-";
            this.btnPhepTru.UseVisualStyleBackColor = true;
            this.btnPhepTru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepNhan
            // 
            this.btnPhepNhan.Location = new System.Drawing.Point(323, 175);
            this.btnPhepNhan.Name = "btnPhepNhan";
            this.btnPhepNhan.Size = new System.Drawing.Size(78, 52);
            this.btnPhepNhan.TabIndex = 2;
            this.btnPhepNhan.Text = "*";
            this.btnPhepNhan.UseVisualStyleBackColor = true;
            this.btnPhepNhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepChia
            // 
            this.btnPhepChia.Location = new System.Drawing.Point(407, 175);
            this.btnPhepChia.Name = "btnPhepChia";
            this.btnPhepChia.Size = new System.Drawing.Size(78, 52);
            this.btnPhepChia.TabIndex = 2;
            this.btnPhepChia.Text = "/";
            this.btnPhepChia.UseVisualStyleBackColor = true;
            this.btnPhepChia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "KQ";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(155, 250);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(246, 26);
            this.txtKQ.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnPhepChia);
            this.Controls.Add(this.btnPhepNhan);
            this.Controls.Add(this.btnPhepTru);
            this.Controls.Add(this.btnPhepCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhepCong;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPhepTru;
        private System.Windows.Forms.Button btnPhepNhan;
        private System.Windows.Forms.Button btnPhepChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

