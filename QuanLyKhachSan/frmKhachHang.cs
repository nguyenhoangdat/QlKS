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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BindingSource KhachHangSource = new BindingSource();
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            gcDsKhach.DataSource = KhachHangSource;
            loadLoaiKhachToCB(cbQuocTich);
            loadKhachHang(khachHangBUS.Instance.LayDanhSachKhachHang());
            bindding();
        }
        void loadLoaiKhachToCB(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = loaiKhachBUS.Instance.LayDSQT();
        }
        void loadKhachHang(List<khachHangDTO> list)
        {
            KhachHangSource.DataSource = list;
            gvDsKhach.Columns[0].Caption = "Chứng minh nhân dân";
            gvDsKhach.Columns[1].Caption = "Họ tên";
            gvDsKhach.Columns[2].Visible = false;
            gvDsKhach.Columns[3].Caption = "Số điện thoại";
            gvDsKhach.Columns[4].Visible = false;
            gvDsKhach.Columns[5].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string CMND = Cons.xoakhoangtrang(txtCMND.Text);
            if (string.IsNullOrEmpty(CMND))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Thêm " + CMND + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenKhachHang = Cons.xoakhoangtrang(txtHoTen.Text);
            int gioiTinh = rdNam.Checked == true ? 1 : 0;

            string DiaChi = Cons.xoakhoangtrang(txtDiachi.Text);
            string SDT = Cons.xoakhoangtrang(txtSoDienThoai.Text);
            string LoaiKhach = ((loaiKhachDTO)cbQuocTich.SelectedItem).maQT;
            if (!khachHangBUS.Instance.themKhachHang(CMND, TenKhachHang, gioiTinh, SDT, DiaChi, LoaiKhach))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(khachHangBUS.Instance.LayDanhSachKhachHang());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ten = Cons.xoakhoangtrang(txtSearchAccount.Text);
            loadKhachHang(khachHangBUS.Instance.LayTheoTenKhachHang(ten));
        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string CMND = lblCmnd.Text;
            if (string.IsNullOrEmpty(CMND)) return;
            if (MessageBox.Show("Xóa " + CMND + " và thông tin liên quan ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!khachHangBUS.Instance.xoaKhachHang(CMND))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(khachHangBUS.Instance.LayDanhSachKhachHang());
        }

        private void lblgioitinhtemp_TextChanged(object sender, EventArgs e)
        {
            switch (lblgioitinhtemp.Text)
            {
                case "0":
                    rdNu.Checked = true;
                    break;
                default:
                    rdNam.Checked = true;
                    break;
            }
        }
        void bindding()
        {
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", gcDsKhach.DataSource, "CMND");
            lblCmnd.DataBindings.Clear();
            lblCmnd.DataBindings.Add("Text", gcDsKhach.DataSource, "CMND");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", gcDsKhach.DataSource, "TenKhachHang");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", gcDsKhach.DataSource, "DiaChi");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", gcDsKhach.DataSource, "SoDienThoai");
            lblgioitinhtemp.DataBindings.Clear();
            lblgioitinhtemp.DataBindings.Add("Text", gcDsKhach.DataSource, "GioiTinh");
            lblLoaiKhach.DataBindings.Clear();
            lblLoaiKhach.DataBindings.Add("Text", gcDsKhach.DataSource, "MAQT");
        }
        private void lblLoaiKhach_TextChanged(object sender, EventArgs e)
        {
            foreach (loaiKhachDTO item in cbQuocTich.Items)
            {
                if (item.maQT == lblLoaiKhach.Text)
                {
                    cbQuocTich.SelectedItem = item;
                    return;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string CMND = Cons.xoakhoangtrang(lblCmnd.Text);
            if (string.IsNullOrEmpty(CMND))
            {
                return;
            }
            if (MessageBox.Show("Cập nhật " + CMND + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenKhachHang = Cons.xoakhoangtrang(txtHoTen.Text);
            int gioiTinh = rdNam.Checked == true ? 1 : 0;

            string DiaChi = Cons.xoakhoangtrang(txtDiachi.Text);
            string SDT = Cons.xoakhoangtrang(txtSoDienThoai.Text);
            string LoaiKhach = ((loaiKhachDTO)cbQuocTich.SelectedItem).maQT;
            if (!khachHangBUS.Instance.updateKhachHang(CMND, TenKhachHang, gioiTinh, SDT, DiaChi, LoaiKhach))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(khachHangBUS.Instance.LayDanhSachKhachHang());
        }
    }
}