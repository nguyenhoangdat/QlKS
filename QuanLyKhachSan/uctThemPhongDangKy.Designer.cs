namespace QuanLyKhachSan
{
    partial class uctThemPhongDangKy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDanhSachPhong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(285, 53);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(90, 40);
            this.btnThemPhong.TabIndex = 14;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Danh sách phòng hợp lệ:";
            // 
            // cbDanhSachPhong
            // 
            this.cbDanhSachPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhSachPhong.FormattingEnabled = true;
            this.cbDanhSachPhong.Location = new System.Drawing.Point(151, 19);
            this.cbDanhSachPhong.Name = "cbDanhSachPhong";
            this.cbDanhSachPhong.Size = new System.Drawing.Size(224, 28);
            this.cbDanhSachPhong.TabIndex = 12;
            // 
            // uctThemPhongDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDanhSachPhong);
            this.Name = "uctThemPhongDangKy";
            this.Size = new System.Drawing.Size(395, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDanhSachPhong;
    }
}
