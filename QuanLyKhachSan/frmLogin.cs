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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thực hiện chức năng đăng nhập, nếu đúng mật khảu cho đăng nhập , không thì thông báo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Cons.xoakhoangtrang(txtUserName.Text.ToUpper());
            string matKhau = Cons.hasPass(txtPassword.Text);

            nhanvienDTO NhanVienLogin = nhanVienBUS.Instance.LayTheoMaNhanVien(tenDangNhap);
            if (NhanVienLogin != null && matKhau == NhanVienLogin.MatKhauDangNhap)
            {
                this.Hide();
                frmMain f = new frmMain(NhanVienLogin);
                f.ShowDialog();
                txtPassword.Text = "";
                txtUserName.Text = "";
                this.Show(); 
            }
            else
            {
                XtraMessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}