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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            bindDing();
            loadcate(cmbChucVu);
            
        }

        void loadcate(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DataSource = chucVuBUS.Instance.LayDanhSachChucVu();
        }
       
        void bindDing()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", gvNhanVien.DataSource, "MANV");
            lblNhanVien.DataBindings.Clear();
            lblNhanVien.DataBindings.Add("Text", gvNhanVien.DataSource,"TenNV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", gvNhanVien.DataSource, "TenNV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", gvNhanVien.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", gvNhanVien.DataSource, "SDT");
            dtpkNgaySinh.DataBindings.Clear();
            dtpkNgaySinh.DataBindings.Add("value", gvNhanVien.DataSource, "NgaySinh");
            lblGioiTinh.DataBindings.Clear();
            lblGioiTinh.DataBindings.Add("Text", gvNhanVien.DataSource, "GioiTinh");
            lblChucvu.DataBindings.Clear();
            lblChucvu.DataBindings.Add("Text", gvNhanVien.DataSource, "MaCV");
         
        }
        void loadNhanVien()
        {
            try
            {
                gcNhanVien.DataSource = nhanVienBUS.Instance.LayTatCaNhanVien();
                gvNhanVien.Columns[0].Caption = "Mã Nhân Viên";
                gvNhanVien.Columns[1].Caption = "Tên Nhân Viên";
                gvNhanVien.Columns[2].Caption = "Giới Tính";
                gvNhanVien.Columns[3].Caption = "Ngày Sinh";
                gvNhanVien.Columns[4].Caption = "Số Điện Thoại";
                gvNhanVien.Columns[5].Caption = "Địa Chỉ";
                gvNhanVien.Columns[6].Caption = "Mật Khẩu Đăng Nhập";
                gvNhanVien.Columns[7].OptionsColumn.AllowEdit = false; // Mặc định k sửa đc

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
         
        }

        /// <summary>
        /// Đặt lại mật khẩu từ lblnhanvien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNhanVien.Text) )    return;
            if (XtraMessageBox.Show("Đặt lại mật khẩu cho nhân viên " + lblNhanVien.Text + " ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return ;
            string MK = Cons.hasPass("1");//đặt lại là bằng 1 
            if(nhanVienBUS.Instance.updateMatKhau(lblNhanVien.Text,MK))
            {
                XtraMessageBox.Show("Cập nhật mật khẩu" + lblNhanVien.Text + "thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                loadNhanVien();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }

        private void lblNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblGioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblGioiTinh.Text)) return; 
            switch(lblGioiTinh.Text)
            {
                case "1":
                    rdNam.Checked = true;
                    break;
                default:
                    rdNu.Checked = true;
                    break;
            }
        }
        private void lblChucvu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblChucvu.Text)) return;
            {
                foreach (chucvuDTO item in cmbChucVu.Items)
                {
                    cmbChucVu.SelectedItem = item;
                }
            }
        }
        /// <summary>
        /// thêm mới nhân viên 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            string MaNV = Cons.xoakhoangtrang(txtMaNV.Text);
            if (string.IsNullOrEmpty(MaNV)) return;
            if (XtraMessageBox.Show("Thêm " + MaNV + "?", " Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenNV = Cons.xoakhoangtrang(txtHoTen.Text);
            int GioiTinh = rdNam.Checked == true ? 1 : 0;
            DateTime NgaySinh = dtpkNgaySinh.Value;
            string DiaChi =txtDiaChi.Text;// này thì óc chó đi xóa khoảng trắng :)) tìm cả buổi chiều 
            string SDT = Cons.xoakhoangtrang(txtSDT.Text);
            string MaCV = ((chucvuDTO)cmbChucVu.SelectedItem).maCV;
            string MatKhau = Cons.hasPass("1");
            if (nhanVienBUS.Instance.themNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi, MatKhau, MaCV))
            {
                XtraMessageBox.Show("Thêm " + MaNV + " thành công!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               frmNhanVien_Load(sender,e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// Cập nhật nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNhanVien.Text)) return;
            {
                if (XtraMessageBox.Show("Cập Nhật " + lblNhanVien.Text + " ?", "Thông báo", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult) return;
                string MaNV = Cons.xoakhoangtrang(txtMaNV.Text);
                string TeNV = Cons.xoakhoangtrang(lblNhanVien.Text);
                int GioiTinh= rdNam.Checked== true ? 1:0;
                DateTime NgaySinh = dtpkNgaySinh.Value;
                string DiaChi = txtDiaChi.Text;// này thì óc chó đi xóa khoảng trắng :)) tìm cả buổi chiều 
                string SDT = Cons.xoakhoangtrang(txtSDT.Text);
                string MaCV = ((chucvuDTO)cmbChucVu.SelectedItem).maCV;
                if (nhanVienBUS.Instance.updateNhanVien(MaCV, TeNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV))
                {
                    XtraMessageBox.Show("Cập Nhật " + lblNhanVien.Text + " thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNhanVien.Text)) return;
            {
                if (XtraMessageBox.Show("Xóa " + lblNhanVien.Text + " và tất cả các thông tin liên quan?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult) return;
                if( nhanVienBUS.Instance.xoaNhanVien(txtMaNV.Text))
                {

                    XtraMessageBox.Show("Xóa " + lblNhanVien.Text + " thành công!", "Thông Báo", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string TenNV = Cons.xoakhoangtrang(txtSearchAccount.Text);
                gcNhanVien.DataSource = nhanVienBUS.Instance.LayNhanVienTheoTen(TenNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(this, new EventArgs());
            }
        }
    }
}