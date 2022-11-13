using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taikhoan
{
    public partial class QUANLY : Form
    {
        public QUANLY()
        {
            InitializeComponent();
        }

        private void bt_bophan_Click(object sender, EventArgs e)
        {
            BoPhan bphan = new BoPhan();
            bphan.Show();
        }

        private void bt_phongban_Click(object sender, EventArgs e)
        {
            Phongban pban = new Phongban();
            pban.Show();
        }

        private void bt_luongnvtv_Click(object sender, EventArgs e)
        {
            LuongNVTV nvtv = new LuongNVTV();
            nvtv.Show();
        }

        private void bt_luongnv_Click(object sender, EventArgs e)
        {
            BangCongNVCB nvcb = new BangCongNVCB();
            nvcb.Show();
        }

        private void bt_bangluongcty_Click(object sender, EventArgs e)
        {
            BangLuongCty cty = new BangLuongCty();
            cty.Show();
        }

        private void bt_tangluong_Click(object sender, EventArgs e)
        {
            TangLuong tl = new TangLuong();
            tl.Show();
        }
    }
}
