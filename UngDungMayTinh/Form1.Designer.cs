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
            this.btnphepcong = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnpheptru = new System.Windows.Forms.Button();
            this.btnphepnhan = new System.Windows.Forms.Button();
            this.btnphepchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng Dụng Máy Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnphepcong
            // 
            this.btnphepcong.Location = new System.Drawing.Point(359, 182);
            this.btnphepcong.Name = "btnphepcong";
            this.btnphepcong.Size = new System.Drawing.Size(75, 23);
            this.btnphepcong.TabIndex = 2;
            this.btnphepcong.Text = "+";
            this.btnphepcong.UseVisualStyleBackColor = true;
            this.btnphepcong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(359, 85);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(257, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số B";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(359, 144);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(257, 20);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnpheptru
            // 
            this.btnpheptru.Location = new System.Drawing.Point(440, 182);
            this.btnpheptru.Name = "btnpheptru";
            this.btnpheptru.Size = new System.Drawing.Size(75, 23);
            this.btnpheptru.TabIndex = 2;
            this.btnpheptru.Text = "-";
            this.btnpheptru.UseVisualStyleBackColor = true;
            this.btnpheptru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepnhan
            // 
            this.btnphepnhan.Location = new System.Drawing.Point(521, 182);
            this.btnphepnhan.Name = "btnphepnhan";
            this.btnphepnhan.Size = new System.Drawing.Size(75, 23);
            this.btnphepnhan.TabIndex = 2;
            this.btnphepnhan.Text = "*";
            this.btnphepnhan.UseVisualStyleBackColor = true;
            this.btnphepnhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepchia
            // 
            this.btnphepchia.Location = new System.Drawing.Point(602, 182);
            this.btnphepchia.Name = "btnphepchia";
            this.btnphepchia.Size = new System.Drawing.Size(75, 23);
            this.btnphepchia.TabIndex = 2;
            this.btnphepchia.Text = "/";
            this.btnphepchia.UseVisualStyleBackColor = true;
            this.btnphepchia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "KQ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(359, 230);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(257, 20);
            this.txtKQ.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnphepchia);
            this.Controls.Add(this.btnphepnhan);
            this.Controls.Add(this.btnpheptru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnphepcong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnphepcong;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnpheptru;
        private System.Windows.Forms.Button btnphepnhan;
        private System.Windows.Forms.Button btnphepchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

