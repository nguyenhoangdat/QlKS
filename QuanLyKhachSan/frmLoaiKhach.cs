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
using BUS;
using DTO;

namespace QuanLyKhachSan
{
    public partial class frmLoaiKhach : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiKhach()
        {
            InitializeComponent();
        }

        void bindding()
        {
            txtMaQT.DataBindings.Clear();
            txtMaQT.DataBindings.Add("Text", gcLoaiKhach.DataSource, "MAQT");
            txtTenNuoc.DataBindings.Clear();
            txtTenNuoc.DataBindings.Add("Text", gcLoaiKhach.DataSource, "TenNuoc");
        }
        void loadloaikhach()
        {
            try
            {
                gcLoaiKhach.DataSource = loaiKhachBUS.Instance.LayDSQT();
                gvLoaiKhach.Columns[0].Caption = "Mã Quốc Tịch";
                gvLoaiKhach.Columns[1].Caption = "Tên Nước";

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string MaQT = Cons.xoakhoangtrang(txtMaQT.Text);
            if (string.IsNullOrEmpty(txtMaQT.Text)) return;
            if (XtraMessageBox.Show("Thêm " + txtTenNuoc.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            return;
            string TenNuoc = Cons.xoakhoangtrang(txtTenNuoc.Text);

            if( loaiKhachBUS.Instance.ThemQuoctich(MaQT, TenNuoc))
            {
                XtraMessageBox.Show("Thêm " + txtTenNuoc.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLoaiKhach_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MaQT = Cons.xoakhoangtrang(txtMaQT.Text);

            if (string.IsNullOrEmpty(txtMaQT.Text)) return;
            if (XtraMessageBox.Show("Cập Nhật " + txtTenNuoc.Text + " và các thông tin liên quan?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                return;
            string TenNuoc = Cons.xoakhoangtrang(txtTenNuoc.Text);
            if (loaiKhachBUS.Instance.UpdateQuocTich(MaQT, TenNuoc))
            {
                XtraMessageBox.Show("Cập nhật " + txtTenNuoc.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLoaiKhach_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaQT = Cons.xoakhoangtrang(txtMaQT.Text);
            if (string.IsNullOrEmpty(txtMaQT.Text)) return;
            if (XtraMessageBox.Show("Xóa " + txtTenNuoc.Text + " và các thông tin liên quan?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                return;
            if(loaiKhachBUS.Instance.DeleteQuocTich(MaQT))
            {
                XtraMessageBox.Show("Xóa " + txtTenNuoc.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLoaiKhach_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmLoaiKhach_Load(object sender, EventArgs e)
        {
            loadloaikhach();
            bindding();
        }
    }
}