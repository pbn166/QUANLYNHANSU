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
    public partial class TimKiem : Form
    {
        public SqlConnection conn;
        public void Ketnoi()
        {
            string chuoiketnoi = "Server = DESKTOP-9B63BU9\\SQLEXPRESS; Database = QLNS; integrated security = True";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

        }
        public void HienthiDuLieu(string cautruyvan, DataGridView dg)
        {
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSTC");
            dg.DataSource = ds;
            dg.DataMember = "DSTC";

        }
        public TimKiem()
        {
            InitializeComponent();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            Ketnoi();
            HienthiDuLieu("SELECT * FROM dbo.NhanVien", luoidulieu);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            i = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("Bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string gtri = textBox1.Text;
                    if (i == 1)
                    {
                        string cautruyvan = "SELECT * FROM dbo.NhanVien WHERE MaNV = '" + gtri + "'";
                        // string cautruyvan = "SELECT * FROM dbo.TaiKhoan WHERE UserName = '" + gtri + "' OR TEN like N'%" + gtri + "%'";
                        HienthiDuLieu(cautruyvan, luoidulieu);
                    }
                    if (i == 2)
                    {
                        string cautruyvan = "SELECT * FROM dbo.NhanVien WHERE HoTen LIKE N'%" + gtri + "%'";
                        HienthiDuLieu(cautruyvan, luoidulieu);
                    }
                    if (i == 3)
                    {
                        string cautruyvan = "SELECT * FROM dbo.NhanVien WHERE CCCD = '" + gtri + "'";
                        HienthiDuLieu(cautruyvan, luoidulieu);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//        }
//    }
//}
