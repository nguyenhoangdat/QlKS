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
using DevExpress.XtraTab;
using DTO;
using BUS;
using System.Globalization;

namespace QuanLyKhachSan
{
    public partial class frmDanhMucPhong : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        public frmDanhMucPhong()
        {
            InitializeComponent();
            currentClickButton = null;
            LoadPhong(phongBUS.Instance.LayListPhong());
            loadCbBox();
            loadCbTrangThai();
        }

        void loadCbTrangThai()
        {
            List<trangThaiPhongDTO> listTrangThai = new List<trangThaiPhongDTO>();
            listTrangThai.Add(new trangThaiPhongDTO(0, "Trống"));
            listTrangThai.Add(new trangThaiPhongDTO(1, "Đã có khách"));
            cbTinhTrang.DataSource = listTrangThai;
        }
        void loadCbBox()
        {
            cmbMaLP.DataSource = loaiPhongBUS.Instance.LayDanhSachLoaiPhong();
            cmbMaLP.ValueMember = "MALP";
            cmbMaLP.DisplayMember = "TenLP";
            cbLoai.DataSource = loaiPhongBUS.Instance.LayDanhSachLoaiPhong();
            cbLoai.ValueMember = "MALP";
            cbLoai.DisplayMember = "TenLP";
        }
        void LoadThietBi(string maLP)
        {
            lsvThietBi.Items.Clear();
            List<CTPTBDTO> list = new List<CTPTBDTO>();
            try
            {
                list = CTPTBBUS.Instance.LayCTPTBTheoMaLP(maLP);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi : " + ex);
            }
            foreach (CTPTBDTO item in list)
            {
                ListViewItem lvitem = new ListViewItem(item.MaTB.ToString());
                lvitem.SubItems.Add(item.TenTB.ToString());
                lvitem.SubItems.Add(item.SoLuong.ToString());
                lvitem.SubItems.Add(item.MaLP.ToString());
                lsvThietBi.Items.Add(lvitem);
            }
        }

