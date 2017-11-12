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
using System.Data.Entity;
namespace DoAn1
{
    public partial class QLMonHoc : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLMonHoc()
        {
            InitializeComponent();
        }

        private void QLMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Enabled = false;
                txtTenMH.Enabled = false;
                btnThemMH.Enabled = true;
                btnSuaMH.Enabled = true;
                btnXoaMH.Enabled = true;
                txtMaMH.Text = null;
                txtTenMH.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM MonHoc";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvMonHoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (btnThemMH.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaMH.Text = null;
                txtTenMH.Text = null;
                btnSuaMH.Enabled = false;
                btnXoaMH.Enabled = false;
                btnReload.Text = "Save";
                txtMaMH.Enabled = true;
                txtTenMH.Enabled = true;
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (btnSuaMH.Enabled == true)
            {
                k = 1;
                btnThemMH.Enabled = false;
                btnXoaMH.Enabled = false;
                btnReload.Text = "Save";
                txtTenMH.Enabled = true;
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (btnXoaMH.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null, "Bạn có chắc xóa môn " + txtTenMH.Text + " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        XepThoiKhoaBieuEntities et = new XepThoiKhoaBieuEntities();
                        MonHoc mh = new MonHoc();
                        mh.MaMH = Int32.Parse(txtMaMH.Text);
                        et.Entry(mh).State = EntityState.Deleted;
                        et.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message);
                    }
                    QLMonHoc_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                try
                {
                    if (t == 1)
                    {
                        XepThoiKhoaBieuEntities et = new XepThoiKhoaBieuEntities();
                        MonHoc mh = new MonHoc();
                        mh.MaMH = Int32.Parse(txtMaMH.Text);
                        mh.TenMH = txtTenMH.Text;
                        et.Entry(mh).State = EntityState.Added;
                        et.SaveChanges();
                    }
                    else
                    {
                        XepThoiKhoaBieuEntities et = new XepThoiKhoaBieuEntities();
                        MonHoc mh = new MonHoc();
                        mh.MaMH = Int32.Parse(txtMaMH.Text);
                        mh.TenMH = txtTenMH.Text;
                        et.Entry(mh).State = EntityState.Modified;
                        et.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                QLMonHoc_Load(sender, e);
            }
            else
            {
                QLMonHoc_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                QLMonHoc_Load(sender, e);
            }
            else
            {
                this.Dispose();
                frmTongQuanLy tql = new frmTongQuanLy();
                tql.ShowDialog();
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMonHoc.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvMonHoc.RowCount)
            {
                txtMaMH.Text = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                txtTenMH.Text = dgvMonHoc.Rows[r].Cells[1].Value.ToString();
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
                    string str = "SELECT * FROM MonHoc where MaMH like '%" + txtSearch.Text+"%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvMonHoc.DataSource = dt;
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
                    string str = "SELECT * FROM MonHoc where TenMH like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvMonHoc.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Up|e.KeyData==Keys.Down)
            {
                int r = dgvMonHoc.CurrentCell.RowIndex;
                if (r >= 0 && r < dgvMonHoc.RowCount)
                {
                    txtMaMH.Text = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                    txtTenMH.Text = dgvMonHoc.Rows[r].Cells[1].Value.ToString();
                }
            }
        }
    }
}
