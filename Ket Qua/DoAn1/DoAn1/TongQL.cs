using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class frmTongQuanLy : Form
    {
        int i = -1;
        public frmTongQuanLy()
        {
            InitializeComponent();
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            QLBan ba = new QLBan();
            this.Hide();
            ba.ShowDialog();
        }

        private void btnQLBM_Click(object sender, EventArgs e)
        {
            QLBoMon bm = new QLBoMon();
            this.Hide();
            bm.ShowDialog();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            QLGiaoVien gv = new QLGiaoVien();
            this.Hide();
            gv.ShowDialog();
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {
            QLLop lop = new QLLop();
            this.Hide();
            lop.ShowDialog();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            QLMonHoc mh = new QLMonHoc();
            this.Hide();
            mh.ShowDialog();
        }

        private void btnQLPH_Click(object sender, EventArgs e)
        {
            QLPhongHoc ph = new QLPhongHoc();
            this.Hide();
            ph.ShowDialog();
        }

        private void btnXepTKB_Click(object sender, EventArgs e)
        {
            this.Dispose();
            XepThoiKhoaBieu tkb = new XepThoiKhoaBieu();
            tkb.ShowDialog();
        }

        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            this.Dispose();
            XemTKB tkb = new XemTKB();
            tkb.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = lblDOAN.Location.X;
            int y = lblDOAN.Location.Y;
            if (x == -1 * lblDOAN.Width)
            {
                x = lblDOAN.Width;
            }
            lblDOAN.Location = new Point(x + i, y);
        }

        private void frmTongQuanLy_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmTongQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
