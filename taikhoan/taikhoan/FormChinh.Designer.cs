namespace taikhoan
{
    partial class FormChinh
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
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.btn_danhmuc = new System.Windows.Forms.Button();
            this.btn_chucnang = new System.Windows.Forms.Button();
            this.btn_quanly = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_quyen = new System.Windows.Forms.TextBox();
            this.luoidulieu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_datlai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luoidulieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_taikhoan.Location = new System.Drawing.Point(12, 12);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(126, 33);
            this.btn_taikhoan.TabIndex = 0;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.UseVisualStyleBackColor = false;
            // 
            // btn_danhmuc
            // 
            this.btn_danhmuc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_danhmuc.Location = new System.Drawing.Point(144, 12);
            this.btn_danhmuc.Name = "btn_danhmuc";
            this.btn_danhmuc.Size = new System.Drawing.Size(130, 33);
            this.btn_danhmuc.TabIndex = 1;
            this.btn_danhmuc.Text = "Danh mục";
            this.btn_danhmuc.UseVisualStyleBackColor = false;
            // 
            // btn_chucnang
            // 
            this.btn_chucnang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_chucnang.Location = new System.Drawing.Point(280, 12);
            this.btn_chucnang.Name = "btn_chucnang";
            this.btn_chucnang.Size = new System.Drawing.Size(139, 33);
            this.btn_chucnang.TabIndex = 2;
            this.btn_chucnang.Text = "Chức năng";
            this.btn_chucnang.UseVisualStyleBackColor = false;
            // 
            // btn_quanly
            // 
            this.btn_quanly.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_quanly.Location = new System.Drawing.Point(425, 12);
            this.btn_quanly.Name = "btn_quanly";
            this.btn_quanly.Size = new System.Drawing.Size(133, 33);
            this.btn_quanly.TabIndex = 3;
            this.btn_quanly.Text = "Quản lý";
            this.btn_quanly.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên tài khoản:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(386, 103);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(172, 22);
            this.tb_username.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(386, 140);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(172, 22);
            this.tb_pass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên người dùng:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(386, 174);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(172, 22);
            this.tb_name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quyền:";
            // 
            // tb_quyen
            // 
            this.tb_quyen.Location = new System.Drawing.Point(386, 214);
            this.tb_quyen.Name = "tb_quyen";
            this.tb_quyen.Size = new System.Drawing.Size(172, 22);
            this.tb_quyen.TabIndex = 6;
            // 
            // luoidulieu
            // 
            this.luoidulieu.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.luoidulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoidulieu.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.luoidulieu.Location = new System.Drawing.Point(109, 260);
            this.luoidulieu.Name = "luoidulieu";
            this.luoidulieu.RowHeadersWidth = 51;
            this.luoidulieu.RowTemplate.Height = 24;
            this.luoidulieu.Size = new System.Drawing.Size(640, 150);
            this.luoidulieu.TabIndex = 7;
            this.luoidulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoidulieu_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dong);
            this.groupBox1.Controls.Add(this.btn_datlai);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dong.Location = new System.Drawing.Point(698, 30);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(110, 32);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_datlai
            // 
            this.btn_datlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_datlai.Location = new System.Drawing.Point(521, 30);
            this.btn_datlai.Name = "btn_datlai";
            this.btn_datlai.Size = new System.Drawing.Size(114, 32);
            this.btn_datlai.TabIndex = 3;
            this.btn_datlai.Text = "Đặt lại";
            this.btn_datlai.UseVisualStyleBackColor = false;
            this.btn_datlai.Click += new System.EventHandler(this.btn_datlai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoa.Location = new System.Drawing.Point(361, 30);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(105, 32);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sua.Location = new System.Drawing.Point(192, 31);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(102, 31);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_them.Location = new System.Drawing.Point(31, 32);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 32);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(720, 64);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(119, 22);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm:";
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.luoidulieu);
            this.Controls.Add(this.tb_quyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quanly);
            this.Controls.Add(this.btn_chucnang);
            this.Controls.Add(this.btn_danhmuc);
            this.Controls.Add(this.btn_taikhoan);
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoidulieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.Button btn_danhmuc;
        private System.Windows.Forms.Button btn_chucnang;
        private System.Windows.Forms.Button btn_quanly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_quyen;
        private System.Windows.Forms.DataGridView luoidulieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_datlai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox btn_timkiem;
        private System.Windows.Forms.Label label6;
    }
}