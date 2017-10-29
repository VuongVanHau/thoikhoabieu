namespace DoAn1
{
    partial class QLBoMon
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
            this.grdsBoMon = new System.Windows.Forms.GroupBox();
            this.dgvBoMon = new System.Windows.Forms.DataGridView();
            this.MaBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinBM = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoaBM = new System.Windows.Forms.Button();
            this.btnSuaBM = new System.Windows.Forms.Button();
            this.btnThemBM = new System.Windows.Forms.Button();
            this.txtTenBM = new System.Windows.Forms.TextBox();
            this.txtMaBM = new System.Windows.Forms.TextBox();
            this.lblMaBM = new System.Windows.Forms.Label();
            this.lblTenBM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdsBoMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).BeginInit();
            this.grpThongTinBM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdsBoMon
            // 
            this.grdsBoMon.Controls.Add(this.dgvBoMon);
            this.grdsBoMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdsBoMon.ForeColor = System.Drawing.Color.Blue;
            this.grdsBoMon.Location = new System.Drawing.Point(13, 13);
            this.grdsBoMon.Margin = new System.Windows.Forms.Padding(4);
            this.grdsBoMon.Name = "grdsBoMon";
            this.grdsBoMon.Padding = new System.Windows.Forms.Padding(4);
            this.grdsBoMon.Size = new System.Drawing.Size(398, 206);
            this.grdsBoMon.TabIndex = 50;
            this.grdsBoMon.TabStop = false;
            this.grdsBoMon.Text = "Danh sách Bộ Môn";
            // 
            // dgvBoMon
            // 
            this.dgvBoMon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBM,
            this.TenBM});
            this.dgvBoMon.Location = new System.Drawing.Point(26, 29);
            this.dgvBoMon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBoMon.Name = "dgvBoMon";
            this.dgvBoMon.Size = new System.Drawing.Size(347, 162);
            this.dgvBoMon.TabIndex = 0;
            this.dgvBoMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_CellClick);
            // 
            // MaBM
            // 
            this.MaBM.DataPropertyName = "MaBM";
            this.MaBM.FillWeight = 150F;
            this.MaBM.HeaderText = "Mã Bộ Môn";
            this.MaBM.Name = "MaBM";
            this.MaBM.Width = 150;
            // 
            // TenBM
            // 
            this.TenBM.DataPropertyName = "TenBM";
            this.TenBM.FillWeight = 150F;
            this.TenBM.HeaderText = "Tên Bộ Môn";
            this.TenBM.Name = "TenBM";
            this.TenBM.Width = 150;
            // 
            // grpThongTinBM
            // 
            this.grpThongTinBM.Controls.Add(this.btnBack);
            this.grpThongTinBM.Controls.Add(this.btnReload);
            this.grpThongTinBM.Controls.Add(this.btnXoaBM);
            this.grpThongTinBM.Controls.Add(this.btnSuaBM);
            this.grpThongTinBM.Controls.Add(this.btnThemBM);
            this.grpThongTinBM.Controls.Add(this.txtTenBM);
            this.grpThongTinBM.Controls.Add(this.txtMaBM);
            this.grpThongTinBM.Controls.Add(this.lblMaBM);
            this.grpThongTinBM.Controls.Add(this.lblTenBM);
            this.grpThongTinBM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinBM.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTinBM.Location = new System.Drawing.Point(13, 222);
            this.grpThongTinBM.Name = "grpThongTinBM";
            this.grpThongTinBM.Size = new System.Drawing.Size(398, 166);
            this.grpThongTinBM.TabIndex = 51;
            this.grpThongTinBM.TabStop = false;
            this.grpThongTinBM.Text = "Thông tin Bộ Môn";
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
            // btnXoaBM
            // 
            this.btnXoaBM.BackColor = System.Drawing.Color.Red;
            this.btnXoaBM.ForeColor = System.Drawing.Color.White;
            this.btnXoaBM.Location = new System.Drawing.Point(171, 124);
            this.btnXoaBM.Name = "btnXoaBM";
            this.btnXoaBM.Size = new System.Drawing.Size(63, 30);
            this.btnXoaBM.TabIndex = 14;
            this.btnXoaBM.Text = "Delete";
            this.btnXoaBM.UseVisualStyleBackColor = false;
            this.btnXoaBM.Click += new System.EventHandler(this.btnXoaBM_Click);
            // 
            // btnSuaBM
            // 
            this.btnSuaBM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuaBM.ForeColor = System.Drawing.Color.White;
            this.btnSuaBM.Location = new System.Drawing.Point(87, 124);
            this.btnSuaBM.Name = "btnSuaBM";
            this.btnSuaBM.Size = new System.Drawing.Size(75, 30);
            this.btnSuaBM.TabIndex = 13;
            this.btnSuaBM.Text = "Edit";
            this.btnSuaBM.UseVisualStyleBackColor = false;
            this.btnSuaBM.Click += new System.EventHandler(this.btnSuaBM_Click);
            // 
            // btnThemBM
            // 
            this.btnThemBM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemBM.ForeColor = System.Drawing.Color.White;
            this.btnThemBM.Location = new System.Drawing.Point(14, 124);
            this.btnThemBM.Name = "btnThemBM";
            this.btnThemBM.Size = new System.Drawing.Size(66, 30);
            this.btnThemBM.TabIndex = 12;
            this.btnThemBM.Text = "Add";
            this.btnThemBM.UseVisualStyleBackColor = false;
            this.btnThemBM.Click += new System.EventHandler(this.btnThemBM_Click);
            // 
            // txtTenBM
            // 
            this.txtTenBM.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenBM.Location = new System.Drawing.Point(131, 81);
            this.txtTenBM.Name = "txtTenBM";
            this.txtTenBM.Size = new System.Drawing.Size(212, 25);
            this.txtTenBM.TabIndex = 7;
            // 
            // txtMaBM
            // 
            this.txtMaBM.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaBM.Location = new System.Drawing.Point(131, 38);
            this.txtMaBM.Name = "txtMaBM";
            this.txtMaBM.Size = new System.Drawing.Size(212, 25);
            this.txtMaBM.TabIndex = 6;
            // 
            // lblMaBM
            // 
            this.lblMaBM.Location = new System.Drawing.Point(10, 41);
            this.lblMaBM.Name = "lblMaBM";
            this.lblMaBM.Size = new System.Drawing.Size(114, 22);
            this.lblMaBM.TabIndex = 1;
            this.lblMaBM.Text = "Mã Bộ Môn:";
            // 
            // lblTenBM
            // 
            this.lblTenBM.Location = new System.Drawing.Point(10, 85);
            this.lblTenBM.Name = "lblTenBM";
            this.lblTenBM.Size = new System.Drawing.Size(114, 22);
            this.lblTenBM.TabIndex = 0;
            this.lblTenBM.Text = "Tên Bộ Môn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(13, 392);
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
            "Mã Bộ Môn",
            "Tên Bộ Môn"});
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
            // QLBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 465);
            this.Controls.Add(this.grdsBoMon);
            this.Controls.Add(this.grpThongTinBM);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QLBoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBoMon";
            this.Load += new System.EventHandler(this.QLBoMon_Load);
            this.grdsBoMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).EndInit();
            this.grpThongTinBM.ResumeLayout(false);
            this.grpThongTinBM.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdsBoMon;
        private System.Windows.Forms.DataGridView dgvBoMon;
        private System.Windows.Forms.GroupBox grpThongTinBM;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoaBM;
        private System.Windows.Forms.Button btnSuaBM;
        private System.Windows.Forms.Button btnThemBM;
        private System.Windows.Forms.TextBox txtTenBM;
        private System.Windows.Forms.TextBox txtMaBM;
        private System.Windows.Forms.Label lblMaBM;
        private System.Windows.Forms.Label lblTenBM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBM;
    }
}