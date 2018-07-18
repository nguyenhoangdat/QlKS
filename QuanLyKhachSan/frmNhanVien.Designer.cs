namespace QuanLyKhachSan
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchAccount = new DevExpress.XtraEditors.TextEdit();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatLaiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(846, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(846, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 474);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(846, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 474);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(767, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 35);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.EditValue = "";
            this.txtSearchAccount.Location = new System.Drawing.Point(581, 227);
            this.txtSearchAccount.MenuManager = this.barManager1;
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Properties.Appearance.Options.UseFont = true;
            this.txtSearchAccount.Properties.NullText = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Properties.NullValuePrompt = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Size = new System.Drawing.Size(180, 24);
            this.txtSearchAccount.TabIndex = 88;
            this.txtSearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyDown);
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNhanVien.Location = new System.Drawing.Point(0, 262);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(846, 229);
            this.gcNhanVien.TabIndex = 86;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(145, 151);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(271, 21);
            this.dtpkNgaySinh.TabIndex = 75;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(246, 123);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 74;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(145, 123);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(46, 17);
            this.rdNam.TabIndex = 73;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(565, 97);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(271, 21);
            this.txtSDT.TabIndex = 84;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(565, 67);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 21);
            this.txtDiaChi.TabIndex = 83;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(145, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 21);
            this.txtHoTen.TabIndex = 72;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(145, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(271, 21);
            this.txtMaNV.TabIndex = 71;
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.Location = new System.Drawing.Point(339, 6);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(169, 22);
            this.lblThongtin.TabIndex = 85;
            this.lblThongtin.Text = "Thông tin nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(365, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 43);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(258, 213);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 43);
            this.btnCapNhat.TabIndex = 68;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMatKhau.Appearance.Options.UseFont = true;
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(11, 213);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(136, 43);
            this.btnDatLaiMatKhau.TabIndex = 70;
            this.btnDatLaiMatKhau.Text = "Đặt Lại Mật Khẩu";
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(153, 213);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(101, 43);
            this.btnThemMoi.TabIndex = 67;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click_1);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblNhanVien.Location = new System.Drawing.Point(17, 6);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(0, 13);
            this.lblNhanVien.TabIndex = 94;
            this.lblNhanVien.Text = "Thông tin nhân viên";
            this.lblNhanVien.TextChanged += new System.EventHandler(this.lblNhanVien_TextChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(324, 130);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(0, 13);
            this.lblGioiTinh.TabIndex = 94;
            this.lblGioiTinh.Text = "Thông tin giới tính";
            this.lblGioiTinh.TextChanged += new System.EventHandler(this.lblGioiTinh_TextChanged);
            // 
            // lblChucvu
            // 
            this.lblChucvu.Location = new System.Drawing.Point(145, 6);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(0, 13);
            this.lblChucvu.TabIndex = 99;
            this.lblChucvu.Text = "Thông tin chức vụ";
            this.lblChucvu.TextChanged += new System.EventHandler(this.lblChucvu_TextChanged);
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucVu.Location = new System.Drawing.Point(565, 130);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(271, 21);
            this.cmbChucVu.TabIndex = 9;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 497);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.lblChucvu);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.dtpkNgaySinh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnDatLaiMatKhau);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien";
            this.Text = "Thông Tin Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearchAccount;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblThongtin;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnDatLaiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.ComboBox cmbChucVu;
    }
}