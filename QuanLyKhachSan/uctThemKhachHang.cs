using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace QuanLyKhachSan
{
    public partial class uctThemKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public uctThemKhachHang()
        {
            InitializeComponent();
            loadQuocTich(cbQuocTich);
        }
        private event EventHandler<KhachHangevent> _sentKhachHang;
        public event EventHandler<KhachHangevent> sentKhachHang
        {
            add { _sentKhachHang += value; }
            remove { sentKhachHang -= value; }
        }
        public uctThemKhachHang(khachHangDTO khachHang)
        {
            InitializeComponent();
            loadQuocTich(cbQuocTich);
            if (khachHang != null)
            {
                txtCMND.Text = khachHang.cMND;
                txtHoTen.Text = khachHang.tenKhachHang;
                txtDiachi.Text = khachHang.diaChi;
                txtSoDienThoai.Text = khachHang.soDienThoai;
                switch (khachHang.gioiTinh)
                {
                    case 0:
                        rdNu.Checked = true;
                        break;
                    case 1:
                        rdNam.Checked = true;
                        break;
                }
                foreach (loaiKhachDTO item in cbQuocTich.Items)
                {
                    if (item.maQT == khachHang.maQT)
                    {
                        cbQuocTich.SelectedItem = item;
                        break;
                    }
                }
            }

        }
        void loadQuocTich(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DataSource = loaiKhachBUS.Instance.LayDSQT();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            khachHangDTO result;
            string cmnd = Cons.xoakhoangtrang(txtCMND.Text);
            if (string.IsNullOrEmpty(txtCMND.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập chứng minh nhân dân", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            result = khachHangBUS.Instance.LayDSKhachHangTheoCMND(cmnd); // phải đổ lên list 
            // nếu chưa tồn tại thì bắt đầu thêm 
            if (result == null)
            {
                string hoTen = Cons.xoakhoangtrang(txtHoTen.Text);
                int gioiTinh = rdNam.Checked == true ? 0 : 1;
                string sdt = Cons.xoakhoangtrang(txtSoDienThoai.Text);
                string diaChi = Cons.xoakhoangtrang(txtDiachi.Text);
                loaiKhachDTO quoctich = (loaiKhachDTO)cbQuocTich.SelectedItem;
                if (khachHangBUS.Instance.themKhachHang(cmnd, hoTen, gioiTinh, sdt, diaChi, quoctich.maQT))
                {
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (_sentKhachHang != null)
            {
                _sentKhachHang(this, new KhachHangevent(result));

            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            string cmnd = Cons.xoakhoangtrang(txtCMND.Text);

            khachHangDTO kh = khachHangBUS.Instance.LayDSKhachHangTheoCMND(cmnd);
            if (kh != null)
            {
                txtHoTen.Text = kh.tenKhachHang;
                txtDiachi.Text = kh.diaChi;
                txtSoDienThoai.Text = kh.soDienThoai;
                switch (kh.gioiTinh)
                {
                    case 0:
                        rdNu.Checked = true;
                        break;
                    case 1:
                        rdNam.Checked = true;
                        break;
                }
                foreach (loaiKhachDTO item in cbQuocTich.Items)
                {
                    if (item.maQT == kh.maQT)
                    {
                        cbQuocTich.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
    public class KhachHangevent : EventArgs
    {
        private khachHangDTO result;
        public KhachHangevent(khachHangDTO khachHang)
        {
            this.Result = khachHang;
        }
        public khachHangDTO Result
        {
            get
            {
                return result;
            }

            private set
            {
                result = value;
            }
        }
    }
}
