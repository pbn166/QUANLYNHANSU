namespace taikhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(230, 64);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(163, 22);
            this.tb_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu: ";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(230, 113);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(163, 22);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangnhap.Location = new System.Drawing.Point(125, 168);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(110, 37);
            this.btn_dangnhap.TabIndex = 3;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(260, 168);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 37);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 268);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
    }
}

