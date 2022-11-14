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
    public partial class hosothuviec : Form
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
            da.Fill(ds, "DSTK");
            dg.DataSource = ds;
            dg.DataMember = "DSTK";

        }
        public hosothuviec()
        {
            InitializeComponent();
        }

        private void hosothuviec_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("select * from HoSoThuViec", dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manv.Text = "";
           map.Text  = "";
            hoten.Text= "";
            dateTimePicker1.Text= "";
            comboBox1.Text= "";
            diachi.Text= "";
            trinhdo.Text= "";
            thangtv.Text= "";
            dateTimePicker2.Text= "";
            vitri.Text= "";
            ghichu.Text= "";
            hocham.Text= "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = this.manv.Text;
            string map = this.map.Text;
            string hoten = this.hoten.Text;
            string ns = this.dateTimePicker1.Value.ToString();
            string gt = this.comboBox1.Text;
            string dc = this.diachi.Text;
            string td= this.trinhdo.Text;
            string ttv = this.thangtv.Text;
            string ntv = this.dateTimePicker2.Value.ToString();
            string vitri = this.vitri.Text;
            string ghichu = this.ghichu.Text;
            string hh = hocham.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO HoSoThuViec VALUES " + "('" + manv + "','"+map+"', '"+hoten+"', '"+ns+"','"+gt+"','"+dc+"','"+td+"','"+vitri+"','"+ntv+"','"+ttv+"','"+ghichu+"','"+hh+"' )", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            //HienthiDuLieu("SELECT MaNVTV, P.MaP, HoTen,NgaySinh, GioiTinh, DiaChi,TDHocVan,ViTriThuViec,NgayTv,SoThangTV,GhiChu, HocHam  FROM HoSoThuViec H, PhongBan P Where H.MaP = P.MaP ", dataGridView1);
            HienthiDuLieu("SELECT * FROM HoSoThuViec", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            map.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            hoten.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            diachi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            trinhdo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            thangtv.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            vitri.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            ghichu.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            hocham.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = this.manv.Text;
            string map = this.map.Text;
            string hoten = this.hoten.Text;
            string ns = this.dateTimePicker1.Value.ToString();
            string gt = this.comboBox1.Text;
            string dc = this.diachi.Text;
            string td = this.trinhdo.Text;
            string ttv = this.thangtv.Text;
            string ntv = this.dateTimePicker2.Value.ToString();
            string vitri = this.vitri.Text;
            string ghichu = this.ghichu.Text;
            string hh = hocham.Text;

            string sql_sua = "UPDATE HoSoThuViec SET  MaPhong = '" + map + "',  HoTen='" + hoten + "', NgaySinh='" + ns + "', GioiTinh='" + gt + "', DiaChi = '"+dc+"', TDHocvan = '"+td+ "', ViTriThuViec = '"+vitri+"', NgayTV = '"+ntv+"', SoThangTV = '"+ttv+"', GhiChu = '"+ghichu+"', HocHam = '"+hh+ "' WHERE MaNVTV='" + manv + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            //HienthiDuLieu("SELECT MaNVTV, MaP, HoTen,NgaySinh, GioiTinh, DiaChi,TDHocVan,ViTriThuViec,NgayTv,SoThangTV,GhiChu, HocHam  FROM HoSoThuViec H, PhongBan P Where H.MaP = P.MaP ", dataGridView1);
            HienthiDuLieu("select * from HoSoThuViec", dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String manvien = manv.Text;
            String sqlXoa = "DELETE FROM hosothuviec WHERE manvtv = '" + manvien + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM hosothuviec", dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            qlnhansu ns = new qlnhansu();
            ns.ShowDialog();
            this.Visible = true;

        }

        private void chếĐộBảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            baohiem bh = new baohiem();
            bh.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string gtri = textBox27.Text;
           // string cautruyvan = "select * from hosothuviec where manvTV = '" + gtri + "' or HOTEN like N'%" + gtri + "'";
          //  HienthiDuLieu(cautruyvan, dataGridView1);
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            string gtri = textBox1.Text;

            if (e.KeyCode == Keys.Enter)
            {
                string cautruyvan = "select * from hosothuviec where manvtv = '" + gtri + "' or hoten like N'%" + gtri + "'";
                HienthiDuLieu(cautruyvan, dataGridView1);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string gtri = textBox1.Text;
            string cautruyvan = "select * from hosothuviec where manvtv = '" + gtri + "' or hoten like N'%" + gtri + "'";
            HienthiDuLieu(cautruyvan, dataGridView1);
        }

        // private void button6(object sender, KeyEventArgs e)
        // {
        //     string gtri = textBox27.Text;
        //
        //     if (e.KeyCode == Keys.Enter)
        //    {
        //         string cautruyvan = "select * from hosothuviec where manvtv = '" + gtri + "' or hoten like N'%" + gtri + "'";
        //        HienthiDuLieu(cautruyvan, dataGridView1);

        //    }
        //}
    }
}
