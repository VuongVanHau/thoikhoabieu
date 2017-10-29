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
    public partial class QLPhongHoc : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLPhongHoc()
        {
            InitializeComponent();
        }

        private void QLPhongHoc_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaPH.Enabled = false;
                txtTenPH.Enabled = false;
                txtDungLuong.Enabled = false;
                btnThemPH.Enabled = true;
                btnSuaPH.Enabled = true;
                btnXoaPH.Enabled = true;
                txtMaPH.Text = null;
                txtTenPH.Text = null;
                txtDungLuong.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM PhongHoc";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvPhongHoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThemPH_Click(object sender, EventArgs e)
        {

            if (btnThemPH.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaPH.Text = null;
                txtTenPH.Text = null;
                txtDungLuong.Text = null;
                btnSuaPH.Enabled = false;
                btnXoaPH.Enabled = false;
                btnReload.Text = "Save";
                txtMaPH.Enabled = true;
                txtTenPH.Enabled = true;
                txtDungLuong.Enabled = true;
            }
        }

        private void btnSuaPH_Click(object sender, EventArgs e)
        {
            if (btnSuaPH.Enabled == true)
            {
                k = 1;
                btnThemPH.Enabled = false;
                btnXoaPH.Enabled = false;
                btnReload.Text = "Save";
                txtTenPH.Enabled = true;
                txtDungLuong.Enabled = true;
            }
        }

        private void btnXoaPH_Click(object sender, EventArgs e)
        {
            if (btnXoaPH.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null, "Bạn có chắc xóa phòng " + txtTenPH.Text + " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bool f = bl.MyExecuteNonQuery("Delete from PhongHoc where MaPH=" + txtMaPH.Text, CommandType.Text, ref err);
                    if (f == true) MessageBox.Show("Đã xóa!");
                    else MessageBox.Show("Xóa lỗi! Lỗi " + err);
                    QLPhongHoc_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string err = null;
            if (k == 1)
            {
                bool f;
                if (t == 1) f = bl.MyExecuteNonQuery("insert into PhongHoc values('" + txtMaPH.Text + "','" + txtTenPH.Text + "','" + txtDungLuong.Text + "')", CommandType.Text, ref err);
                else f = bl.MyExecuteNonQuery("Update PhongHoc set TenPh='" + txtTenPH.Text + "',DungLuong='" + txtDungLuong.Text+ "' where MaPH=" + txtMaPH.Text, CommandType.Text, ref err);
                if (f == true)
                {
                    if (t == 1) MessageBox.Show("Thêm thành công!");
                    else MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    if (t == 1) MessageBox.Show("Thêm lỗi! Lỗi " + err);
                    else MessageBox.Show("Sửa lỗi! Lỗi " + err);
                }
                QLPhongHoc_Load(sender, e);
            }
            else
            {
                QLPhongHoc_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                QLPhongHoc_Load(sender, e);
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
                    string str = "SELECT * FROM PhongHoc where MaPH like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvPhongHoc.DataSource = dt;
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
                    string str = "SELECT * FROM PhongHoc where TenPH like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvPhongHoc.DataSource = dt;
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
                    string str = "SELECT * FROM PhongHoc where DungLuong like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvPhongHoc.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhongHoc.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvPhongHoc.RowCount)
            {
                txtMaPH.Text = dgvPhongHoc.Rows[r].Cells[0].Value.ToString();
                txtTenPH.Text = dgvPhongHoc.Rows[r].Cells[1].Value.ToString();
                txtDungLuong.Text=dgvPhongHoc.Rows[r].Cells[2].Value.ToString();
            }
        }
    }
}
