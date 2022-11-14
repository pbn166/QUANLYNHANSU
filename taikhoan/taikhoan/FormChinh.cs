using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taikhoan
{
    public partial class FormChinh : Form
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
            da.Fill(ds, "DSTK");
            dg.DataSource = ds;
            dg.DataMember = "DSTK";

        }


        public FormChinh()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void FormChinh_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.TaiKhoan", luoidulieu );
        }

        //đóng
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //đặt lại
        private void btn_datlai_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_pass.Text = "";
            tb_username.Text = "";
            tb_quyen.Text = "";
            tb_manv.Text = "";
        }

        //xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String user_name = tb_username.Text;
            String sqlXoa = "DELETE FROM dbo.TaiKhoan WHERE UserName = '" + user_name  + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM dbo.TaiKhoan", luoidulieu);
        }

        //them
        private void btn_them_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_pass.Text;
            string ten = tb_name.Text;
            string quyen = tb_quyen.Text;
            string manv = tb_manv.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO dbo.TaiKhoan VALUES " + "('"+ tb_username.Text + "', '"+ tb_pass.Text + "', '"+ tb_name.Text + "', '"+ tb_quyen.Text + "', '"+ tb_manv.Text + "')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("SELECT * FROM dbo.TaiKhoan", luoidulieu);

        }

        //sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_pass.Text;
            string ten = tb_name.Text;
            string quyen = tb_quyen.Text;

            string sql_sua = "UPDATE dbo.TaiKhoan SET Pass='"+password+"', Ten='"+ten+"', Quyen='"+quyen+"' WHERE UserName='"+username+"' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT * FROM dbo.TaiKhoan", luoidulieu);

        }

        private void luoidulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_username.Text = luoidulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_pass.Text = luoidulieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_name.Text = luoidulieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_quyen.Text = luoidulieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_manv.Text = luoidulieu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

       
        private void Search(object sender, KeyEventArgs e)
        {
            string gtri = btn_timkiem.Text;

            if (e.KeyCode == Keys.Enter)
            {
                string cautruyvan = "SELECT * FROM dbo.TaiKhoan WHERE UserName = '"+gtri+ "' OR TEN like N'%" + gtri + "%'";
                HienthiDuLieu(cautruyvan, luoidulieu);

            }
        }

        

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoPhan bphan = new BoPhan();
            bphan.Show();
        }

        //private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Phongban pban = new Phongban();
        //    pban.Show();
        //}

        private void nhânViênThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuongNVTV nvtv = new LuongNVTV();
            nvtv.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BangCongNVCB nvcb = new BangCongNVCB();
            nvcb.Show();
        }

        private void bảngLươngCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongCty cty = new BangLuongCty();
            cty.Show();
        }

        private void tăngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TangLuong tluong = new TangLuong();
            tluong.Show();
        }

       // private void indexToolStripMenuItem_Click(object sender, EventArgs e)
      //  {
      //      Phongban pb = new Phongban();
       //     pb.Show();
      //  }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongban pb = new Phongban();
            pb.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            qlnhansu hs = new qlnhansu();
            hs.ShowDialog();
            this.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            baohiem hs = new baohiem();
            hs.ShowDialog();
            this.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hosothuviec hs = new hosothuviec();
            hs.ShowDialog();
            this.Visible = true;
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
