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
    public partial class uctThemPhongDangKy : DevExpress.XtraEditors.XtraUserControl
    {
        public uctThemPhongDangKy(DateTime TuNgay, DateTime DenNgay)
        {
            InitializeComponent();
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            loadDanhSachPhongHopLe(TuNgay, DenNgay);
        }
        private event EventHandler<PhongEvent> _sentPhong;
        public event EventHandler<PhongEvent> SentPhong
        {
            add { _sentPhong += value; }
            remove { _sentPhong -= value; }
        }
        private DateTime TuNgay;
        private DateTime DenNgay;
        void loadDanhSachPhongHopLe(DateTime tungay, DateTime DenNgay)
        {
            List<phongDTO> listResult = phongBUS.Instance.LayDanhSachPhongHopLe(tungay, DenNgay);
            cbDanhSachPhong.DataSource = listResult;
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (cbDanhSachPhong.SelectedItem == null) return;
            phongDTO result = (phongDTO)(cbDanhSachPhong.SelectedItem);
            if (_sentPhong != null)
            {
                _sentPhong(this, new PhongEvent(result));
            }

        }
    }
    public class PhongEvent : EventArgs
    {
        private phongDTO result;
        public PhongEvent(phongDTO result)
        {
            this.Result = result;
        }

        public phongDTO Result
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
