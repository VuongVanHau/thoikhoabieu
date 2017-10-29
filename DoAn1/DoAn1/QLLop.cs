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
    public partial class QLLop : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLLop()
        {
            InitializeComponent();
        }

        private void QLLop_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaLH.Enabled = false;
                txtTenLH.Enabled = false;
                txtSoHS.Enabled = false;
                txtMaBan.Enabled = false;
                btnThemLop.Enabled = true;
                btnSuaLop.Enabled = true;
                btnXoaLop.Enabled = true;
                txtMaLH.Text = null;
                txtTenLH.Text = null;
                txtSoHS.Text = null;
                txtMaBan.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM Lop";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvLop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (btnThemLop.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaLH.Text = null;
                txtTenLH.Text = null;
                txtSoHS.Text = null;
                txtMaBan.Text = null;
                btnSuaLop.Enabled = false;
                btnXoaLop.Enabled = false;
                btnReload.Text = "Save";
                txtMaLH.Enabled = true;
                txtTenLH.Enabled = true;
                txtSoHS.Enabled = true;
                txtMaBan.Enabled = true;
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (btnSuaLop.Enabled == true)
            {
                k = 1;
                btnThemLop.Enabled = false;
                btnXoaLop.Enabled = false;
                btnReload.Text = "Save";
                txtTenLH.Enabled = true;
                txtSoHS.Enabled = true;
                txtMaBan.Enabled = true;
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (btnXoaLop.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null, "Bạn có chắc xóa lớp " + txtTenLH.Text + " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bool f = bl.MyExecuteNonQuery("Delete from Lop where MaLop=" + txtMaLH.Text, CommandType.Text, ref err);
                    if (f == true) MessageBox.Show("Đã xóa!");
                    else MessageBox.Show("Xóa lỗi! Lỗi " + err);
                    QLLop_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string err = null;
            if (k == 1)
            {
                bool f;
                if (t == 1) f = bl.MyExecuteNonQuery("insert into Lop values(" + txtMaLH.Text + ",'" + txtTenLH.Text + "','" + txtSoHS.Text + "','"+txtMaBan.Text +"')", CommandType.Text, ref err);
                else f = bl.MyExecuteNonQuery("Update Lop set TenLop='" + txtTenLH.Text + "',SoHocSinh='" + txtSoHS.Text + "',MaBan='" + txtMaBan.Text+"' where MaLop='" + txtMaLH.Text+"'", CommandType.Text, ref err);
                if (f == true)
                {
                    if (t == 1) MessageBox.Show("Thêm thành công!");
                    else MessageBox.Show("Sửa thành công!");
                    QLLop_Load(sender, e);
                }
                else
                {
                    if (t == 1) MessageBox.Show("Thêm lỗi! Lỗi " + err);
                    else MessageBox.Show("Sửa lỗi! Lỗi " + err);
                }
            }
            else
            {
                QLLop_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                QLLop_Load(sender, e);
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
            else if (cmbSearch.SelectedIndex == 2) s = 3;
            else if (cmbSearch.SelectedIndex == 3) s = 4;
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
                    string str = "SELECT * FROM Lop where MaLop like '%" + txtSearch.Text+"%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvLop.DataSource = dt;
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
                    string str = "SELECT * FROM Lop where TenLop like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvLop.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 3)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM Lop where SoHocSinh like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvLop.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 4)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM Lop where MaBan like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvLop.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvLop.RowCount)
            {
                txtMaLH.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
                txtTenLH.Text = dgvLop.Rows[r].Cells[1].Value.ToString();
                txtSoHS.Text = dgvLop.Rows[r].Cells[2].Value.ToString();
                txtMaBan.Text = dgvLop.Rows[r].Cells[3].Value.ToString();
            }
        }
    }
}
