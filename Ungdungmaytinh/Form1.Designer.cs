namespace Ungdungmaytinh
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soA = new System.Windows.Forms.Label();
            this.btnphepcong = new System.Windows.Forms.Button();
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.soB = new System.Windows.Forms.Label();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.ketQua = new System.Windows.Forms.Label();
            this.txtketQua = new System.Windows.Forms.TextBox();
            this.btnpheptru = new System.Windows.Forms.Button();
            this.btnphepnhan = new System.Windows.Forms.Button();
            this.btnphepchia = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(413, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ỨNG DỤNG MÁY TÍNH";
            // 
            // soA
            // 
            this.soA.AutoSize = true;
            this.soA.Location = new System.Drawing.Point(330, 141);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(38, 17);
            this.soA.TabIndex = 1;
            this.soA.Text = "Số A";
            this.soA.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnphepcong
            // 
            this.btnphepcong.Location = new System.Drawing.Point(410, 218);
            this.btnphepcong.Name = "btnphepcong";
            this.btnphepcong.Size = new System.Drawing.Size(75, 23);
            this.btnphepcong.TabIndex = 3;
            this.btnphepcong.Text = "+";
            this.btnphepcong.UseVisualStyleBackColor = true;
            this.btnphepcong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // txtsoA
            // 
            this.txtsoA.Location = new System.Drawing.Point(410, 136);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(378, 22);
            this.txtsoA.TabIndex = 4;
            this.txtsoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // soB
            // 
            this.soB.AutoSize = true;
            this.soB.Location = new System.Drawing.Point(330, 180);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(38, 17);
            this.soB.TabIndex = 2;
            this.soB.Text = "Số B";
            this.soB.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsoB
            // 
            this.txtsoB.Location = new System.Drawing.Point(410, 175);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(378, 22);
            this.txtsoB.TabIndex = 4;
            this.txtsoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // ketQua
            // 
            this.ketQua.AutoSize = true;
            this.ketQua.Location = new System.Drawing.Point(330, 263);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(28, 17);
            this.ketQua.TabIndex = 3;
            this.ketQua.Text = "KQ";
            this.ketQua.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtketQua
            // 
            this.txtketQua.Location = new System.Drawing.Point(410, 258);
            this.txtketQua.Name = "txtketQua";
            this.txtketQua.Size = new System.Drawing.Size(378, 22);
            this.txtketQua.TabIndex = 4;
            // 
            // btnpheptru
            // 
            this.btnpheptru.Location = new System.Drawing.Point(501, 218);
            this.btnpheptru.Name = "btnpheptru";
            this.btnpheptru.Size = new System.Drawing.Size(75, 23);
            this.btnpheptru.TabIndex = 3;
            this.btnpheptru.Text = "-";
            this.btnpheptru.UseVisualStyleBackColor = true;
            this.btnpheptru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepnhan
            // 
            this.btnphepnhan.Location = new System.Drawing.Point(595, 218);
            this.btnphepnhan.Name = "btnphepnhan";
            this.btnphepnhan.Size = new System.Drawing.Size(75, 23);
            this.btnphepnhan.TabIndex = 3;
            this.btnphepnhan.Text = "*";
            this.btnphepnhan.UseVisualStyleBackColor = true;
            this.btnphepnhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepchia
            // 
            this.btnphepchia.Location = new System.Drawing.Point(691, 218);
            this.btnphepchia.Name = "btnphepchia";
            this.btnphepchia.Size = new System.Drawing.Size(75, 23);
            this.btnphepchia.TabIndex = 3;
            this.btnphepchia.Text = "/";
            this.btnphepchia.UseVisualStyleBackColor = true;
            this.btnphepchia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.txtketQua);
            this.Controls.Add(this.txtsoB);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.txtsoA);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.btnphepchia);
            this.Controls.Add(this.btnphepnhan);
            this.Controls.Add(this.btnpheptru);
            this.Controls.Add(this.btnphepcong);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soA;
        private System.Windows.Forms.Button btnphepcong;
        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.Label soB;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.TextBox txtketQua;
        private System.Windows.Forms.Button btnpheptru;
        private System.Windows.Forms.Button btnphepnhan;
        private System.Windows.Forms.Button btnphepchia;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

