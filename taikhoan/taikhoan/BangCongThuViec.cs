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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taikhoan
{
    public partial class LuongNVTV : Form
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
            da.Fill(ds, "DSLNVTV");
            dg.DataSource = ds;
            dg.DataMember = "DSLNVTV";

        }
        public LuongNVTV()
        {
            InitializeComponent();
        }

        

        private void thembtn__Click(object sender, EventArgs e)
        {
            
            string SoNgayCong = tb_songaycong.Text;
            string SoNgayNghi = tb_songaynghi.Text;
            string SoGioLamThem = tb_sogiolamthem.Text;
            string LuongTV = tb_luongthuviec.Text;
            string Luong = tb_luong.Text;
            string GhiChu = tb_ghichu.Text;
            string MaNVTV = tb_manvtv.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.BangCongThuViec VALUES " + "('" + SoNgayCong + "','" + SoNgayNghi+ "', '" + SoGioLamThem + "', '" + LuongTV + "', '" + Luong + "', '"+GhiChu+"', '"+MaNVTV+"')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangCongThuViec", luoidulieu);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string SoNgayCong = tb_songaycong.Text;
            string SoNgayNghi = tb_songaynghi.Text;
            string SoGioLamThem = tb_sogiolamthem.Text;
            string LuongTV = tb_luongthuviec.Text;
            string Luong = tb_luong.Text;
            string GhiChu = tb_ghichu.Text;
            string MaNVTV = tb_manvtv.Text;

            string sql_sua = "UPDATE dbo.BangCongThuViec SET SoNgayCong = '" + SoNgayCong + "', SoNgayNghi = '"+SoNgayNghi+"',SoGioLamThem ='" + SoGioLamThem + "', LuongTV ='" + LuongTV + "', Luong = '" + Luong + "', GhiChu = '"+GhiChu+"' , MaNVTV = '"+MaNVTV+"' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangCongThuViec", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            String sqlXoa = "DELETE FROM dbo.BangCongThuViec ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.BangCongThuViec", luoidulieu);
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
            tb_songaycong.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_songaynghi.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_sogiolamthem.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_luongthuviec.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_luong.Text = luoidulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_ghichu.Text = luoidulieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_manvtv.Text = luoidulieu.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void LuongNVTV_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.BangCongThuViec", luoidulieu);
        }

        private void bt_tinhluong_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(tb_luong.Text);
            int nc = Convert.ToInt32(tb_songaycong.Text);
            int lt = Convert.ToInt32(tb_sogiolamthem.Text);
            float luong = ((l / 26) * nc + (lt * 40000));
            tb_luong.Text = luong.ToString();
        }
    }
}
