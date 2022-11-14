namespace taikhoan
{
    partial class PhongBan
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
            this.dt_ngaythanhlap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenphong = new System.Windows.Forms.TextBox();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.tb_mabp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maphong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.luoidulieu = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoidulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_ngaythanhlap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_tenphong);
            this.groupBox1.Controls.Add(this.tb_ghichu);
            this.groupBox1.Controls.Add(this.tb_mabp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_maphong);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về phòng ban";
            // 
            // dt_ngaythanhlap
            // 
            this.dt_ngaythanhlap.Location = new System.Drawing.Point(837, 128);
            this.dt_ngaythanhlap.Name = "dt_ngaythanhlap";
            this.dt_ngaythanhlap.Size = new System.Drawing.Size(200, 31);
            this.dt_ngaythanhlap.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày thành lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã bộ phận";
            // 
            // tb_tenphong
            // 
            this.tb_tenphong.Location = new System.Drawing.Point(837, 64);
            this.tb_tenphong.Name = "tb_tenphong";
            this.tb_tenphong.Size = new System.Drawing.Size(198, 31);
            this.tb_tenphong.TabIndex = 0;
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(219, 173);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(818, 31);
            this.tb_ghichu.TabIndex = 0;
            // 
            // tb_mabp
            // 
            this.tb_mabp.Location = new System.Drawing.Point(219, 119);
            this.tb_mabp.Name = "tb_mabp";
            this.tb_mabp.Size = new System.Drawing.Size(198, 31);
            this.tb_mabp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // tb_maphong
            // 
            this.tb_maphong.Location = new System.Drawing.Point(219, 64);
            this.tb_maphong.Name = "tb_maphong";
            this.tb_maphong.Size = new System.Drawing.Size(198, 31);
            this.tb_maphong.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_thoat);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1207, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // luoidulieu
            // 
            this.luoidulieu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.luoidulieu.ColumnHeadersHeight = 46;
            this.luoidulieu.Location = new System.Drawing.Point(12, 402);
            this.luoidulieu.Name = "luoidulieu";
            this.luoidulieu.RowHeadersWidth = 82;
            this.luoidulieu.Size = new System.Drawing.Size(1207, 358);
            this.luoidulieu.TabIndex = 0;
            this.luoidulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoidulieu_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(102, 36);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 46);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(274, 36);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(109, 46);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(455, 36);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(110, 46);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(631, 36);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(118, 46);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 772);
            this.Controls.Add(this.luoidulieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PhongBan";
            this.Text = "QUẢN LÝ PHÒNG BAN";
            this.Load += new System.EventHandler(this.PhongBan_Load);
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
        private System.Windows.Forms.DateTimePicker dt_ngaythanhlap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenphong;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.TextBox tb_mabp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maphong;
        private System.Windows.Forms.DataGridView luoidulieu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
    }
}