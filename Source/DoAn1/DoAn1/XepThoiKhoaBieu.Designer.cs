namespace DoAn1
{
    partial class XepThoiKhoaBieu
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
            this.btnXepTKB = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXepTKB
            // 
            this.btnXepTKB.BackColor = System.Drawing.Color.Blue;
            this.btnXepTKB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXepTKB.ForeColor = System.Drawing.Color.White;
            this.btnXepTKB.Location = new System.Drawing.Point(123, 105);
            this.btnXepTKB.Name = "btnXepTKB";
            this.btnXepTKB.Size = new System.Drawing.Size(161, 43);
            this.btnXepTKB.TabIndex = 0;
            this.btnXepTKB.Text = "Xếp thời khóa biểu";
            this.btnXepTKB.UseVisualStyleBackColor = false;
            this.btnXepTKB.Click += new System.EventHandler(this.btnXepTKB_Click);
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(171, 241);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(64, 23);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblBack_MouseClick);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // XepThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 284);
            this.ControlBox = false;
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnXepTKB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "XepThoiKhoaBieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XepThoiKhoaBieu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepTKB;
        private System.Windows.Forms.Label lblBack;
    }
}