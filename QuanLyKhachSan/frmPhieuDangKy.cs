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
    public partial class frmPhieuDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuDangKy(nhanvienDTO nhanVienLogin)
        {
            InitializeComponent();
            dgvDSPhong.DataSource = PhongSource;
            LoadDSPhongChon(DanhSachPhongSource);
            this.NhanVienLogin = nhanVienLogin;
            lblTemp.DataBindings.Add(new Binding("Text", dgvDSPhong.DataSource, "MAP", true, DataSourceUpdateMode.Never));
        }
        nhanvienDTO NhanVienLogin;
        BindingSource PhongSource = new BindingSource();
        List<phongDTO> DanhSachPhongSource = new List<phongDTO>();
        List<khachHangDTO> DanhSachKhachSource = new List<khachHangDTO>();
        List<CTPDKDTO> DanhSachCTPDK = new List<CTPDKDTO>();
        private khachHangDTO khachHangDangKy = null;

        void nhungPhongDK(XtraUserControl ctr)
        {
            pnlPhongDK.Controls.Clear();
            pnlPhongDK.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlPhongDK.Controls.Add(ctr);
            pnlPhongDK.Show();
        }
        void nhungKhacDK(XtraUserControl ctr)
        {
            pnlKhachDangKy.Controls.Clear();
            pnlKhachDangKy.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlKhachDangKy.Controls.Add(ctr);
            pnlKhachDangKy.Show();
        }
        void LoadDSPhongChon(List<phongDTO> result)
        {
            PhongSource.DataSource = result;
            dgvDSPhong.Columns["MAP"].HeaderText = "Mã Phòng";
            dgvDSPhong.Columns["MALP"].HeaderText = "Mã Loại Phòng";
            dgvDSPhong.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            dgvDSPhong.Columns["soKhachToiDa"].HeaderText = "Số khách tối đa";
            dgvDSPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvDSPhong.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvDSPhong.Refresh();
        }
        private void F_SentPhong(object sender, PhongEvent e)
        {
            dgvDSPhong.ClearSelection();
            dgvDSPhong.CurrentCell = null;
            if (dgvDSPhong.Rows.Count > 1)
            {
                dgvDSPhong.CurrentCell = dgvDSPhong.Rows[0].Cells["TenPhong"];
            }
            List<phongDTO> dsNew = new List<phongDTO>();
            foreach (phongDTO item in DanhSachPhongSource)
            {
                if (item.maP == e.Result.maP) return;
                dsNew.Add(item);
            }
            DanhSachPhongSource.Clear();
            dsNew.Add(e.Result);
            DanhSachPhongSource = dsNew;
            PhongSource.DataSource = DanhSachPhongSource;
            dgvDSPhong.Refresh();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlPhongDK.Controls.Clear();
            pnlPhongDK.BorderStyle = BorderStyle.None;
            pnlKhachDangKy.Controls.Clear();
            pnlKhachDangKy.BorderStyle = BorderStyle.None;
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            uctThemPhongDangKy uct = new uctThemPhongDangKy(dtpkThoiGianDen.Value, dtpkDuKhienTraPhong.Value);
            nhungPhongDK(uct);
            uct.SentPhong += F_SentPhong;
        }
        private void F_sentKhachHang(object sender, KhachHangevent e)
        {
            if (e.Result == null) return;
            dgvDSKhach.ClearSelection();
            dgvDSKhach.CurrentCell = null;
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            phongDTO phong = phongBUS.Instance.LayTheoMaPhong(lblTemp.Text);
            int count = 0;
            foreach (CTPDKDTO item in DanhSachCTPDK)
            {
                if (item.MAP == phong.maP)
                {
                    count++;
                }
            }
            if (count >= phong.soKhachToiDa)
            {
                MessageBox.Show("Phòng đã đạt số khách tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<khachHangDTO> listNew = new List<khachHangDTO>();
            foreach (khachHangDTO item in DanhSachKhachSource)
            {
                if (item.cMND == e.Result.cMND)
                    return;
                listNew.Add(item);

            }
            listNew.Add(e.Result);
            DanhSachCTPDK.Add(new CTPDKDTO(e.Result.cMND, null, lblTemp.Text));
            DanhSachKhachSource = listNew;
            dgvDSKhach.DataSource = DanhSachKhachSource;
            dgvDSKhach.Refresh();
        }
        private void F_sentKhachHangDangKy(object sender, KhachHangevent e)
        {
            this.khachHangDangKy = e.Result;
        }
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần thêm khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            phongDTO phong = phongBUS.Instance.LayTheoMaPhong(lblTemp.Text);
            int count = 0;
            foreach (CTPDKDTO item in DanhSachCTPDK)
            {
                if (item.MAP == phong.maP)
                {
                    count++;
                }
            }
            if (count >= phong.soKhachToiDa)
            {
                MessageBox.Show("Phòng đã đạt số khách tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uctThemKhachHang uct = new uctThemKhachHang();
            nhungKhacDK(uct);
            uct.sentKhachHang += F_sentKhachHang;
            uct.sentKhachHang += F_sentKhachHangDangKy;

        }

        private void btnThemDP_Click(object sender, EventArgs e)
        {
            if (khachHangDangKy == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime TuNgay = dtpkThoiGianDen.Value;
            DateTime DenNgay = dtpkDuKhienTraPhong.Value;
            string MAPDK = Cons.Random(10);
            int trangThai = 0;
            nhanvienDTO NhanVien = this.NhanVienLogin;
            khachHangDTO khachhangdk = khachHangDangKy;
            //kiem tra so luong phong
            if (DanhSachPhongSource.Count <= 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại, phải có ít nhất một phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // kiem tra tat ca cac phong phai co it nhat 1 khach, kiem tra phong co hop le khong
            List<phongDTO> listResult = phongBUS.Instance.LayDanhSachPhongHopLe(TuNgay, DenNgay);
            int countPhongHopLe = DanhSachPhongSource.Count;
            foreach (phongDTO item in DanhSachPhongSource)
            {
                int countKhach = 0;
                bool isHopLe = false;
                foreach (phongDTO itemPhong in listResult)
                {
                    if (item.maP == itemPhong.maP)
                    {
                        isHopLe = true;
                    }
                }
                if (!isHopLe)
                {
                    MessageBox.Show("Phòng " + item.maP + " đã có khách huê trong thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (CTPDKDTO itemKhach in DanhSachCTPDK)
                {
                    if (item.maP == itemKhach.MAP)
                        countKhach++;
                }
                if (countKhach == 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại, tất cả phòng phải có ít nhất một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (!phieuDangKyBUS.Instance.themPhieuDangKy(MAPDK, khachhangdk.cMND, NhanVien.MaNV, TuNgay, DenNgay, trangThai))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (CTPDKDTO item in DanhSachCTPDK)
            {
                if (!CTPDKBUS.Instance.themCTPDK(item.CMND, MAPDK, item.MAP))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (MessageBox.Show("Xác nhận khách đã đến?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                List<phongDTO> Lphong = phongBUS.Instance.LayTheoMAPDK(MAPDK);
                bool isHople = true;
                foreach (phongDTO item in Lphong)
                {
                    if (item.tinhTrang != 0)
                    {
                        isHople = false;
                    }
                }
                if (isHople)
                {
                    if (!phieuDangKyBUS.Instance.updateDaDenPhieuDangKy(MAPDK))
                    {
                        MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Phòng đang trong trạng thái không thể thêm khách hàng ở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDSPhongChon(new List<phongDTO>());
            loadDSKhachHang(new List<khachHangDTO>());
            khachHangDangKy = null;
        }
        void loadDSKhachHang(List<khachHangDTO> result)
        {
            dgvDSKhach.DataSource = result;
            dgvDSKhach.Columns["CMND"].HeaderText = "Chứng minh nhân dân";
            dgvDSKhach.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvDSKhach.Columns["GioiTinh"].Visible = false;
            dgvDSKhach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvDSKhach.Columns["DiaChi"].Visible = false;
            dgvDSKhach.Columns["MAQT"].Visible = false;
            dgvDSKhach.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.SelectedCells.Count <= 0) return;
            List<string> map = new List<string>();
            for (int i = 0; i < dgvDSPhong.SelectedCells.Count; i++)
            {
                map.Add((string)dgvDSPhong.SelectedCells[i].OwningRow.Cells["MAP"].Value);
            }
            List<phongDTO> listNew = new List<phongDTO>();
            //Loai bo nhung dtoPhong
            foreach (phongDTO item in DanhSachPhongSource)
            {
                bool isTrung = false;
                foreach (string items in map)
                {
                    if (item.maP == items)
                    {
                        isTrung = true;
                        break;
                    }
                }
                if (!isTrung)
                {
                    listNew.Add(item);
                }
            }
            DanhSachPhongSource.Clear();
            DanhSachPhongSource = listNew;
            PhongSource.DataSource = DanhSachPhongSource;
            dgvDSPhong.Refresh();
        }
        /// <summary>
        /// Them khách hàng khi có sự kiện gửi về
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            DanhSachPhongSource.Clear();
            DanhSachPhongSource = new List<phongDTO>();
            PhongSource.DataSource = DanhSachPhongSource;
            dgvDSPhong.Refresh();
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (dgvDSKhach.SelectedCells.Count <= 0) return;
            string MAP = lblTemp.Text;
            string cmnd = (string)dgvDSKhach.SelectedCells[0].OwningRow.Cells["CMND"].Value;
            List<CTPDKDTO> listNew = new List<CTPDKDTO>();
            foreach (CTPDKDTO item in DanhSachCTPDK)
            {
                if (item.CMND == cmnd && item.MAP == MAP)
                {
                    continue;
                }
                listNew.Add(item);
            }
            DanhSachCTPDK = listNew;
            lblTemp_TextChanged(this, new EventArgs());
        }

        private void lblTemp_TextChanged(object sender, EventArgs e)
        {

            dgvDSKhach.DataSource = null;
            DanhSachKhachSource = new List<khachHangDTO>();
            if (string.IsNullOrEmpty(lblTemp.Text)) return;
            DanhSachKhachSource.Clear();
            DanhSachKhachSource = new List<khachHangDTO>();
            foreach (CTPDKDTO item in DanhSachCTPDK)
            {
                if (lblTemp.Text == item.MAP)
                {
                    DanhSachKhachSource.Add(khachHangBUS.Instance.LayDSKhachHangTheoCMND(item.CMND));
                }
            }
            loadDSKhachHang(DanhSachKhachSource);
        }
    }
}