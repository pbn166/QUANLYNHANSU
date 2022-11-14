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
    public partial class TangLuong : Form
    {
        public SqlConnection conn;
        public void Ketnoi()
        {
            string chuoiketnoi = "Server = DESKTOP-VSFCU84; Database = QLNS; integrated security= True";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

        }
        public void HienthiDuLieu(string cautruyvan, DataGridView dg)
        {
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSTL");
            dg.DataSource = ds;
            dg.DataMember = "DSTl";

        }
        public TangLuong()
        {
            InitializeComponent();
        }

        private void TangLuong_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.TangLuong", luoidulieu);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MaLuongMoi = tb_maluongmoi.Text;
            string NgaySua = tb_ngaysua.Text;
            string LyDo = tb_lydo.Text;
            string MaNV = tb_manv.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.LuongMoi VALUES " + "('" + tb_maluongmoi.Text + "','" + tb_ngaysua.Text + "', '" + tb_lydo.Text + "', '" + tb_manv.Text + "')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.LuongMoi", luoidulieu);
        }

        private void luoidulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maluongmoi.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_ngaysua.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_lydo.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_manv.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaLuongMoi = tb_maluongmoi.Text;
            string NgaySua = tb_ngaysua.Text;
            string LyDo = tb_lydo.Text;
            string MaNV = tb_manv.Text;

            string sql_sua = "UPDATE dbo.LuongMoi SET MaNV='" + MaNV + "', NgaySua ='" + NgaySua + "' WHERE MaLuongMoi='" + MaLuongMoi + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.LuongMoi", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String ma_luongmoi = tb_maluongmoi.Text;
            String sqlXoa = "DELETE FROM dbo.LuongMoi WHERE MaLuongMoi = '" + ma_luongmoi + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.LuongMoi", luoidulieu);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
