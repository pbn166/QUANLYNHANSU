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
    public partial class Phongban : Form
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
            da.Fill(ds, "DSPB");
            dg.DataSource = ds;
            dg.DataMember = "DSPB";

        }
        public Phongban()
        {
            InitializeComponent();
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.PhongBan", luoidulieu);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MaBoPhan = tb_mabp.Text;
            string MaPhong = tb_maphong.Text;
            string TenPhong = tb_tenphong.Text;
            string NgayThanhLap = dt_ngaythanhlap.Text;
            string GhiChu = tb_ghichu.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.BoPhan VALUES " + "('" + tb_mabp.Text + "','"+tb_maphong.Text+"', '" + tb_tenphong.Text + "', '" + dt_ngaythanhlap.Text + "', '" + tb_ghichu.Text + "')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.PhongBan", luoidulieu);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaBoPhan = tb_mabp.Text;
            string MaPhong = tb_maphong.Text;
            string TenPhong = tb_tenphong.Text;
            string NgayThanhLap = dt_ngaythanhlap.Text;
            string GhiChu = tb_ghichu.Text;

            string sql_sua = "UPDATE dbo.PhongBan SET MaBoPhan = '"+MaBoPhan+"', TenPhong='" + TenPhong + "', NgayThanhLap ='" + NgayThanhLap + "', GhiChu = '"+GhiChu+"' WHERE MaPhong='" + MaPhong + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.PhongBan", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String ma_phong = tb_maphong.Text;
            String sqlXoa = "DELETE FROM dbo.PhongBan WHERE MaPhong = '" + ma_phong + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.PhongBan", luoidulieu);
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
            tb_maphong.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_mabp.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_tenphong.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            dt_ngaythanhlap.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_ghichu.Text = luoidulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
