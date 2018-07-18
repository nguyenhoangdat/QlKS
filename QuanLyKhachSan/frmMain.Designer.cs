namespace QuanLyKhachSan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnInHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrangThietBi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiKhach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyDinh = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnBCPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCLoaiPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatPhong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tab = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnPhong,
            this.btnInHoaDon,
            this.btnTaiKhoan,
            this.btnLogout,
            this.btnDMPhong,
            this.btnLoaiPhong,
            this.btnTrangThietBi,
            this.btnNhanVien,
            this.btnLoaiKhach,
            this.btnQuyDinh,
            this.skinRibbonGalleryBarItem1,
            this.btnBCPhong,
            this.btnBCLoaiPhong,
            this.btnBCKhachHang,
            this.btnDatPhong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageManage,
            this.ribbonPageThongKe});
            this.ribbon.Size = new System.Drawing.Size(947, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnPhong
            // 
            this.btnPhong.Caption = "Phòng";
            this.btnPhong.Id = 1;
            this.btnPhong.ImageOptions.Image = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnPhong.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhong_ItemClick);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Caption = "In Hóa Đơn";
            this.btnInHoaDon.Id = 2;
            this.btnInHoaDon.ImageOptions.Image = global::QuanLyKhachSan.Properties.Resources.printf;
            this.btnInHoaDon.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.Show_Property_icon;
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInHoaDon_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài Khoản";
            this.btnTaiKhoan.Id = 3;
            this.btnTaiKhoan.ImageOptions.Image = global::QuanLyKhachSan.Properties.Resources.account;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiKhoan_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Id = 4;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnDMPhong
            // 
            this.btnDMPhong.Caption = "Danh Mục Phòng";
            this.btnDMPhong.Id = 5;
            this.btnDMPhong.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnDMPhong.Name = "btnDMPhong";
            this.btnDMPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDMPhong_ItemClick);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Caption = "Loại Phòng";
            this.btnLoaiPhong.Id = 6;
            this.btnLoaiPhong.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.category;
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiPhong_ItemClick);
            // 
            // btnTrangThietBi
            // 
            this.btnTrangThietBi.Caption = "Trang Thiết Bị";
            this.btnTrangThietBi.Id = 7;
            this.btnTrangThietBi.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.Automator;
            this.btnTrangThietBi.Name = "btnTrangThietBi";
            this.btnTrangThietBi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrangThietBi_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 8;
            this.btnNhanVien.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.stafflist;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnLoaiKhach
            // 
            this.btnLoaiKhach.Caption = "Loại Khách";
            this.btnLoaiKhach.Id = 9;
            this.btnLoaiKhach.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.customer;
            this.btnLoaiKhach.Name = "btnLoaiKhach";
            this.btnLoaiKhach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiKhach_ItemClick);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Caption = "Quy Định";
            this.btnQuyDinh.Id = 10;
            this.btnQuyDinh.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.auction_hammer;
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuyDinh_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 11;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnBCPhong
            // 
            this.btnBCPhong.Caption = "Phòng";
            this.btnBCPhong.Id = 12;
            this.btnBCPhong.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnBCPhong.Name = "btnBCPhong";
            this.btnBCPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCPhong_ItemClick);
            // 
            // btnBCLoaiPhong
            // 
            this.btnBCLoaiPhong.Caption = "Loại Phòng";
            this.btnBCLoaiPhong.Id = 13;
            this.btnBCLoaiPhong.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.category;
            this.btnBCLoaiPhong.Name = "btnBCLoaiPhong";
            this.btnBCLoaiPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCLoaiPhong_ItemClick);
            // 
            // btnBCKhachHang
            // 
            this.btnBCKhachHang.Caption = "Khách Hàng";
            this.btnBCKhachHang.Id = 14;
            this.btnBCKhachHang.ImageOptions.LargeImage = global::QuanLyKhachSan.Properties.Resources.customer;
            this.btnBCKhachHang.Name = "btnBCKhachHang";
            this.btnBCKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCKhachHang_ItemClick);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Caption = "Đặt Phòng";
            this.btnDatPhong.Id = 15;
            this.btnDatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.Image")));
            this.btnDatPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.LargeImage")));
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatPhong_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInHoaDon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDatPhong);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tài Khoản";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Chọn Giao Diện";
            // 
            // ribbonPageManage
            // 
            this.ribbonPageManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPageManage.Name = "ribbonPageManage";
            this.ribbonPageManage.Text = "Danh Mục Quản Lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDMPhong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLoaiPhong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Danh Mục Phòng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTrangThietBi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Trang Thiết Bị";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Nhân Viên";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLoaiKhach);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQuyDinh);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Loại Khách";
            // 
            // ribbonPageThongKe
            // 
            this.ribbonPageThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPageThongKe.Name = "ribbonPageThongKe";
            this.ribbonPageThongKe.Text = "Báo Cáo - Thống Kê";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBCPhong);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBCLoaiPhong);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Báo cáo theo tháng";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnBCKhachHang);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Khách hàng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 565);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(947, 31);
            // 
            // tab
            // 
            this.tab.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 596);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ Thống Quản Lý Khách Sạn 2 Sao ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnPhong;
        private DevExpress.XtraBars.BarButtonItem btnInHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnDMPhong;
        private DevExpress.XtraBars.BarButtonItem btnLoaiPhong;
        private DevExpress.XtraBars.BarButtonItem btnTrangThietBi;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiKhach;
        private DevExpress.XtraBars.BarButtonItem btnQuyDinh;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnBCPhong;
        private DevExpress.XtraBars.BarButtonItem btnBCLoaiPhong;
        private DevExpress.XtraBars.BarButtonItem btnBCKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tab;
        private DevExpress.XtraBars.BarButtonItem btnDatPhong;
    }
}