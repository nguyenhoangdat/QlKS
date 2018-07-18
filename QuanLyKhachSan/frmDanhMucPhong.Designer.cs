namespace QuanLyKhachSan
{
    partial class frmDanhMucPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucPhong));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lsvThietBi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtKhachToiDa = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmbLoaiPhong = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.flpListPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbMaLP = new System.Windows.Forms.ComboBox();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1052, 464);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(966, 464);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(880, 464);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.Transparent;
            this.pnlThongTin.Controls.Add(this.lsvThietBi);
            this.pnlThongTin.Controls.Add(this.txtGhiChu);
            this.pnlThongTin.Controls.Add(this.cbTinhTrang);
            this.pnlThongTin.Controls.Add(this.cbLoai);
            this.pnlThongTin.Controls.Add(this.label9);
            this.pnlThongTin.Controls.Add(this.label4);
            this.pnlThongTin.Controls.Add(this.label6);
            this.pnlThongTin.Controls.Add(this.label7);
            this.pnlThongTin.Controls.Add(this.label5);
            this.pnlThongTin.Controls.Add(this.label3);
            this.pnlThongTin.Controls.Add(this.label8);
            this.pnlThongTin.Controls.Add(this.label2);
            this.pnlThongTin.Controls.Add(this.txtGia);
            this.pnlThongTin.Controls.Add(this.txtKhachToiDa);
            this.pnlThongTin.Controls.Add(this.txtTenPhong);
            this.pnlThongTin.Controls.Add(this.txtMaP);
            this.pnlThongTin.Location = new System.Drawing.Point(643, 62);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(489, 380);
            this.pnlThongTin.TabIndex = 12;
            // 
            // lsvThietBi
            // 
            this.lsvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvThietBi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThietBi.GridLines = true;
            this.lsvThietBi.Location = new System.Drawing.Point(103, 106);
            this.lsvThietBi.Name = "lsvThietBi";
            this.lsvThietBi.Size = new System.Drawing.Size(376, 151);
            this.lsvThietBi.TabIndex = 44;
            this.lsvThietBi.UseCompatibleStateImageBehavior = false;
            this.lsvThietBi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thiết bị";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thiết bị";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã loại phòng";
            this.columnHeader4.Width = 105;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 261);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(376, 103);
            this.txtGhiChu.TabIndex = 6;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(103, 43);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(148, 21);
            this.cbTinhTrang.TabIndex = 3;
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(103, 73);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(148, 21);
            this.cbLoai.TabIndex = 5;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Khách tối đa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thiết bị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phòng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(331, 73);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(148, 21);
            this.txtGia.TabIndex = 5;
            // 
            // txtKhachToiDa
            // 
            this.txtKhachToiDa.Location = new System.Drawing.Point(331, 43);
            this.txtKhachToiDa.Name = "txtKhachToiDa";
            this.txtKhachToiDa.Size = new System.Drawing.Size(148, 21);
            this.txtKhachToiDa.TabIndex = 4;
            this.txtKhachToiDa.Text = "0";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(331, 13);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(148, 21);
            this.txtTenPhong.TabIndex = 2;
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(103, 13);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(148, 21);
            this.txtMaP.TabIndex = 2;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(809, 31);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(141, 22);
            this.lblThongTin.TabIndex = 13;
            this.lblThongTin.Text = "Thông tin phòng";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "check-1-icon.png");
            this.imageList.Images.SetKeyName(1, "Check-2-icon.png");
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
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.cmbLoaiPhong});
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1151, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1151, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1151, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.Edit = this.repositoryItemComboBox1;
            this.cmbLoaiPhong.Id = 1;
            this.cmbLoaiPhong.ImageOptions.Image = global::QuanLyKhachSan.Properties.Resources.room;
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // flpListPhong
            // 
            this.flpListPhong.Location = new System.Drawing.Point(4, 25);
            this.flpListPhong.Name = "flpListPhong";
            this.flpListPhong.Size = new System.Drawing.Size(620, 470);
            this.flpListPhong.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flpListPhong);
            this.groupControl1.Location = new System.Drawing.Point(0, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(625, 473);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Loại phòng và phòng";
            // 
            // cmbMaLP
            // 
            this.cmbMaLP.FormattingEnabled = true;
            this.cmbMaLP.Location = new System.Drawing.Point(4, 4);
            this.cmbMaLP.Name = "cmbMaLP";
            this.cmbMaLP.Size = new System.Drawing.Size(121, 21);
            this.cmbMaLP.TabIndex = 25;
            this.cmbMaLP.SelectedIndexChanged += new System.EventHandler(this.cmbmaLp_SelectedIndexChanged);
            // 
            // frmDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 512);
            this.Controls.Add(this.cmbMaLP);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDanhMucPhong";
            this.Text = "Danh Mục Phòng";
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtKhachToiDa;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView lsvThietBi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.FlowLayoutPanel flpListPhong;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem cmbLoaiPhong;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.ComboBox cmbMaLP;
    }
}