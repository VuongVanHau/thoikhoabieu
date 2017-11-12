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
    public partial class QLGiaoVien : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (btnThemGV.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaGV.Text = null;
                txtTenGV.Text = null;
                txtGioiTinh.Text = null;
                txtSDT.Text = null;
                txtChucVu.Text = null;
                txtEmail.Text = null;
                txtMaBM.Text = null;
                btnSuaGV.Enabled = false;
                btnXoaGV.Enabled = false;
                btnReload.Text = "Save";
                txtMaGV.Enabled = true;
                txtTenGV.Enabled = true;
                txtGioiTinh.Enabled = true;
                txtSDT.Enabled = true;
                txtChucVu.Enabled = true;
                txtEmail.Enabled = true;
                txtMaBM.Enabled = true;
            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (btnSuaGV.Enabled == true)
            {
                k = 1;
                btnThemGV.Enabled = false;
                btnXoaGV.Enabled = false;
                btnReload.Text = "Save";
                txtTenGV.Enabled = true;
                txtGioiTinh.Enabled = true;
                txtSDT.Enabled = true;
                txtChucVu.Enabled = true;
                txtEmail.Enabled = true;
                txtMaBM.Enabled = true;
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (btnXoaGV.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null, "Bạn có chắc xóa giáo viên " + txtTenGV.Text + " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        XepThoiKhoaBieuEntities et = new XepThoiKhoaBieuEntities();
                        GiaoVien gv = new GiaoVien();
                        gv.MaGV = Int32.Parse(txtMaGV.Text);
                        gv.TenGV = txtTenGV.Text;
                        et.Entry(gv).State = EntityState.Deleted;
                        et.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        QLGiaoVien_Load(sender, e);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex.Message);
                    }
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
                        GiaoVien gv = new GiaoVien();
                        gv.MaGV = Int32.Parse(txtMaGV.Text);
                        gv.TenGV = txtTenGV.Text;
                        gv.GioiTinh = txtGioiTinh.Text;
                        gv.SDT = txtSDT.Text;
                        gv.ChucVu = txtChucVu.Text;
                        gv.Email = txtEmail.Text;
                        gv.MaBM = Int32.Parse(txtMaBM.Text);
                        et.Entry(gv).State = EntityState.Added;
                        et.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        XepThoiKhoaBieuEntities et = new XepThoiKhoaBieuEntities();
                        GiaoVien gv = new GiaoVien();
                        gv.MaGV = Int32.Parse(txtMaGV.Text);
                        gv.TenGV = txtTenGV.Text;
                        gv.GioiTinh = txtGioiTinh.Text;
                        gv.SDT = txtSDT.Text;
                        gv.ChucVu = txtChucVu.Text;
                        gv.Email = txtEmail.Text;
                        gv.MaBM = Int32.Parse(txtMaBM.Text);
                        et.Entry(gv).State = EntityState.Modified;
                        et.SaveChanges();
                        MessageBox.Show("Sửa thành công!");
                    }
                    QLGiaoVien_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                
            }
            else
            {
                QLGiaoVien_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                QLGiaoVien_Load(sender, e);
            }
            else
            {
                this.Dispose();
                frmTongQuanLy tql = new frmTongQuanLy();
                tql.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (s == 0) MessageBox.Show("Chọn đơn vị tìm kiếm");
            else if (s == 1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM GiaoVien where MaGV like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
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
                    string str = "SELECT * FROM GiaoVien where TenGV like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
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
                    string str = "SELECT * FROM GiaoVien where GioiTinh like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
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
                    string str = "SELECT * FROM GiaoVien where SDT like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 5)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM GiaoVien where ChucVu like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 6)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM GiaoVien where Email like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s == 7)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM GiaoVien where MaBM like '%" + txtSearch.Text + "%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvGiaoVien.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void QLGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaGV.Enabled = false;
                txtTenGV.Enabled = false;
                txtGioiTinh.Enabled = false;
                txtSDT.Enabled = false;
                txtChucVu.Enabled = false;
                txtEmail.Enabled = false;
                txtMaBM.Enabled = false;
                btnThemGV.Enabled = true;
                btnSuaGV.Enabled = true;
                btnXoaGV.Enabled = true;
                txtMaGV.Text = null;
                txtTenGV.Text = null;
                txtGioiTinh.Text = null;
                txtSDT.Text = null;
                txtChucVu.Text = null;
                txtEmail.Text = null;
                txtMaBM.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM GiaoVien";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvGiaoVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0) s = 1;
            else if (cmbSearch.SelectedIndex == 1) s = 2;
            else if (cmbSearch.SelectedIndex == 2) s = 3;
            else if (cmbSearch.SelectedIndex == 3) s = 4;
            else if (cmbSearch.SelectedIndex == 4) s = 5;
            else if (cmbSearch.SelectedIndex == 5) s = 6;
            else if (cmbSearch.SelectedIndex == 6) s = 7;
            else s = 0;
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGiaoVien.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvGiaoVien.RowCount)
            {
                txtMaGV.Text = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
                txtTenGV.Text = dgvGiaoVien.Rows[r].Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvGiaoVien.Rows[r].Cells[2].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[r].Cells[3].Value.ToString();
                txtChucVu.Text = dgvGiaoVien.Rows[r].Cells[4].Value.ToString();
                txtEmail.Text = dgvGiaoVien.Rows[r].Cells[5].Value.ToString();
                txtMaBM.Text = dgvGiaoVien.Rows[r].Cells[6].Value.ToString();
            }
        }

        private void dgvGiaoVien_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Up|e.KeyData==Keys.Down)
            {
                int r = dgvGiaoVien.CurrentCell.RowIndex;
                if (r >= 0 && r < dgvGiaoVien.RowCount)
                {
                    txtMaGV.Text = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
                    txtTenGV.Text = dgvGiaoVien.Rows[r].Cells[1].Value.ToString();
                    txtGioiTinh.Text = dgvGiaoVien.Rows[r].Cells[2].Value.ToString();
                    txtSDT.Text = dgvGiaoVien.Rows[r].Cells[3].Value.ToString();
                    txtChucVu.Text = dgvGiaoVien.Rows[r].Cells[4].Value.ToString();
                    txtEmail.Text = dgvGiaoVien.Rows[r].Cells[5].Value.ToString();
                    txtMaBM.Text = dgvGiaoVien.Rows[r].Cells[6].Value.ToString();
                }
            }
        }
    }
}
