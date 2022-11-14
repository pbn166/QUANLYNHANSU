using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taikhoan
{
    public partial class BangCongNVCB : Form
    {
        public SqlConnection conn;
        public void Ketnoi()
        {
            string chuoiketnoi = "Server = DESKTOP-JC1GAQM\\SQLEXPRESS; Database = QLNS; integrated security= True";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

        }
        public void HienthiDuLieu(string cautruyvan, DataGridView dg)
        {
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSBC");
            dg.DataSource = ds;
            dg.DataMember = "DSBC";

        }
        public BangCongNVCB()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MaNV = tb_manv.Text;
            string MaPhong = tb_maphong.Text;
            string MaLuong = tb_maluong.Text;
            string LCB = tb_luongcb.Text;
            string PhuCapCV = tb_phucapcv.Text;
            string PhuCapKhac = tb_phucapkhac.Text;
            string KhenThuong = tb_khenthuong.Text;
            string KyLuat = tb_kyluat.Text;
            string SoNgayCong = tb_songaycong.Text;
            string SoNgayNghi = tb_songaycong.Text;
            string SoNgayLamThemNV = tb_songaylamthem.Text;
            string NgayBD = tb_ngaybatdau.Value.Date.ToShortDateString();
            string GhiChu = tb_ghichu.Text;


            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.BoPhan VALUES " + "('" + tb_ghichu.Text + "','" + tb_khenthuong.Text + "', '" + tb_kyluat.Text + "', '" + tb_luongcb.Text + "', '" + tb_maluong.Text + "', '"+tb_manv.Text+"', '"+tb_maphong.Text+"', '"+tb_ngaybatdau.Text+"', '"+tb_phucapcv.Text+"', '"+tb_phucapkhac.Text+"', '"+tb_songaycong.Text+"', '"+tb_songaylamthem.Text+"', '"+tb_songaynghi.Text +"')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangCongNVCB", luoidulieu);
        }

        private void BangCongNVCB_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.BangCongNVCB", luoidulieu);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaNV = tb_manv.Text;
            string MaPhong = tb_maphong.Text;
            string MaLuong = tb_maluong.Text;
            string LCB = tb_luongcb.Text;
            string PhuCapCV = tb_phucapcv.Text;
            string PhuCapKhac = tb_phucapkhac.Text;
            string KhenThuong = tb_khenthuong.Text;
            string KyLuat = tb_kyluat.Text;
            string SoNgayCong = tb_songaycong.Text;
            string SoNgayNghi = tb_songaycong.Text;
            string SoNgayLamThemNV = tb_songaylamthem.Text;
            string NgayBD = tb_ngaybatdau.Value.Date.ToShortDateString();
            string GhiChu = tb_ghichu.Text;

            string sql_sua = "UPDATE dbo.BangCongNVCB SET MaNV = '"+MaNV+"', MaPhong = '"+MaPhong+"', MaLuong = '"+MaLuong+"', LCB = '"+LCB+"',PhuCapCV = '"+PhuCapCV+"', PhuCapKhac = '"+PhuCapKhac+"', KhenThuong = '"+KhenThuong+"', KyLuat = '"+KyLuat+"', SoNgayCong = '"+SoNgayCong+"', SoNgayNghi = '"+SoNgayNghi+"', SoNgayLamThemNV = '"+SoNgayLamThemNV+"', NgayBD = '"+NgayBD+"', GhiChu = '"+GhiChu+"'  ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangCongNVCB", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            String sqlXoa = "DELETE FROM dbo.BangCongNVCB ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.BangCongNVCB", luoidulieu);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void luoidulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_maphong.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_maluong.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_luongcb.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_phucapcv.Text = luoidulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_phucapkhac.Text = luoidulieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_khenthuong.Text = luoidulieu.Rows[e.RowIndex].Cells[6].Value.ToString();
            tb_kyluat.Text = luoidulieu.Rows[e.RowIndex].Cells[7].Value.ToString();
            tb_songaycong.Text = luoidulieu.Rows[e.RowIndex].Cells[8].Value.ToString();
            tb_songaynghi.Text = luoidulieu.Rows[e.RowIndex].Cells[9].Value.ToString();
            tb_songaylamthem.Text = luoidulieu.Rows[e.RowIndex].Cells[10].Value.ToString();
            tb_ngaybatdau.Text = luoidulieu.Rows[e.RowIndex].Cells[11].Value.ToString();
            tb_ghichu.Text = luoidulieu.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void bt_tinhluong_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(tb_luongcb.Text);
            int pccv = Convert.ToInt32(tb_phucapcv.Text);
            int pck = Convert.ToInt32(tb_phucapkhac.Text);
            int kt = Convert.ToInt32(tb_khenthuong.Text);
            int snc = Convert.ToInt32(tb_songaycong.Text);
            int lt = Convert.ToInt32(tb_songaylamthem.Text);
            float luong = (((lcb / 26) * snc + (lt * 40000)) + pccv + pck + kt);
            tb_luong.Text = luong.ToString();
        }
    }
}
