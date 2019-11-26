namespace ungdungmaytinh
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
            this.btnPhepcong = new System.Windows.Forms.Button();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.btnPheptru = new System.Windows.Forms.Button();
            this.btnPhepNhan = new System.Windows.Forms.Button();
            this.btnPhepchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng Dụng Máy Tính";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            // 
            // btnPhepcong
            // 
            this.btnPhepcong.Location = new System.Drawing.Point(282, 219);
            this.btnPhepcong.Name = "btnPhepcong";
            this.btnPhepcong.Size = new System.Drawing.Size(67, 62);
            this.btnPhepcong.TabIndex = 2;
            this.btnPhepcong.Text = "+";
            this.btnPhepcong.UseVisualStyleBackColor = true;
            this.btnPhepcong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoa.Location = new System.Drawing.Point(260, 117);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(335, 36);
            this.txtSoa.TabIndex = 1;
            this.txtSoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSob.Location = new System.Drawing.Point(260, 168);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(335, 36);
            this.txtSob.TabIndex = 2;
            this.txtSob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnPheptru
            // 
            this.btnPheptru.Location = new System.Drawing.Point(355, 219);
            this.btnPheptru.Name = "btnPheptru";
            this.btnPheptru.Size = new System.Drawing.Size(61, 62);
            this.btnPheptru.TabIndex = 2;
            this.btnPheptru.Text = "-";
            this.btnPheptru.UseVisualStyleBackColor = true;
            this.btnPheptru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepNhan
            // 
            this.btnPhepNhan.Location = new System.Drawing.Point(422, 219);
            this.btnPhepNhan.Name = "btnPhepNhan";
            this.btnPhepNhan.Size = new System.Drawing.Size(62, 62);
            this.btnPhepNhan.TabIndex = 2;
            this.btnPhepNhan.Text = "*";
            this.btnPhepNhan.UseVisualStyleBackColor = true;
            this.btnPhepNhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnPhepchia
            // 
            this.btnPhepchia.Location = new System.Drawing.Point(490, 219);
            this.btnPhepchia.Name = "btnPhepchia";
            this.btnPhepchia.Size = new System.Drawing.Size(63, 62);
            this.btnPhepchia.TabIndex = 2;
            this.btnPhepchia.Text = "/";
            this.btnPhepchia.UseVisualStyleBackColor = true;
            this.btnPhepchia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết Quả";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKetqua
            // 
            this.txtKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.Location = new System.Drawing.Point(260, 298);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(335, 36);
            this.txtKetqua.TabIndex = 3;
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
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPhepchia);
            this.Controls.Add(this.btnPhepNhan);
            this.Controls.Add(this.btnPheptru);
            this.Controls.Add(this.btnPhepcong);
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
        private System.Windows.Forms.Button btnPhepcong;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Button btnPheptru;
        private System.Windows.Forms.Button btnPhepNhan;
        private System.Windows.Forms.Button btnPhepchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

