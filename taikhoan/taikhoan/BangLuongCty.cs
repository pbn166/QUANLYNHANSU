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
    public partial class BangLuongCty : Form
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
            da.Fill(ds, "DSPB");
            dg.DataSource = ds;
            dg.DataMember = "DSPB";

        }
        public BangLuongCty()
        {
            InitializeComponent();
        }

        private void BangLuongCty_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.BangLuongCty", luoidulieu);
        }

        private void luoidulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maluong.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_luongcb.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_pccchucvu.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_ghichu.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MaLuong = tb_luongcb.Text;
            string LCB = tb_luongcb.Text;
            string PCCChucvu = tb_pccchucvu.Text;
            string GhiChu = tb_ghichu.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.BangLuongCty VALUES " + "('"+tb_maluong.Text+"','"+tb_luongcb.Text+"', '"+tb_pccchucvu.Text+"', '"+tb_ghichu.Text+"')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangLuongCty", luoidulieu);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaLuong = tb_luongcb.Text;
            string LCB = tb_luongcb.Text;
            string PCCChucvu = tb_pccchucvu.Text;
            string GhiChu = tb_ghichu.Text;

            string sql_sua = "UPDATE dbo.BangLuongCty SET LCB='" + LCB + "', PCCChucVu ='" + PCCChucvu + "' WHERE MaLuong='" + MaLuong + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.BangCongCty", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String ma_luong = tb_maluong.Text;
            String sqlXoa = "DELETE FROM dbo.BangCongCty WHERE MaLuong = '" + ma_luong + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM db0.BangCongCty", luoidulieu);
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
