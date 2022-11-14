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
    public partial class qlnhansu : Form
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
        public qlnhansu()
        {
            InitializeComponent();
        }

        private void qlnhansu_Load(object sender, EventArgs e)
        {
            Ketnoi();
            //HienthiDuLieu("select Manv, MaPhong, MaBoPhan, MaLuong, HoTen, NgaySinh, GioiTinh, TTHonNhan, CCCD, NoiCap,ChucVu, LoaiHD, ThoiGian, NgayKy,NgayHetHan, GhiChu from NhanVien",dataGridView1);
            HienthiDuLieu("select * from NhanVien", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = textBox1.Text;
            string map = textBox2.Text;
            string mabp = textBox3.Text;
            string maluong = textBox4.Text;
            string hoten = textBox5.Text;
            string ngaysinh = dateTimePicker2.Value.ToString();
            string gioitinh = comboBox1.Text;
            string sdt = textBox8.Text;
            string tthn = comboBox2.Text;
            string cccd = textBox10.Text;
            string noicap = textBox11.Text;
            string chucvu = textBox12.Text;
            string loaihd = textBox13.Text;
            string thoigian = textBox14.Text;
            string ngayky = dateTimePicker1.Value.ToString();
            string ngayhh = textBox16.Text;
            string dantoc = textBox17.Text;
            string tongiao = textBox18.Text;
            string thuongtru = textBox19.Text;
            string tamtru = textBox10.Text;
            string nguyenquan = textBox21.Text;
            string quoctich = textBox22.Text;
            string noisinh = textBox23.Text;
            string thaisan = textBox24.Text;
            string thoiviec = textBox25.Text;
            string tdhv = textBox26.Text; 
            string ghichu = textBox7.Text;

            SqlCommand sql_them = new SqlCommand("INSERT INTO NhanVien VALUES " + "('" + manv + "', '" + map + "', '" + mabp + "',  '" + maluong + "', '" + hoten + "', '" + ngaysinh + "', '" + gioitinh + "','"+tthn+"','"+cccd+ "','" + noicap+"','"+chucvu+"','"+loaihd+"','"+thoigian+"','"+ngayky+"','"+ngayhh+ "','"+sdt+"','" + tdhv+"','"+ghichu+"','"+thaisan+"','"+thoiviec+"','"+dantoc+"','"+tongiao+"','"+thuongtru+"','"+tamtru+"','"+nguyenquan+"','"+quoctich+"','"+noisinh+"','')", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            HienthiDuLieu("select * from NhanVien", dataGridView1);
            //HienthiDuLieu("SELECT Manv, MaPhong, MaBoPhan, MaLuong, HoTen, NgaySinh, GioiTinh, TTHonNhan, CCCD, NoiCap,ChucVu, LoaiHD, ThoiGian, NgayKy,NgayHetHan, GhiChu FROM NhanVien", dataGridView1);
            
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
            textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
            textBox19.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
            textBox20.Text = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
            textBox21.Text = dataGridView1.Rows[e.RowIndex].Cells[24].Value.ToString();
            textBox22.Text = dataGridView1.Rows[e.RowIndex].Cells[25].Value.ToString();
            textBox23.Text = dataGridView1.Rows[e.RowIndex].Cells[26].Value.ToString();
            textBox24.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
            textBox25.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            textBox26.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            textBox8.Text = "";
            comboBox2.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            dateTimePicker1.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox7.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = textBox1.Text;
            string map = textBox2.Text;
            string mabp = textBox3.Text;
            string maluong = textBox4.Text;
            string hoten = textBox5.Text;
            string ngaysinh = dateTimePicker2.Value.ToString();
            string gioitinh = comboBox1.Text;
            string sdt = textBox8.Text;
            string tthn = comboBox2.Text;
            string cccd = textBox10.Text;
            string noicap = textBox11.Text;
            string chucvu = textBox12.Text;
            string loaihd = textBox13.Text;
            string thoigian = textBox14.Text;
            string ngayky = dateTimePicker1.Value.ToString();
            string ngayhh = textBox16.Text;
            string dantoc = textBox17.Text;
            string tongiao = textBox18.Text;
            string thuongtru = textBox19.Text;
            string tamtru = textBox10.Text;
            string nguyenquan = textBox21.Text;
            string quoctich = textBox22.Text;
            string noisinh = textBox23.Text;
            string thaisan = textBox24.Text;
            string thoiviec = textBox25.Text;
            string tdhv = textBox26.Text;
            string ghichu = textBox7.Text;


            string sql_sua = "UPDATE NhanVien SET  MaPhong='" + map + "', MaBoPhan='" + mabp + "', MaLuong='" + maluong + "', HoTen='"+hoten+"', NgaySinh='"+ngaysinh+"', GioiTinh='"+gioitinh+"', TTHonNhan='"+tthn+"', CCCD='"+cccd+"', NoiCap='"+noicap+"', ChucVu='"+chucvu+"', LoaiHD='"+loaihd+"', ThoiGian='"+thoigian+"', NgayKy='"+ngayky+"', NgayHetHan='"+ngayhh+"',SDT='"+sdt+"',HocVan='"+tdhv+"', GhiChu='"+ghichu+ "',ThaiSan='"+thaisan+"', ThoiViec='"+thoiviec+"', DanToc='"+dantoc+"', TonGiao='"+tongiao+"', DCThuongTru='"+thuongtru+"', DCTamTru='"+tamtru+"', NguyenQuan='"+nguyenquan+"', QuocTich='"+quoctich+"', NoiSinh='"+noisinh+"'  WHERE MaNV='" + manv + "'";
            SqlCommand a = new SqlCommand(sql_sua,conn);

            a.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            //HienthiDuLieu("SELECT Manv, MaPhong, MaBoPhan, MaLuong, HoTen, NgaySinh, GioiTinh, TTHonNhan, CCCD, NoiCap,ChucVu, LoaiHD, ThoiGian, NgayKy,NgayHetHan, GhiChu FROM NhanVien", dataGridView1);
            HienthiDuLieu("select * from NhanVien", dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String manv = textBox1.Text;
            String sqlXoa = "DELETE FROM NhanVien WHERE MaNV = '" + manv + "' ";
            SqlCommand comm = new SqlCommand(sqlXoa, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");

            HienthiDuLieu("SELECT * FROM NhanVien", dataGridView1);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hồSơThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hosothuviec hs = new hosothuviec();
            hs.ShowDialog();
            this.Visible = true;
            
            
        }

        private void bảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            baohiem bh = new baohiem();
            bh.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string gtri = textBox27.Text;
            string cautruyvan = "select * from NhanVien where manv = '" + gtri + "' OR mabophan like N '%" + gtri + "%' or maphong like N'%" + gtri + "%'";
            HienthiDuLieu(cautruyvan, dataGridView1);
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            string gtri = textBox27.Text;

            if (e.KeyCode == Keys.Enter)
            {
                string cautruyvan = "select * from NhanVien where manv = '" + gtri + "' OR mabophan like N'%"+gtri+"%' or maphong like N'%" + gtri + "%'";
                HienthiDuLieu(cautruyvan, dataGridView1);

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
