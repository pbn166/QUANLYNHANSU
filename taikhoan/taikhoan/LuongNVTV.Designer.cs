namespace taikhoan
{
    partial class LuongNVTV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.luoidulieu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_manvtv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_songaycong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_songaynghi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sogiolamthem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_luongthuviec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_luong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.thembtn_ = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoidulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LƯƠNG NHÂN VIÊN THỬ VIỆC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ghichu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_luong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_luongthuviec);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_sogiolamthem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_songaynghi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_songaycong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_manvtv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 587);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về lương nhân viên thử việc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.thembtn_);
            this.groupBox2.Location = new System.Drawing.Point(543, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // luoidulieu
            // 
            this.luoidulieu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.luoidulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoidulieu.Location = new System.Drawing.Point(543, 184);
            this.luoidulieu.Name = "luoidulieu";
            this.luoidulieu.RowHeadersWidth = 82;
            this.luoidulieu.RowTemplate.Height = 33;
            this.luoidulieu.Size = new System.Drawing.Size(765, 473);
            this.luoidulieu.TabIndex = 3;
            this.luoidulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoidulieu_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NVTV";
            // 
            // tb_manvtv
            // 
            this.tb_manvtv.Location = new System.Drawing.Point(182, 69);
            this.tb_manvtv.Name = "tb_manvtv";
            this.tb_manvtv.Size = new System.Drawing.Size(268, 31);
            this.tb_manvtv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số ngày công";
            // 
            // tb_songaycong
            // 
            this.tb_songaycong.Location = new System.Drawing.Point(182, 141);
            this.tb_songaycong.Name = "tb_songaycong";
            this.tb_songaycong.Size = new System.Drawing.Size(268, 31);
            this.tb_songaycong.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày nghỉ";
            // 
            // tb_songaynghi
            // 
            this.tb_songaynghi.Location = new System.Drawing.Point(182, 220);
            this.tb_songaynghi.Name = "tb_songaynghi";
            this.tb_songaynghi.Size = new System.Drawing.Size(268, 31);
            this.tb_songaynghi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số giờ làm thêm";
            // 
            // tb_sogiolamthem
            // 
            this.tb_sogiolamthem.Location = new System.Drawing.Point(182, 300);
            this.tb_sogiolamthem.Name = "tb_sogiolamthem";
            this.tb_sogiolamthem.Size = new System.Drawing.Size(268, 31);
            this.tb_sogiolamthem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lương thử việc";
            // 
            // tb_luongthuviec
            // 
            this.tb_luongthuviec.Location = new System.Drawing.Point(182, 383);
            this.tb_luongthuviec.Name = "tb_luongthuviec";
            this.tb_luongthuviec.Size = new System.Drawing.Size(268, 31);
            this.tb_luongthuviec.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lương";
            // 
            // tb_luong
            // 
            this.tb_luong.Location = new System.Drawing.Point(182, 456);
            this.tb_luong.Name = "tb_luong";
            this.tb_luong.Size = new System.Drawing.Size(268, 31);
            this.tb_luong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ghi chú";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(182, 535);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(268, 31);
            this.tb_ghichu.TabIndex = 1;
            // 
            // thembtn_
            // 
            this.thembtn_.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thembtn_.Location = new System.Drawing.Point(31, 42);
            this.thembtn_.Name = "thembtn_";
            this.thembtn_.Size = new System.Drawing.Size(123, 47);
            this.thembtn_.TabIndex = 0;
            this.thembtn_.Text = "Thêm";
            this.thembtn_.UseVisualStyleBackColor = true;
            this.thembtn_.Click += new System.EventHandler(this.thembtn__Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(221, 42);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 47);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(425, 42);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 47);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(620, 42);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 47);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // LuongNVTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 669);
            this.Controls.Add(this.luoidulieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LuongNVTV";
            this.Text = "QUẢN LÝ LƯƠNG NHÂN VIÊN THỬ VIỆC";
            this.Load += new System.EventHandler(this.LuongNVTV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoidulieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView luoidulieu;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_luong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_luongthuviec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sogiolamthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_songaynghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_songaycong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_manvtv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button thembtn_;
    }
}