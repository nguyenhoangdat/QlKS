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
    public partial class frmThayDoiMatKhauNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThayDoiMatKhauNhanVien(nhanvienDTO NhanVienlogin)
        {
            InitializeComponent();
            this.NhanVienLogin = NhanVienlogin;
        }
        private nhanvienDTO NhanVienLogin;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MatKhauCu = Cons.hasPass(txbMatKhauCu.Text);
            string MatKhauMoi = Cons.hasPass(txbMatKhauMoi.Text);
            string MatKhauMoiLan2 = Cons.hasPass(txbMayKhauMoiLan2.Text);
            nhanvienDTO NhanVien = nhanVienBUS.Instance.LayTheoMaNhanVien(NhanVienLogin.MaNV);
            if (MatKhauCu != NhanVien.MatKhauDangNhap)
            {
                MessageBox.Show("Mật khẩu củ sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MatKhauMoi != MatKhauMoiLan2)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!nhanVienBUS.Instance.updateMatKhau(NhanVien.MaNV, MatKhauMoi))
            {
                MessageBox.Show("Xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}