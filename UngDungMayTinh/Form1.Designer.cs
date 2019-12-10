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
            this.btnphepcong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnpheptru = new System.Windows.Forms.Button();
            this.btnphepnhan = new System.Windows.Forms.Button();
            this.btnphepchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ung Dung May Tinh";
            // 
            // btnphepcong
            // 
            this.btnphepcong.Location = new System.Drawing.Point(216, 250);
            this.btnphepcong.Name = "btnphepcong";
            this.btnphepcong.Size = new System.Drawing.Size(79, 58);
            this.btnphepcong.TabIndex = 3;
            this.btnphepcong.Text = "+";
            this.btnphepcong.UseVisualStyleBackColor = true;
            this.btnphepcong.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "So B";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(216, 156);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(405, 22);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(216, 199);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(405, 22);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnpheptru
            // 
            this.btnpheptru.Location = new System.Drawing.Point(320, 250);
            this.btnpheptru.Name = "btnpheptru";
            this.btnpheptru.Size = new System.Drawing.Size(82, 58);
            this.btnpheptru.TabIndex = 3;
            this.btnpheptru.Text = "-";
            this.btnpheptru.UseVisualStyleBackColor = true;
            this.btnpheptru.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepnhan
            // 
            this.btnphepnhan.Location = new System.Drawing.Point(422, 250);
            this.btnphepnhan.Name = "btnphepnhan";
            this.btnphepnhan.Size = new System.Drawing.Size(91, 58);
            this.btnphepnhan.TabIndex = 3;
            this.btnphepnhan.Text = "*";
            this.btnphepnhan.UseVisualStyleBackColor = true;
            this.btnphepnhan.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // btnphepchia
            // 
            this.btnphepchia.Location = new System.Drawing.Point(530, 250);
            this.btnphepchia.Name = "btnphepchia";
            this.btnphepchia.Size = new System.Drawing.Size(91, 58);
            this.btnphepchia.TabIndex = 3;
            this.btnphepchia.Text = "/";
            this.btnphepchia.UseVisualStyleBackColor = true;
            this.btnphepchia.Click += new System.EventHandler(this.BtnPhepTinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "KQ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(216, 354);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(405, 22);
            this.txtKQ.TabIndex = 3;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "So A";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnphepchia);
            this.Controls.Add(this.btnphepnhan);
            this.Controls.Add(this.btnpheptru);
            this.Controls.Add(this.btnphepcong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnphepcong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnpheptru;
        private System.Windows.Forms.Button btnphepnhan;
        private System.Windows.Forms.Button btnphepchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

