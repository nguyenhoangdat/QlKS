namespace QuanLyKhachSan
{
    partial class frmQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPhieuDangKy = new System.Windows.Forms.ComboBox();
            this.gcDsKhach = new DevExpress.XtraGrid.GridControl();
            this.gvDSKhach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkDuKhienTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpkThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoNgayThue = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaDen = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTTPhong = new DevExpress.XtraEditors.SimpleButton();
            this.flpListPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemTatCa = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDsKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgayThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbPhieuDangKy);
            this.panel1.Controls.Add(this.gcDsKhach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpkDuKhienTraPhong);
            this.panel1.Controls.Add(this.dtpkThoiGianDen);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtSoNgayThue);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnDaDen);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnAddTTPhong);
            this.panel1.Location = new System.Drawing.Point(485, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 547);
            this.panel1.TabIndex = 1;
            // 
            // cbPhieuDangKy
            // 
            this.cbPhieuDangKy.FormattingEnabled = true;
            this.cbPhieuDangKy.Location = new System.Drawing.Point(380, 11);
            this.cbPhieuDangKy.Name = "cbPhieuDangKy";
            this.cbPhieuDangKy.Size = new System.Drawing.Size(156, 21);
            this.cbPhieuDangKy.TabIndex = 54;
            this.cbPhieuDangKy.SelectedIndexChanged += new System.EventHandler(this.cbPhieuDangKy_SelectedIndexChanged);
            // 
            // gcDsKhach
            // 
            this.gcDsKhach.Location = new System.Drawing.Point(3, 113);
            this.gcDsKhach.MainView = this.gvDSKhach;
            this.gcDsKhach.MenuManager = this.barManager1;
            this.gcDsKhach.Name = "gcDsKhach";
            this.gcDsKhach.Size = new System.Drawing.Size(541, 349);
            this.gcDsKhach.TabIndex = 53;
            this.gcDsKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSKhach});
            // 
            // gvDSKhach
            // 
            this.gvDSKhach.GridControl = this.gcDsKhach;
            this.gvDSKhach.Name = "gvDSKhach";
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
            this.barManager1.MaxItemId = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1033, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1033, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1033, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã phiếu đăng ký";
            // 
            // dtpkDuKhienTraPhong
            // 
            this.dtpkDuKhienTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDuKhienTraPhong.Location = new System.Drawing.Point(103, 38);
            this.dtpkDuKhienTraPhong.Name = "dtpkDuKhienTraPhong";
            this.dtpkDuKhienTraPhong.Size = new System.Drawing.Size(146, 21);
            this.dtpkDuKhienTraPhong.TabIndex = 47;
            // 
            // dtpkThoiGianDen
            // 
            this.dtpkThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianDen.Location = new System.Drawing.Point(103, 11);
            this.dtpkThoiGianDen.Name = "dtpkThoiGianDen";
            this.dtpkThoiGianDen.Size = new System.Drawing.Size(146, 21);
            this.dtpkThoiGianDen.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Dự kiến trả phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Thời gian đến:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Image = global::QuanLyKhachSan.Properties.Resources.Check_2_icon;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(26, 476);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 28);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Đang chọn";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(140, 477);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 18);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Số Ngày Thuê";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Appearance.Options.UseFont = true;
            this.lblTongTien.Appearance.Options.UseImage = true;
            this.lblTongTien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblTongTien.Location = new System.Drawing.Point(140, 514);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 18);
            this.lblTongTien.TabIndex = 41;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Image = global::QuanLyKhachSan.Properties.Resources.check_1_icon;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(26, 514);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 28);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Có người";
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoNgayThue.Enabled = false;
            this.txtSoNgayThue.Location = new System.Drawing.Point(242, 468);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayThue.Properties.Appearance.Options.UseFont = true;
            this.txtSoNgayThue.Size = new System.Drawing.Size(154, 30);
            this.txtSoNgayThue.TabIndex = 39;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(242, 505);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(154, 30);
            this.txtTotalPrice.TabIndex = 39;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Appearance.Options.UseFont = true;
            this.btnCheck.Location = new System.Drawing.Point(448, 475);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 64);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.Location = new System.Drawing.Point(435, 64);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(101, 43);
            this.btnHuyBo.TabIndex = 35;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDaDen
            // 
            this.btnDaDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaDen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaDen.Appearance.Options.UseFont = true;
            this.btnDaDen.Location = new System.Drawing.Point(328, 64);
            this.btnDaDen.Name = "btnDaDen";
            this.btnDaDen.Size = new System.Drawing.Size(101, 43);
            this.btnDaDen.TabIndex = 35;
            this.btnDaDen.Text = "Đã Đến";
            this.btnDaDen.Click += new System.EventHandler(this.btnDaDen_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(221, 64);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 43);
            this.btnCapNhat.TabIndex = 35;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnAddTTPhong
            // 
            this.btnAddTTPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTTPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTTPhong.Appearance.Options.UseFont = true;
            this.btnAddTTPhong.Location = new System.Drawing.Point(114, 64);
            this.btnAddTTPhong.Name = "btnAddTTPhong";
            this.btnAddTTPhong.Size = new System.Drawing.Size(101, 43);
            this.btnAddTTPhong.TabIndex = 35;
            this.btnAddTTPhong.Text = "Thêm Mới";
            this.btnAddTTPhong.Click += new System.EventHandler(this.btnAddTTPhong_Click);
            // 
            // flpListPhong
            // 
            this.flpListPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListPhong.AutoScroll = true;
            this.flpListPhong.Location = new System.Drawing.Point(3, 37);
            this.flpListPhong.Name = "flpListPhong";
            this.flpListPhong.Size = new System.Drawing.Size(476, 511);
            this.flpListPhong.TabIndex = 31;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(3, 10);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiPhong.TabIndex = 36;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(130, 10);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangThai.TabIndex = 36;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(257, 8);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(47, 23);
            this.btnXem.TabIndex = 37;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(310, 8);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnXemTatCa.TabIndex = 37;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-1-icon.png");
            this.imageList1.Images.SetKeyName(1, "Check-2-icon.png");
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 548);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.flpListPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQLPhong";
            this.Text = "Tác Vụ";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDsKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgayThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flpListPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkDuKhienTraPhong;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnDaDen;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnAddTTPhong;
        private DevExpress.XtraEditors.LabelControl lblTongTien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnXemTatCa;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoNgayThue;
        private DevExpress.XtraGrid.GridControl gcDsKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSKhach;
        private System.Windows.Forms.ComboBox cbPhieuDangKy;
    }
}