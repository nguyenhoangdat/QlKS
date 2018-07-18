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
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }    
        private List<CTPTBDTO> CTPTBsource = new List<CTPTBDTO>();
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string MaLP = Cons.xoakhoangtrang(txtMaLoai.Text);
            if (string.IsNullOrEmpty(txtMaLoai.Text)) return;
            if (XtraMessageBox.Show("Thêm " + txtTen.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                return;
            string TenLP = Cons.xoakhoangtrang(txtTen.Text);
            double Gia = 0;
            double.TryParse(Cons.xoakhoangtrang(txtGia.Text), out Gia);

            if (!loaiPhongBUS.Instance.themLoaiPhong(MaLP, TenLP, Gia))
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            foreach (CTPTBDTO item in CTPTBsource)
            {
                if (!CTPTBBUS.Instance.themCTPTBtheoMALP(MaLP, item.MaTB, item.SoLuong))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Thêm " + MaLP + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLoaiPhong_Load(sender, e);
            lblMaLP.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text)) return;
            if (XtraMessageBox.Show("Cập nhật " + txtTen.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
                return;
            string MaLP = Cons.xoakhoangtrang(txtMaLoai.Text);
            string TenLP = Cons.xoakhoangtrang(txtTen.Text);
            double Gia = 0;
            double.TryParse(Cons.xoakhoangtrang(txtGia.Text), out Gia);

            if (!loaiPhongBUS.Instance.updateLoaiPhong(MaLP, TenLP, Gia))
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (!CTPTBBUS.Instance.xoaCTPTBtheoMALP(MaLP))
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (CTPTBDTO item in CTPTBsource)
            {
                if (!CTPTBBUS.Instance.themCTPTBtheoMALP(MaLP, item.MaTB, item.SoLuong))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Cập nhật " + MaLP + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLoaiPhong_Load(sender, e);
            lblMaLP.Text = "";
        }
        void loadBinDing()
        {
            lblMaLP.DataBindings.Clear();
            lblMaLP.DataBindings.Add(new Binding("Text", gcLoaiPhong.DataSource, "MALP"));
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add(new Binding("Text", gcLoaiPhong.DataSource, "MALP"));
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add(new Binding("Text", gcLoaiPhong.DataSource, "TenLP"));
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add(new Binding("Text", gcLoaiPhong.DataSource, "Gia"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMaLP.Text)) return;
            if (XtraMessageBox.Show("Xóa loại phòng " + lblMaLP.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult) return;
            if(loaiPhongBUS.Instance.deleteLoaiPhong(lblMaLP.Text))
            {
                XtraMessageBox.Show("Xóa " + lblMaLP.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLoaiPhong_Load(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        } 
        void LoadListPhong (List<loaiPhongDTO> list)
        {
            gcLoaiPhong.DataSource = list;
            gvLoaiPhong.Columns[0].Caption = "Mã loại phòng";
            gvLoaiPhong.Columns[1].Caption = "Tên loại phòng";
            gvLoaiPhong.Columns[2].Caption = "Đơn giá";
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {  
            LoadListPhong(loaiPhongBUS.Instance.LayDanhSachLoaiPhong());
            loadCTPTB(new List<CTPTBDTO>());
            loadBinDing();
        }

        private void txtMaLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true; 
        }
        
        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = Cons.xoakhoangtrang(txbTim.Text);
            LoadListPhong(loaiPhongBUS.Instance.LayTatCaLoaiPhongTheoTen(ten));
        }

        private void txbTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTim_Click(this, new EventArgs());
            }
        }
        private void F_SentThietBi(object sender, ThietbiEvent e)
        {
            thietBiDTO ThietBi = e.ThietBi;
            int SoLuong = e.SoLuong;
            List<CTPTBDTO> listThietBi = new List<CTPTBDTO>();
            bool isTrung = false;
            foreach (CTPTBDTO item in CTPTBsource)
            {
                if (ThietBi.maTB == item.MaTB)
                {
                    item.SoLuong += SoLuong;
                    isTrung = true;
                }
                listThietBi.Add(item);
            }
            if (!isTrung)
            {
                listThietBi.Add(new CTPTBDTO(lblMaLP.Text, ThietBi.maTB, ThietBi.tenTB, SoLuong));
            }
            CTPTBsource.Clear();
            CTPTBsource = listThietBi;
            loadCTPTB(CTPTBsource);
        }
        void loadCTPTB(List<CTPTBDTO> list)
        {
            dgvThietBi.DataSource = list;
            dgvThietBi.Columns["MALP"].Visible = false;
            dgvThietBi.Columns["MATB"].Visible = false;
            dgvThietBi.Columns["TenTB"].HeaderText = "Tên thiết bị";
            dgvThietBi.Columns["SoLuong"].HeaderText = "Số Lượng";
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void lblMaLP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMaLP.Text))
            {
                txtGia.Text = "";
                txtMaLoai.Text = "";
                txtTen.Text = "";
                return;
            }
            CTPTBsource = CTPTBBUS.Instance.LayCTPTBTheoMaLP(lblMaLP.Text);
            loadCTPTB(CTPTBsource);
        }
        void nhung(XtraUserControl ctr)
        {
            pnlFrmThemThietBi.Controls.Clear();
            pnlFrmThemThietBi.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlFrmThemThietBi.Controls.Add(ctr);
            pnlFrmThemThietBi.Show();
        }
        private void btnThemTB_Click(object sender, EventArgs e)
        {
            uctThemThietbi uctS = new uctThemThietbi();
            nhung(uctS);
            uctS.SentThietBi += F_SentThietBi;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlFrmThemThietBi.Controls.Clear();
            pnlFrmThemThietBi.BorderStyle = BorderStyle.None;
        }

        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.SelectedCells.Count <= 0) return;
            string MaTB = (string)dgvThietBi.SelectedCells[0].OwningRow.Cells["MATB"].Value;
            List<CTPTBDTO> listNew = new List<CTPTBDTO>();
            foreach (CTPTBDTO item in CTPTBsource)
            {
                if (item.MaTB == MaTB)
                    continue;
                listNew.Add(item);
            }
            CTPTBsource.Clear();
            CTPTBsource = listNew;
            loadCTPTB(CTPTBsource);
        }
    }
}