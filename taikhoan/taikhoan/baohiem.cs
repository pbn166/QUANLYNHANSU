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
    public partial class baohiem : Form
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
        public baohiem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void baohiem_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("select * from SoBH", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maluong = textBox1.Text;
            string mabaohiem = textBox2.Text;
            string ngaycapso = dateTimePicker1.Value.ToString();
            string noicapso = textBox4.Text;
            string ghichu = textBox5.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO SoBH VALUES " + " ( '" + maluong + "', '" + mabaohiem + "', '" + ngaycapso + "', '" + noicapso + "', '" + ghichu + "')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            //HienthiDuLieu("SELECT n.MaNV, b.MaLuong, MaSoBH, NgayCapSo, NoiCapSo, s.GhiChu FROM SoBH s, NhanVien n, BangLuongCty b where s.MaNV = n.MaNV and s.MaNV = n.MaNV", dataGridView1);
            HienthiDuLieu("select * from SoBH", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            string maluong = textBox1.Text;
            string mabaohiem = textBox2.Text;
            string ngaycapso = dateTimePicker1.Value.ToString();
            string noicapso = textBox4.Text;
            string ghichu = textBox5.Text;

            string sql_sua = "UPDATE SoBH SET   MaSoBH='" + mabaohiem + "', NgayCapSo='" + ngaycapso + "', NoiCapSo='" + noicapso + "', GhiChu='" + ghichu + "'  WHERE MaLuong='" + maluong + "' ";
            SqlCommand a = new SqlCommand(sql_sua, conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            HienthiDuLieu("SELECT  MaLuong, MaSoBH, NgayCapSo, NoiCapSo, GhiChu FROM SoBH ", dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String mabh = textBox1.Text;
            String sqlXoa = "DELETE FROM SoBH WHERE MaSoBH = '" + mabh + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM SoBH", dataGridView1);
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

        }

        private void hồSơThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hosothuviec hs = new hosothuviec();
            hs.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string gtri = textBox3.Text;
            string cautruyvan = "select * from sobh where masobh = '" + gtri + "' ";
            HienthiDuLieu(cautruyvan, dataGridView1);
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            string gtri = textBox3.Text;

            if (e.KeyCode == Keys.Enter)
            {
                string cautruyvan = "select * from sobh where masobh = '" + gtri + "' ";
                HienthiDuLieu(cautruyvan, dataGridView1);

            }
        }
    }
}
