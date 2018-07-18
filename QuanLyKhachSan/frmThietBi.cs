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
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBi()
        {
            InitializeComponent();
        }
        BindingSource ThietBiSource = new BindingSource();
        private void dtgvDsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaTB = Cons.xoakhoangtrang(txtMaThietbi.Text);
            if (string.IsNullOrEmpty(txtMaThietbi.Text)) return;
            if (XtraMessageBox.Show("Thêm " + txtTenThietBi.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                return;
            string TenTB = Cons.xoakhoangtrang(txtTenThietBi.Text);

            if (thietBiBUS.Instance.themThietBi(MaTB, TenTB))
            {
                XtraMessageBox.Show("Thêm " + txtTenThietBi.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThietBi_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }
        void LoadList ()
        {
            lsvDSThietBi.Items.Clear();
            List<thietBiDTO> list = new List<thietBiDTO>();
            ThietBiSource.DataSource = list;
            try
            {
                list = thietBiBUS.Instance.LayDanhSachThietbi();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi : " + ex);
            }
            foreach (thietBiDTO item in list)
            {
                ListViewItem lvitem = new ListViewItem(item.maTB.ToString());
                lvitem.SubItems.Add(item.tenTB.ToString());
                lsvDSThietBi.Items.Add(lvitem);
            }
        }
        void LoadListPhongDatThietBi(string maTB)
        {  
            lsvDSThietBi.Items.Clear();
            List<thietBiDTO> list = new List<thietBiDTO>();
            try
            {
                list = thietBiBUS.Instance.LayDanhSachMaLPTheoMaTB(maTB);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi : " + ex);
            }
            foreach (thietBiDTO item in list)
            {
                ListViewItem lvitem = new ListViewItem(item.maTB.ToString());
                lvitem.SubItems.Add(item.tenTB.ToString());
                lsvDSThietBi.Items.Add(lvitem);
            }
        }
        void BindDing()
        {

        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTim_Click(this, new EventArgs());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenTB = Cons.xoakhoangtrang(txtTim.Text);
            lsvDSThietBi.Items.Clear();
            List<thietBiDTO> list = new List<thietBiDTO>();
            try
            {
                list = thietBiBUS.Instance.LayDanhSachThietBiTheoTen(TenTB);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi : " + ex);
            }
            foreach (thietBiDTO item in list)
            {
                ListViewItem lvitem = new ListViewItem(item.maTB.ToString());
                lvitem.SubItems.Add(item.tenTB.ToString());
                lsvDSThietBi.Items.Add(lvitem);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaLP = lsvDSThietBi.SelectedItems[0].SubItems[0].Text;
            if (string.IsNullOrEmpty(MaLP)) return;
            if (!thietBiBUS.Instance.deleteThietBi(MaLP))
            {
                MessageBox.Show("vui long thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + MaLP + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadList();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThietbi.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string TenTB = Cons.xoakhoangtrang(txtTenThietBi.Text);
            if (!thietBiBUS.Instance.updateThietBi(txtMaThietbi.Text, TenTB))
            {
                MessageBox.Show("vui long thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật " + lblTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadList();
        }

        //private void lsvDSThietBi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string MaLP = lsvDSThietBi.SelectedItems[0].SubItems[0].Text;
        //    LoadListPhongDatThietBi(MaLP);
        //}
    }
}