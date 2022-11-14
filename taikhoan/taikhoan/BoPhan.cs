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
    public partial class BoPhan : Form
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
            da.Fill(ds, "DSBP");
            dg.DataSource = ds;
            dg.DataMember = "DSBP";

        }
        public BoPhan()
        {
            InitializeComponent();
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.BoPhan", luoidulieu);
        }

        private void luoidulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mabp.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tenbp.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            dt_ngaythanhlap.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_ghichu.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MaBoPhan = tb_mabp.Text;
            string TenBoPhan = tb_tenbp.Text;
            string NgayThanhLap = dt_ngaythanhlap.Text;
            string GhiChu = tb_ghichu.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.BoPhan VALUES " + "('" + tb_mabp.Text + "', '" + tb_tenbp.Text + "', '" + dt_ngaythanhlap.Text + "', '" + tb_ghichu.Text + "')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.BoPhan", luoidulieu);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaBoPhan = tb_mabp.Text;
            string TenBoPhan = tb_tenbp.Text;
            string NgayThanhLap = dt_ngaythanhlap.Text;
            string GhiChu = tb_ghichu.Text;

            string sql_sua = "UPDATE dbo.BoPhan SET TenBoPhan='" + TenBoPhan + "', NgayThanhLap ='" + NgayThanhLap + "' WHERE MaBoPhan='" + MaBoPhan + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.BoPhan", luoidulieu);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String ma_bophan = tb_mabp.Text;
            String sqlXoa = "DELETE FROM dbo.BoPhan WHERE MaBoPhan = '" + ma_bophan + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.BoPhan", luoidulieu);
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
