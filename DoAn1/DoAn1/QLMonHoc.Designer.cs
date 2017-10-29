namespace DoAn1
{
    partial class QLMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdsMonHoc = new System.Windows.Forms.GroupBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.grpThongTinMH = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.grdsMonHoc.SuspendLayout();
            this.grpThongTinMH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(245, 124);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 30);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BackColor = System.Drawing.Color.Red;
            this.btnXoaMH.ForeColor = System.Drawing.Color.White;
            this.btnXoaMH.Location = new System.Drawing.Point(171, 124);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(63, 30);
            this.btnXoaMH.TabIndex = 14;
            this.btnXoaMH.Text = "Delete";
            this.btnXoaMH.UseVisualStyleBackColor = false;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuaMH.ForeColor = System.Drawing.Color.White;
            this.btnSuaMH.Location = new System.Drawing.Point(87, 124);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(75, 30);
            this.btnSuaMH.TabIndex = 13;
            this.btnSuaMH.Text = "Edit";
            this.btnSuaMH.UseVisualStyleBackColor = false;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemMH.ForeColor = System.Drawing.Color.White;
            this.btnThemMH.Location = new System.Drawing.Point(14, 124);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(66, 30);
            this.btnThemMH.TabIndex = 12;
            this.btnThemMH.Text = "Add";
            this.btnThemMH.UseVisualStyleBackColor = false;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(322, 124);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH});
            this.dgvMonHoc.Location = new System.Drawing.Point(26, 29);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(347, 162);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.FillWeight = 150F;
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 150;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.FillWeight = 150F;
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 150;
            // 
            // grdsMonHoc
            // 
            this.grdsMonHoc.Controls.Add(this.dgvMonHoc);
            this.grdsMonHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdsMonHoc.ForeColor = System.Drawing.Color.Blue;
            this.grdsMonHoc.Location = new System.Drawing.Point(6, 8);
            this.grdsMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.grdsMonHoc.Name = "grdsMonHoc";
            this.grdsMonHoc.Padding = new System.Windows.Forms.Padding(4);
            this.grdsMonHoc.Size = new System.Drawing.Size(398, 206);
            this.grdsMonHoc.TabIndex = 47;
            this.grdsMonHoc.TabStop = false;
            this.grdsMonHoc.Text = "Danh sách Môn Học";
            // 
            // txtTenMH
            // 
            this.txtTenMH.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenMH.Location = new System.Drawing.Point(131, 81);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(212, 25);
            this.txtTenMH.TabIndex = 7;
            // 
            // txtMaMH
            // 
            this.txtMaMH.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaMH.Location = new System.Drawing.Point(131, 38);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(212, 25);
            this.txtMaMH.TabIndex = 6;
            // 
            // lblMaMH
            // 
            this.lblMaMH.Location = new System.Drawing.Point(10, 41);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(114, 22);
            this.lblMaMH.TabIndex = 1;
            this.lblMaMH.Text = "Mã Môn Học:";
            // 
            // lblTenMH
            // 
            this.lblTenMH.Location = new System.Drawing.Point(10, 85);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(114, 22);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên Môn Học:";
            // 
            // grpThongTinMH
            // 
            this.grpThongTinMH.Controls.Add(this.btnBack);
            this.grpThongTinMH.Controls.Add(this.btnReload);
            this.grpThongTinMH.Controls.Add(this.btnXoaMH);
            this.grpThongTinMH.Controls.Add(this.btnSuaMH);
            this.grpThongTinMH.Controls.Add(this.btnThemMH);
            this.grpThongTinMH.Controls.Add(this.txtTenMH);
            this.grpThongTinMH.Controls.Add(this.txtMaMH);
            this.grpThongTinMH.Controls.Add(this.lblMaMH);
            this.grpThongTinMH.Controls.Add(this.lblTenMH);
            this.grpThongTinMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinMH.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTinMH.Location = new System.Drawing.Point(6, 217);
            this.grpThongTinMH.Name = "grpThongTinMH";
            this.grpThongTinMH.Size = new System.Drawing.Size(398, 166);
            this.grpThongTinMH.TabIndex = 48;
            this.grpThongTinMH.TabStop = false;
            this.grpThongTinMH.Text = "Thông tin Môn Học";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.Location = new System.Drawing.Point(128, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 26);
            this.txtSearch.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(6, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 63);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSearch.ForeColor = System.Drawing.Color.Navy;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Mã Môn Học",
            "Tên Môn Học"});
            this.cmbSearch.Location = new System.Drawing.Point(13, 23);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(100, 27);
            this.cmbSearch.TabIndex = 20;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(312, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 453);
            this.Controls.Add(this.grdsMonHoc);
            this.Controls.Add(this.grpThongTinMH);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QLMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLMonHoc";
            this.Load += new System.EventHandler(this.QLMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.grdsMonHoc.ResumeLayout(false);
            this.grpThongTinMH.ResumeLayout(false);
            this.grpThongTinMH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.GroupBox grdsMonHoc;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.GroupBox grpThongTinMH;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
    }
}