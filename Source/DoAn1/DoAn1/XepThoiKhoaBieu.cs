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
    public partial class XepThoiKhoaBieu : Form
    {
        public XepThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void lblBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
            frmTongQuanLy tql = new frmTongQuanLy();
            tql.ShowDialog();
        }

        private void btnXepTKB_Click(object sender, EventArgs e)
        {

        }
    }
}
