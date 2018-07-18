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
    public partial class uctThemThietbi : DevExpress.XtraEditors.XtraUserControl
    {
        public uctThemThietbi()
        {
            InitializeComponent();
            LoadThietBi();
        }
        private event EventHandler<ThietbiEvent> _sentThietBi;
        public event EventHandler<ThietbiEvent> SentThietBi
        {
            add { _sentThietBi += value; }
            remove { _sentThietBi -= value; }
        }
        void LoadThietBi()
        {
            cbThietBi.DataSource = thietBiBUS.Instance.LayDanhSachThietbi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbThietBi.SelectedItem == null) return;
            int SL = 0;
            Int32.TryParse(txbSoLuong.Text, out SL);
            if (SL == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng thiết bị muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_sentThietBi != null)
            {
                _sentThietBi(this, new ThietbiEvent((thietBiDTO)cbThietBi.SelectedItem, SL));
            }
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
    public class ThietbiEvent : EventArgs
    {
        private thietBiDTO thietBi;
        private int soLuong;
        public ThietbiEvent(thietBiDTO thietbi, int soLuong)
        {
            this.ThietBi = thietbi;
            this.SoLuong = soLuong;
        }

        public thietBiDTO ThietBi
        {
            get
            {
                return thietBi;
            }

            set
            {
                thietBi = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}
