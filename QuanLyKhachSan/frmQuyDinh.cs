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

namespace QuanLyKhachSan
{
    public partial class frmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTLNC.Text) || string.IsNullOrEmpty(txtTLNT3.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            float TLNNN = float.Parse(txtTLNC.Text);
            float TLNT3 = float.Parse(txtTLNT3.Text);
            if (!thamSoBUS.Instance.capNhatThamSo(TLNNN, TLNT3))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
        }
    }
}