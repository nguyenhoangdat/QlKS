using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan(nhanvienDTO NhanVienLogin)
        {
            InitializeComponent();
            this.NhanVienLogin = NhanVienLogin;
            loadThongTinNhanVien(NhanVienLogin);
        }
        private nhanvienDTO NhanVienLogin;
        void loadThongTinNhanVien(nhanvienDTO NhanVienLogin)
        {
            txbMANV.Text = NhanVienLogin.MaNV;
            txbHoTen.Text = NhanVienLogin.TenNV;
            txbDiaChi.Text = NhanVienLogin.DiaChi;
            txbSDT.Text = NhanVienLogin.SDT;
            chucvuDTO ChucVuNhanVien = chucVuBUS.Instance.LayTheoMaChucVuDTO(NhanVienLogin.MaCV);
            txbChucVu.Text = ChucVuNhanVien.tenChucVu;
            dtpkNgaySinh.Value = NhanVienLogin.NgaySinh;
            switch (NhanVienLogin.GioiTinh)
            {
                case 0:
                    rdNu.Checked = true;
                    break;
                case 1:
                    rdNam.Checked = true;
                    break;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MANV = txbMANV.Text;
            string TenNV = txbHoTen.Text;
            string DiaChi = txbDiaChi.Text;
            string SDT = txbSDT.Text;
            string ChucVu = txbChucVu.Text;
            DateTime NgaySinh = dtpkNgaySinh.Value;
            int GioiTinh = 0;
            switch (rdNam.Checked)
            {
                case false:
                    GioiTinh = 0;
                    break;
                case true:
                    GioiTinh = 1;
                    break;
            }
            if (!nhanVienBUS.Instance.updateNhanVien(MANV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}