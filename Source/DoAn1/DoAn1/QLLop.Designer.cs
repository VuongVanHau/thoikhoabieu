namespace DoAn1
{
    partial class QLLop
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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSoHS = new System.Windows.Forms.Label();
            this.lblMaLopHoc = new System.Windows.Forms.Label();
            this.lbltenLH = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.grdsLopHoc = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.grpThongTinPH = new System.Windows.Forms.GroupBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSoHS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grdsLopHoc.SuspendLayout();
            this.grpThongTinPH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SoHocSinh,
            this.MaBan});
            this.dgvLop.Location = new System.Drawing.Point(12, 29);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(546, 162);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            this.dgvLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLop_KeyDown);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.FillWeight = 150F;
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 150;
            // 
            // SoHocSinh
            // 
            this.SoHocSinh.DataPropertyName = "SoHocSinh";
            this.SoHocSinh.FillWeight = 150F;
            this.SoHocSinh.HeaderText = "Số Học Sinh";
            this.SoHocSinh.Name = "SoHocSinh";
            this.SoHocSinh.Width = 150;
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.HeaderText = "Mã Ban";
            this.MaBan.Name = "MaBan";
            // 
            // lblSoHS
            // 
            this.lblSoHS.Location = new System.Drawing.Point(103, 105);
            this.lblSoHS.Name = "lblSoHS";
            this.lblSoHS.Size = new System.Drawing.Size(119, 22);
            this.lblSoHS.TabIndex = 2;
            this.lblSoHS.Text = "Số Học Sinh:";
            // 
            // lblMaLopHoc
            // 
            this.lblMaLopHoc.Location = new System.Drawing.Point(105, 33);
            this.lblMaLopHoc.Name = "lblMaLopHoc";
            this.lblMaLopHoc.Size = new System.Drawing.Size(119, 22);
            this.lblMaLopHoc.TabIndex = 1;
            this.lblMaLopHoc.Text = "Mã Lớp Học:";
            // 
            // lbltenLH
            // 
            this.lbltenLH.Location = new System.Drawing.Point(102, 69);
            this.lbltenLH.Name = "lbltenLH";
            this.lbltenLH.Size = new System.Drawing.Size(119, 22);
            this.lbltenLH.TabIndex = 0;
            this.lbltenLH.Text = "Tên Lớp Học:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.Location = new System.Drawing.Point(197, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 26);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(419, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(13, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 63);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSearch.ForeColor = System.Drawing.Color.Navy;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Mã Lớp",
            "Tên Lớp",
            "Số Học Sinh",
            "Mã Ban"});
            this.cmbSearch.Location = new System.Drawing.Point(46, 23);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 27);
            this.cmbSearch.TabIndex = 20;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.Red;
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(267, 177);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(63, 30);
            this.btnXoaLop.TabIndex = 14;
            this.btnXoaLop.Text = "Delete";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(158, 177);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(75, 30);
            this.btnSuaLop.TabIndex = 13;
            this.btnSuaLop.Text = "Edit";
            this.btnSuaLop.UseVisualStyleBackColor = false;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(59, 177);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(66, 30);
            this.btnThemLop.TabIndex = 12;
            this.btnThemLop.Text = "Add";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTenLH
            // 
            this.txtTenLH.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenLH.Location = new System.Drawing.Point(240, 68);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(231, 25);
            this.txtTenLH.TabIndex = 7;
            // 
            // txtMaLH
            // 
            this.txtMaLH.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaLH.Location = new System.Drawing.Point(240, 31);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(231, 25);
            this.txtMaLH.TabIndex = 6;
            // 
            // grdsLopHoc
            // 
            this.grdsLopHoc.Controls.Add(this.dgvLop);
            this.grdsLopHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdsLopHoc.ForeColor = System.Drawing.Color.Blue;
            this.grdsLopHoc.Location = new System.Drawing.Point(13, 13);
            this.grdsLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.grdsLopHoc.Name = "grdsLopHoc";
            this.grdsLopHoc.Padding = new System.Windows.Forms.Padding(4);
            this.grdsLopHoc.Size = new System.Drawing.Size(569, 206);
            this.grdsLopHoc.TabIndex = 53;
            this.grdsLopHoc.TabStop = false;
            this.grdsLopHoc.Text = "Danh sách Lớp Học";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(363, 177);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 30);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // grpThongTinPH
            // 
            this.grpThongTinPH.Controls.Add(this.txtMaBan);
            this.grpThongTinPH.Controls.Add(this.lblMaBan);
            this.grpThongTinPH.Controls.Add(this.btnBack);
            this.grpThongTinPH.Controls.Add(this.btnReload);
            this.grpThongTinPH.Controls.Add(this.btnXoaLop);
            this.grpThongTinPH.Controls.Add(this.btnSuaLop);
            this.grpThongTinPH.Controls.Add(this.btnThemLop);
            this.grpThongTinPH.Controls.Add(this.txtSoHS);
            this.grpThongTinPH.Controls.Add(this.txtTenLH);
            this.grpThongTinPH.Controls.Add(this.txtMaLH);
            this.grpThongTinPH.Controls.Add(this.lblSoHS);
            this.grpThongTinPH.Controls.Add(this.lblMaLopHoc);
            this.grpThongTinPH.Controls.Add(this.lbltenLH);
            this.grpThongTinPH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinPH.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTinPH.Location = new System.Drawing.Point(13, 218);
            this.grpThongTinPH.Name = "grpThongTinPH";
            this.grpThongTinPH.Size = new System.Drawing.Size(569, 214);
            this.grpThongTinPH.TabIndex = 54;
            this.grpThongTinPH.TabStop = false;
            this.grpThongTinPH.Text = "Thông tin Lớp Học";
            // 
            // txtMaBan
            // 
            this.txtMaBan.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaBan.Location = new System.Drawing.Point(240, 138);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(231, 25);
            this.txtMaBan.TabIndex = 20;
            // 
            // lblMaBan
            // 
            this.lblMaBan.Location = new System.Drawing.Point(104, 139);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(119, 22);
            this.lblMaBan.TabIndex = 19;
            this.lblMaBan.Text = "Mã Ban:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(457, 177);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSoHS
            // 
            this.txtSoHS.ForeColor = System.Drawing.Color.Maroon;
            this.txtSoHS.Location = new System.Drawing.Point(240, 104);
            this.txtSoHS.Name = "txtSoHS";
            this.txtSoHS.Size = new System.Drawing.Size(231, 25);
            this.txtSoHS.TabIndex = 8;
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 505);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdsLopHoc);
            this.Controls.Add(this.grpThongTinPH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QLLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grdsLopHoc.ResumeLayout(false);
            this.grpThongTinPH.ResumeLayout(false);
            this.grpThongTinPH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lblSoHS;
        private System.Windows.Forms.Label lblMaLopHoc;
        private System.Windows.Forms.Label lbltenLH;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.GroupBox grdsLopHoc;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox grpThongTinPH;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSoHS;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
    }
}