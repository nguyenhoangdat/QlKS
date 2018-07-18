using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(nhanvienDTO nhanVien)
        {
            InitializeComponent();
            this.NhanVienLogin = nhanVien;
            phanQuyenDangNhap(nhanVien);
        }
        private nhanvienDTO NhanVienLogin;

        /// <summary>
        /// kiểm tra form đã load lên midchil hay chưa
        /// </summary>
        /// <param name="fType"></param>
        /// <returns></returns>
        public Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmQLPhong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLPhong f = new frmQLPhong(NhanVienLogin);
                f.MdiParent = this;
                f.Show();
            }
        }   

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmTaiKhoan));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmTaiKhoan f = new frmTaiKhoan(NhanVienLogin);
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnDMPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmDanhMucPhong));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmDanhMucPhong f = new frmDanhMucPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();   
        }

        private void btnLoaiPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmLoaiPhong));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmLoaiPhong f = new frmLoaiPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTrangThietBi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmThietBi));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmThietBi f = new frmThietBi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLoaiKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmLoaiKhach));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmLoaiKhach f = new frmLoaiKhach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckFormExist(typeof(frmQuyDinh));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmQuyDinh f = new frmQuyDinh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmHoaDon));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmHoaDon f = new frmHoaDon();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDatPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmPhieuDangKy));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmPhieuDangKy f = new frmPhieuDangKy(NhanVienLogin);
                f.MdiParent = this;
                f.Show();
            }
        }
        void phanQuyenDangNhap(nhanvienDTO nhanvien)
        {
            switch (nhanvien.MaCV)
            {
                case "ADMIN":
                    break;
                case "NHANVIEN":
                    ribbonPageManage.Visible = false;
                    ribbonPageThongKe.Visible = false;
                    break;
            }
        }

        private void btnBCPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmThongKe));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmThongKe f = new frmThongKe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBCKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBCLoaiPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmBaoCao));
            if (frm != null)
            {
                frm.Activate(); // đã cho hiện lên 
            }
            else
            {
                frmBaoCao f = new frmBaoCao();
                f.MdiParent = this;
                f.Show();
            }

        }
    }
}