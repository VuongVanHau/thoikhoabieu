namespace DoAn1
{
    partial class QLGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.grpThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtMaBM = new System.Windows.Forms.TextBox();
            this.lblMaBM = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdsGiaoVien = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grpThongTinNV.SuspendLayout();
            this.grdsGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSearch.ForeColor = System.Drawing.Color.Navy;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Mã GV",
            "Tên GV",
            "Giới Tính",
            "SĐT",
            "Chức vụ",
            "Email",
            "Mã BM"});
            this.cmbSearch.Location = new System.Drawing.Point(130, 24);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 27);
            this.cmbSearch.TabIndex = 20;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(576, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 63);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.Location = new System.Drawing.Point(280, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 26);
            this.txtSearch.TabIndex = 19;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(488, 168);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(96, 30);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.Red;
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.Location = new System.Drawing.Point(372, 168);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(96, 30);
            this.btnXoaGV.TabIndex = 14;
            this.btnXoaGV.Text = "Delete";
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuaGV.ForeColor = System.Drawing.Color.White;
            this.btnSuaGV.Location = new System.Drawing.Point(256, 168);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(96, 30);
            this.btnSuaGV.TabIndex = 13;
            this.btnSuaGV.Text = "Edit";
            this.btnSuaGV.UseVisualStyleBackColor = false;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemGV.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.Location = new System.Drawing.Point(145, 168);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(96, 30);
            this.btnThemGV.TabIndex = 12;
            this.btnThemGV.Text = "Add";
            this.btnThemGV.UseVisualStyleBackColor = false;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // grpThongTinNV
            // 
            this.grpThongTinNV.Controls.Add(this.txtMaBM);
            this.grpThongTinNV.Controls.Add(this.lblMaBM);
            this.grpThongTinNV.Controls.Add(this.btnBack);
            this.grpThongTinNV.Controls.Add(this.btnReload);
            this.grpThongTinNV.Controls.Add(this.btnXoaGV);
            this.grpThongTinNV.Controls.Add(this.btnSuaGV);
            this.grpThongTinNV.Controls.Add(this.btnThemGV);
            this.grpThongTinNV.Controls.Add(this.txtEmail);
            this.grpThongTinNV.Controls.Add(this.txtChucVu);
            this.grpThongTinNV.Controls.Add(this.txtSDT);
            this.grpThongTinNV.Controls.Add(this.txtGioiTinh);
            this.grpThongTinNV.Controls.Add(this.txtTenGV);
            this.grpThongTinNV.Controls.Add(this.txtMaGV);
            this.grpThongTinNV.Controls.Add(this.label6);
            this.grpThongTinNV.Controls.Add(this.label5);
            this.grpThongTinNV.Controls.Add(this.label4);
            this.grpThongTinNV.Controls.Add(this.label3);
            this.grpThongTinNV.Controls.Add(this.label2);
            this.grpThongTinNV.Controls.Add(this.label1);
            this.grpThongTinNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinNV.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTinNV.Location = new System.Drawing.Point(7, 221);
            this.grpThongTinNV.Name = "grpThongTinNV";
            this.grpThongTinNV.Size = new System.Drawing.Size(821, 209);
            this.grpThongTinNV.TabIndex = 45;
            this.grpThongTinNV.TabStop = false;
            this.grpThongTinNV.Text = "Thông tin Giáo viên";
            // 
            // txtMaBM
            // 
            this.txtMaBM.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaBM.Location = new System.Drawing.Point(551, 135);
            this.txtMaBM.Name = "txtMaBM";
            this.txtMaBM.Size = new System.Drawing.Size(238, 25);
            this.txtMaBM.TabIndex = 20;
            // 
            // lblMaBM
            // 
            this.lblMaBM.Location = new System.Drawing.Point(422, 138);
            this.lblMaBM.Name = "lblMaBM";
            this.lblMaBM.Size = new System.Drawing.Size(131, 22);
            this.lblMaBM.TabIndex = 19;
            this.lblMaBM.Text = "Mã Bộ Môn:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(605, 168);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Maroon;
            this.txtEmail.Location = new System.Drawing.Point(551, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 25);
            this.txtEmail.TabIndex = 11;
            // 
            // txtChucVu
            // 
            this.txtChucVu.ForeColor = System.Drawing.Color.Maroon;
            this.txtChucVu.Location = new System.Drawing.Point(551, 60);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(238, 25);
            this.txtChucVu.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.ForeColor = System.Drawing.Color.Maroon;
            this.txtSDT.Location = new System.Drawing.Point(551, 21);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(238, 25);
            this.txtSDT.TabIndex = 9;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.ForeColor = System.Drawing.Color.Maroon;
            this.txtGioiTinh.Location = new System.Drawing.Point(156, 122);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(212, 25);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // txtTenGV
            // 
            this.txtTenGV.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenGV.Location = new System.Drawing.Point(156, 82);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(212, 25);
            this.txtTenGV.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaGV.Location = new System.Drawing.Point(156, 39);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(212, 25);
            this.txtMaGV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(422, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(422, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức Vụ:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(422, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giáo viên:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Giáo viên:";
            // 
            // grdsGiaoVien
            // 
            this.grdsGiaoVien.Controls.Add(this.dgvGiaoVien);
            this.grdsGiaoVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdsGiaoVien.ForeColor = System.Drawing.Color.Blue;
            this.grdsGiaoVien.Location = new System.Drawing.Point(7, 6);
            this.grdsGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.grdsGiaoVien.Name = "grdsGiaoVien";
            this.grdsGiaoVien.Padding = new System.Windows.Forms.Padding(4);
            this.grdsGiaoVien.Size = new System.Drawing.Size(821, 206);
            this.grdsGiaoVien.TabIndex = 43;
            this.grdsGiaoVien.TabStop = false;
            this.grdsGiaoVien.Text = "Danh sách Giáo viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.GioiTinh,
            this.SDT,
            this.ChucVu,
            this.Email,
            this.MaBM});
            this.dgvGiaoVien.Location = new System.Drawing.Point(12, 29);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(797, 162);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaGV.FillWeight = 80F;
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 80;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenGV.FillWeight = 150F;
            this.TenGV.HeaderText = "Tên GV";
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GioiTinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 90;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SDT.DefaultCellStyle = dataGridViewCellStyle4;
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ChucVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.ChucVu.FillWeight = 90F;
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 90;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Email.DefaultCellStyle = dataGridViewCellStyle6;
            this.Email.FillWeight = 140F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 140;
            // 
            // MaBM
            // 
            this.MaBM.DataPropertyName = "MaBM";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaBM.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaBM.HeaderText = "Mã BM";
            this.MaBM.Name = "MaBM";
            // 
            // QLGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpThongTinNV);
            this.Controls.Add(this.grdsGiaoVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLGiaoVien";
            this.Load += new System.EventHandler(this.QLGiaoVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpThongTinNV.ResumeLayout(false);
            this.grpThongTinNV.PerformLayout();
            this.grdsGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.GroupBox grpThongTinNV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grdsGiaoVien;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.TextBox txtMaBM;
        private System.Windows.Forms.Label lblMaBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBM;
    }
}