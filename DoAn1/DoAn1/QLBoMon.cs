using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace DoAn1
{
    public partial class QLBoMon : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLBoMon()
        {
            InitializeComponent();
        }

        private void btnThemBM_Click(object sender, EventArgs e)
        {
            if (btnThemBM.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaBM.Text = null;
                txtTenBM.Text = null;
                btnSuaBM.Enabled = false;
                btnXoaBM.Enabled = false;
                btnReload.Text = "Save";
                txtMaBM.Enabled = true;
                txtTenBM.Enabled = true;
            }
        }

        private void btnSuaBM_Click(object sender, EventArgs e)
        {
            if (btnSuaBM.Enabled == true)
            {
                k = 1;
                btnThemBM.Enabled = false;
                btnXoaBM.Enabled = false;
                btnReload.Text = "Save";
                txtTenBM.Enabled = true;
            }
        }

        private void btnXoaBM_Click(object sender, EventArgs e)
        {
            if (btnXoaBM.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null, "Bạn có chắc xóa bộ môn " + txtTenBM.Text + " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bool f = bl.MyExecuteNonQuery("Delete from BoMon where MaBM=" + txtMaBM.Text, CommandType.Text, ref err);
                    if (f == true) MessageBox.Show("Đã xóa!");
                    else MessageBox.Show("Xóa lỗi! Lỗi " + err);
                    QLBoMon_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string err = null;
            if (k == 1)
            {
                bool f;
                if (t == 1) f = bl.MyExecuteNonQuery("insert into BoMon values(" + txtMaBM.Text + ",'" + txtTenBM.Text + "')", CommandType.Text, ref err);
                else f = bl.MyExecuteNonQuery("Update BoMon set TenBM='" + txtTenBM.Text + "' where MaBM=" + txtMaBM.Text, CommandType.Text, ref err);
                if (f == true)
                {
                    if (t == 1) MessageBox.Show("Thêm thành công!");
                    else MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    if(t==1) MessageBox.Show("Thêm lỗi! Lỗi " + err);
                    else MessageBox.Show("Sửa lỗi! Lỗi " + err);
                }
                QLBoMon_Load(sender, e);
            }
            else
            {
                QLBoMon_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                QLBoMon_Load(sender, e);
            }
            else
            {
                this.Dispose();
                frmTongQuanLy tql = new frmTongQuanLy();
                tql.ShowDialog();
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0) s = 1;
            else if (cmbSearch.SelectedIndex == 1) s = 2;
            else s = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (s == 0) MessageBox.Show("Chọn đơn vị tìm kiếm");
            else if (s == 1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM BoMon where MaBM like '%" + txtSearch.Text+"%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvBoMon.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 2)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM BoMon where TenBM like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvBoMon.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void QLBoMon_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaBM.Enabled = false;
                txtTenBM.Enabled = false;
                btnThemBM.Enabled = true;
                btnSuaBM.Enabled = true;
                btnXoaBM.Enabled = true;
                txtMaBM.Text = null;
                txtTenBM.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM BoMon";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvBoMon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvBoMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBoMon.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvBoMon.RowCount)
            {
                txtMaBM.Text = dgvBoMon.Rows[r].Cells[0].Value.ToString();
                txtTenBM.Text = dgvBoMon.Rows[r].Cells[1].Value.ToString();
            }
        }
    }
}
