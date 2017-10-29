﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
namespace DoAn1
{
    public partial class QLBan : Form
    {
        BALayer bl = new BALayer();
        int k = 0;
        int t = 0;
        int s = 0;
        public QLBan()
        {
            InitializeComponent();
        }

        private void QLBan_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaBan.Enabled = false;
                txtTenBan.Enabled = false;
                btnThemBan.Enabled = true;
                btnSuaBan.Enabled = true;
                btnXoaBan.Enabled = true;
                txtMaBan.Text = null;
                txtTenBan.Text = null;
                btnReload.Text = "Reload";
                k = 0;
                t = 0;
                s = 0;
                DataTable dt = new DataTable();
                string str = "SELECT * FROM Ban";
                CommandType ct = CommandType.Text;
                dt = bl.ExecuteQueryDataSet(str, ct);
                dgvBan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (btnThemBan.Enabled == true)
            {
                k = 1;
                t = 1;
                txtMaBan.Text = null;
                txtTenBan.Text = null;
                btnSuaBan.Enabled = false;
                btnXoaBan.Enabled = false;
                btnReload.Text = "Save";
                txtMaBan.Enabled = true;
                txtTenBan.Enabled = true;
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if(btnSuaBan.Enabled==true)
            {
                k = 1;
                btnThemBan.Enabled = false;
                btnXoaBan.Enabled = false;
                btnReload.Text = "Save";
                txtTenBan.Enabled = true;
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (btnXoaBan.Enabled == true)
            {
                string err = null;
                DialogResult r = MessageBox.Show(null,"Bạn có chắc xóa ban " +txtTenBan.Text+ " không!", "Cân nhắc", MessageBoxButtons.YesNo);
                if(r==DialogResult.Yes)
                {
                    bool f = bl.MyExecuteNonQuery("Delete from Ban where MaBan=" + txtMaBan.Text, CommandType.Text,ref err);
                    if (f == true) MessageBox.Show("Đã xóa!");
                    else MessageBox.Show("Xóa lỗi! Lỗi "+err);
                    QLBan_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string err = null;
            if (k==1)
            {
                bool f;
                if (t==1) f = bl.MyExecuteNonQuery("insert into Ban values('" + txtMaBan.Text +"','"+txtTenBan.Text+"')", CommandType.Text, ref err);
                else f = bl.MyExecuteNonQuery("Update Ban set TenBan='"+txtTenBan.Text+"' where MaBan=" + txtMaBan.Text , CommandType.Text, ref err);
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
                QLBan_Load(sender, e);
            }
            else
            {
                QLBan_Load(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(k==1)
            {
                QLBan_Load(sender, e);
            }
            else
            {
                this.Dispose();
                frmTongQuanLy tql = new frmTongQuanLy();
                tql.ShowDialog();
            }
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBan.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvBan.RowCount)
            {
                txtMaBan.Text = dgvBan.Rows[r].Cells[0].Value.ToString();
                txtTenBan.Text = dgvBan.Rows[r].Cells[1].Value.ToString();
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
            else if(s==1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM Ban where MaBan="+txtSearch.Text;
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvBan.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (s==2)
            {

                try
                {
                    DataTable dt = new DataTable();
                    string str = "SELECT * FROM Ban where TenBan like '%"+txtSearch.Text+"%'";
                    CommandType ct = CommandType.Text;
                    dt = bl.ExecuteQueryDataSet(str, ct);
                    dgvBan.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
    }
}
