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

namespace taikhoan
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;
        public void Ketnoi()
        {
            string chuoiketnoi = "Server = DESKTOP-VSFCU84; Database = QLNS; integrated security= True";
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ketnoi();


        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tk = tb_username.Text;
            string mk = tb_pass.Text;
            string cautruyvan = "SELECT * FROM dbo.TaiKhoan WHERE UserName='"+tk+"' AND Pass='"+mk+"'";
            SqlCommand comd = new SqlCommand(cautruyvan, conn);
            SqlDataReader read = comd.ExecuteReader();
            if(read.Read()==true)
            {
                MessageBox.Show("Đăng nhập thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChinh form2 = new FormChinh();
                form2.Show();
                //this.Hide();
            }else
            {
                MessageBox.Show("Đăng nhập thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }    

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