        /// <summary>
        /// Load list phòng lên flpListPhong
        /// </summary>
        private void LoadPhong(List<phongDTO> phonglist)
        {

            flpListPhong.Controls.Clear();

            foreach (phongDTO item in phonglist)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.tenPhong;
                button.Click += btn_Click;
                button.Tag = item;
                button.ImageList = imageList;

                switch (item.tinhTrang)
                {
                    case 1:
                        button.ImageIndex = 0;
                        break;
                    default:
                        break;
                }
                flpListPhong.Controls.Add(button);
            }
        } 
        private void ListViewSelectChanged(object sender , ListViewItemSelectionChangedEventArgs e)
        {
            // sự kiện current là 1 sự kiện khác
            txtMaP.Text = ((sender as Control).Tag as phongDTO).maP;
            LoadThietBi(((sender as Control).Tag as phongDTO).maLP);
            // hiển thị thông tin thiết bị
            txtTenPhong.Text = ((sender as Control).Tag as phongDTO).tenPhong;
            int SoKhach = ((sender as Control).Tag as phongDTO).soKhachToiDa;
            txtKhachToiDa.Text = SoKhach.ToString();
            txtGhiChu.Text = ((sender as Control).Tag as phongDTO).ghiChu;
            txtTenPhong.Text = ((sender as Control).Tag as phongDTO).tenPhong;
            foreach (trangThaiPhongDTO item in cbTinhTrang.Items)
            {
                if (((sender as SimpleButton).Tag as phongDTO).tinhTrang == item.maTrangthai)
                {
                    cbTinhTrang.SelectedItem = item;
                    break;
                }
            }
            foreach (loaiPhongDTO item in cbLoai.Items)
            {
                if (((sender as SimpleButton).Tag as phongDTO).maLP == item.MaLP)
                {
                    cbLoai.SelectedItem = item;
                    break;
                }
            }
        }
            // tạo sự kiện click button 
        void btn_Click(object sender, EventArgs e)
        {
                // sự kiện current là 1 sự kiện khác
                if ((sender as SimpleButton) != currentClickButton)
                {
                    if (currentClickButton != null)
                    {
                        if ((currentClickButton.Tag as phongDTO).tinhTrang == 1)
                            currentClickButton.ImageIndex = 0;
                        else currentClickButton.ImageIndex = -1;
                    }
                }

                (sender as SimpleButton).ImageIndex = 1;
                txtMaP.Text = ((sender as SimpleButton).Tag as phongDTO).maP;
                lsvThietBi.Tag = (sender as SimpleButton).Tag;
                LoadThietBi(((sender as SimpleButton).Tag as phongDTO).maLP);   
                // hiển thị thông tin thiết bị
                txtTenPhong.Text = ((sender as SimpleButton).Tag as phongDTO).tenPhong;
                int SoKhach = ((sender as SimpleButton).Tag as phongDTO).soKhachToiDa;
                txtKhachToiDa.Text = SoKhach.ToString();
                txtGhiChu.Text = ((sender as SimpleButton).Tag as phongDTO).ghiChu;
                txtTenPhong.Text = ((sender as SimpleButton).Tag as phongDTO).tenPhong;
                foreach (trangThaiPhongDTO item in cbTinhTrang.Items)
                {
                    if (((sender as SimpleButton).Tag as phongDTO).tinhTrang == item.maTrangthai)
                    {
                        cbTinhTrang.SelectedItem = item;
                        break;
                    }
                }
                foreach (loaiPhongDTO item in cbLoai.Items)
                {
                    if (((sender as SimpleButton).Tag as phongDTO).maLP == item.MaLP)
                    {
                        cbLoai.SelectedItem = item;
                        break;
                    }
                }
                currentClickButton = sender as SimpleButton;
            }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cons.xoakhoangtrang(txtMaP.Text)))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            phongDTO Phong = new phongDTO();
            Phong.maP = Cons.xoakhoangtrang(txtMaP.Text);
            if (MessageBox.Show("Thêm " + Phong.maP + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            Phong.ghiChu = Cons.xoakhoangtrang(txtGhiChu.Text);
            Phong.maLP = ((loaiPhongDTO)cbLoai.SelectedItem).MaLP;
            int SL = 0;
            int.TryParse(txtKhachToiDa.Text, out SL);
            Phong.soKhachToiDa = SL;
            Phong.tenPhong = Cons.xoakhoangtrang(txtTenPhong.Text);
            Phong.tinhTrang = ((trangThaiPhongDTO)cbTinhTrang.SelectedItem).maTrangthai;
            if (!phongBUS.Instance.themPhong(Phong.maP, Phong.tenPhong, Phong.tinhTrang, Phong.ghiChu, Phong.soKhachToiDa, Phong.maLP))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbmaLp_SelectedIndexChanged(this, new EventArgs());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            phongDTO Phong = lsvThietBi.Tag as phongDTO;
            if (Phong == null)
            {
                XtraMessageBox.Show("Hãy chọn phòng");
                return;
            }
            if (MessageBox.Show("Cập nhật thông tin phòng " + Phong.maP + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            Phong.ghiChu = Cons.xoakhoangtrang(txtGhiChu.Text);
            Phong.maLP = ((loaiPhongDTO)cbLoai.SelectedItem).MaLP;

            int SL = 0;
            int.TryParse(txtKhachToiDa.Text, out SL);
            Phong.soKhachToiDa = SL;
            Phong.tenPhong = Cons.xoakhoangtrang(txtTenPhong.Text);
            Phong.tinhTrang = ((trangThaiPhongDTO)cbTinhTrang.SelectedItem).maTrangthai;
            if (!phongBUS.Instance.capNhatThongTinPhong(Phong.maP, Phong.tenPhong, Phong.tinhTrang, Phong.ghiChu, Phong.soKhachToiDa, Phong.maLP))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbmaLp_SelectedIndexChanged(this, new EventArgs());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            phongDTO phong = lsvThietBi.Tag as phongDTO;
            if (phong == null)
            {
                XtraMessageBox.Show("Hãy chọn phòng");
                return;
            }
            if (MessageBox.Show("Xóa phòng " + phong.maP + " sẽ xóa tất cả thông tin liên quan ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!phongBUS.Instance.xoaPhong(phong.maP))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbmaLp_SelectedIndexChanged(this, new EventArgs());
        }

        private void cmbmaLp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLP.SelectedItem == null) return;
            loaiPhongDTO loaiP = (loaiPhongDTO)cmbMaLP.SelectedItem;
            LoadPhong(phongBUS.Instance.LayDanhSachPhongTheoTrangThaivaMaLP(loaiP.MaLP, -1));
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedItem == null) return;
            loaiPhongDTO loaiP = (loaiPhongDTO)cbLoai.SelectedItem;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtGia.Text = loaiP.Gia.ToString("c", culture);
            LoadThietBi(loaiP.MaLP);
        }
    }
}