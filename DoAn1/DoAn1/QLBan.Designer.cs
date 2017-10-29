namespace DoAn1
{
    partial class QLBan
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
            this.grdsBan = new System.Windows.Forms.GroupBox();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinBan = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.lbltenBan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdsBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.grpThongTinBan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdsBan
            // 
            this.grdsBan.Controls.Add(this.dgvBan);
            this.grdsBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdsBan.ForeColor = System.Drawing.Color.Blue;
            this.grdsBan.Location = new System.Drawing.Point(6, 2);
            this.grdsBan.Margin = new System.Windows.Forms.Padding(4);
            this.grdsBan.Name = "grdsBan";
            this.grdsBan.Padding = new System.Windows.Forms.Padding(4);
            this.grdsBan.Size = new System.Drawing.Size(398, 206);
            this.grdsBan.TabIndex = 50;
            this.grdsBan.TabStop = false;
            this.grdsBan.Text = "Danh sách Ban";
            // 
            // dgvBan
            // 
            this.dgvBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.TenBan});
            this.dgvBan.Location = new System.Drawing.Point(26, 29);
            this.dgvBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(347, 162);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.FillWeight = 150F;
            this.MaBan.HeaderText = "Mã Ban";
            this.MaBan.Name = "MaBan";
            this.MaBan.Width = 150;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.FillWeight = 150F;
            this.TenBan.HeaderText = "Tên Ban";
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 150;
            // 
            // grpThongTinBan
            // 
            this.grpThongTinBan.Controls.Add(this.btnBack);
            this.grpThongTinBan.Controls.Add(this.btnReload);
            this.grpThongTinBan.Controls.Add(this.btnXoaBan);
            this.grpThongTinBan.Controls.Add(this.btnSuaBan);
            this.grpThongTinBan.Controls.Add(this.btnThemBan);
            this.grpThongTinBan.Controls.Add(this.txtTenBan);
            this.grpThongTinBan.Controls.Add(this.txtMaBan);
            this.grpThongTinBan.Controls.Add(this.lblMaBan);
            this.grpThongTinBan.Controls.Add(this.lbltenBan);
            this.grpThongTinBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinBan.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTinBan.Location = new System.Drawing.Point(6, 211);
            this.grpThongTinBan.Name = "grpThongTinBan";
            this.grpThongTinBan.Size = new System.Drawing.Size(398, 166);
            this.grpThongTinBan.TabIndex = 51;
            this.grpThongTinBan.TabStop = false;
            this.grpThongTinBan.Text = "Thông tin Ban";
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
            // btnXoaBan
            // 
            this.btnXoaBan.BackColor = System.Drawing.Color.Red;
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.Location = new System.Drawing.Point(171, 124);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(63, 30);
            this.btnXoaBan.TabIndex = 14;
            this.btnXoaBan.Text = "Delete";
            this.btnXoaBan.UseVisualStyleBackColor = false;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuaBan.ForeColor = System.Drawing.Color.White;
            this.btnSuaBan.Location = new System.Drawing.Point(87, 124);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(75, 30);
            this.btnSuaBan.TabIndex = 13;
            this.btnSuaBan.Text = "Edit";
            this.btnSuaBan.UseVisualStyleBackColor = false;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.Location = new System.Drawing.Point(14, 124);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(66, 30);
            this.btnThemBan.TabIndex = 12;
            this.btnThemBan.Text = "Add";
            this.btnThemBan.UseVisualStyleBackColor = false;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenBan.Location = new System.Drawing.Point(131, 81);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(212, 25);
            this.txtTenBan.TabIndex = 7;
            // 
            // txtMaBan
            // 
            this.txtMaBan.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaBan.Location = new System.Drawing.Point(131, 38);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(212, 25);
            this.txtMaBan.TabIndex = 6;
            // 
            // lblMaBan
            // 
            this.lblMaBan.Location = new System.Drawing.Point(10, 41);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(114, 22);
            this.lblMaBan.TabIndex = 1;
            this.lblMaBan.Text = "Mã Ban:";
            // 
            // lbltenBan
            // 
            this.lbltenBan.Location = new System.Drawing.Point(10, 85);
            this.lbltenBan.Name = "lbltenBan";
            this.lbltenBan.Size = new System.Drawing.Size(114, 22);
            this.lbltenBan.TabIndex = 0;
            this.lbltenBan.Text = "Tên Ban:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(6, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 63);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSearch.ForeColor = System.Drawing.Color.Navy;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Mã Ban",
            "Tên Ban"});
            this.cmbSearch.Location = new System.Drawing.Point(13, 23);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(100, 27);
            this.cmbSearch.TabIndex = 20;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
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
            // QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 449);
            this.Controls.Add(this.grdsBan);
            this.Controls.Add(this.grpThongTinBan);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBan";
            this.Load += new System.EventHandler(this.QLBan_Load);
            this.grdsBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.grpThongTinBan.ResumeLayout(false);
            this.grpThongTinBan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdsBan;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.GroupBox grpThongTinBan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.Label lbltenBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
    }
}