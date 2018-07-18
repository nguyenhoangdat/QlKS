namespace QuanLyKhachSan
{
    partial class frmPhieuDangKy
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
            this.pnlKhachDangKy = new System.Windows.Forms.Panel();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.pnlPhongDK = new System.Windows.Forms.Panel();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemDP = new System.Windows.Forms.Button();
            this.dtpkDuKhienTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpkThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDSKhach = new System.Windows.Forms.DataGridView();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoaChon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKhachDangKy
            // 
            this.pnlKhachDangKy.Location = new System.Drawing.Point(766, 331);
            this.pnlKhachDangKy.Name = "pnlKhachDangKy";
            this.pnlKhachDangKy.Size = new System.Drawing.Size(414, 268);
            this.pnlKhachDangKy.TabIndex = 59;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(766, 301);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(90, 24);
            this.btnThemKhach.TabIndex = 50;
            this.btnThemKhach.Text = "Thêm Khách Hàng";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(27, 306);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(90, 24);
            this.btnThemPhong.TabIndex = 51;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // pnlPhongDK
            // 
            this.pnlPhongDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPhongDK.Location = new System.Drawing.Point(26, 336);
            this.pnlPhongDK.Name = "pnlPhongDK";
            this.pnlPhongDK.Size = new System.Drawing.Size(464, 251);
            this.pnlPhongDK.TabIndex = 58;
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Location = new System.Drawing.Point(27, 98);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.Size = new System.Drawing.Size(665, 202);
            this.dgvDSPhong.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(767, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Danh sách khách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Danh sách phòng";
            // 
            // btnThemDP
            // 
            this.btnThemDP.Location = new System.Drawing.Point(274, 12);
            this.btnThemDP.Name = "btnThemDP";
            this.btnThemDP.Size = new System.Drawing.Size(80, 54);
            this.btnThemDP.TabIndex = 53;
            this.btnThemDP.Text = "Thêm chi tiết phiếu đăng ký ";
            this.btnThemDP.UseVisualStyleBackColor = true;
            this.btnThemDP.Click += new System.EventHandler(this.btnThemDP_Click);
            // 
            // dtpkDuKhienTraPhong
            // 
            this.dtpkDuKhienTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDuKhienTraPhong.Location = new System.Drawing.Point(122, 47);
            this.dtpkDuKhienTraPhong.Name = "dtpkDuKhienTraPhong";
            this.dtpkDuKhienTraPhong.Size = new System.Drawing.Size(146, 21);
            this.dtpkDuKhienTraPhong.TabIndex = 52;
            // 
            // dtpkThoiGianDen
            // 
            this.dtpkThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianDen.Location = new System.Drawing.Point(122, 12);
            this.dtpkThoiGianDen.Name = "dtpkThoiGianDen";
            this.dtpkThoiGianDen.Size = new System.Drawing.Size(146, 21);
            this.dtpkThoiGianDen.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Dự kiến trả phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Thời gian đến:";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(415, 306);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 60;
            this.btnHide.Text = "<<";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // dgvDSKhach
            // 
            this.dgvDSKhach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhach.Location = new System.Drawing.Point(766, 98);
            this.dgvDSKhach.Name = "dgvDSKhach";
            this.dgvDSKhach.Size = new System.Drawing.Size(386, 202);
            this.dgvDSKhach.TabIndex = 57;
            // 
            // lblTemp
            // 
            this.lblTemp.Location = new System.Drawing.Point(360, 8);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 23);
            this.lblTemp.TabIndex = 61;
            this.lblTemp.Text = "label1";
            this.lblTemp.TextChanged += new System.EventHandler(this.lblTemp_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(123, 306);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 24);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa Phòng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(219, 306);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(90, 24);
            this.btnXoaTatCa.TabIndex = 51;
            this.btnXoaTatCa.Text = "Xóa tất cả phòng";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(881, 302);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(117, 23);
            this.btnXoaChon.TabIndex = 62;
            this.btnXoaChon.Text = "Xóa Khách đang chọn";
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // frmPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 645);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.pnlKhachDangKy);
            this.Controls.Add(this.btnThemKhach);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.pnlPhongDK);
            this.Controls.Add(this.dgvDSKhach);
            this.Controls.Add(this.dgvDSPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemDP);
            this.Controls.Add(this.dtpkDuKhienTraPhong);
            this.Controls.Add(this.dtpkThoiGianDen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Name = "frmPhieuDangKy";
            this.Text = "Phiếu Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhachDangKy;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Panel pnlPhongDK;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemDP;
        private System.Windows.Forms.DateTimePicker dtpkDuKhienTraPhong;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnHide;
        private System.Windows.Forms.DataGridView dgvDSKhach;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaTatCa;
        private DevExpress.XtraEditors.SimpleButton btnXoaChon;
    }
}