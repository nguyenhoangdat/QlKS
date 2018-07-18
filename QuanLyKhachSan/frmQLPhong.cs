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
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    
    public partial class frmQLPhong : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        private double TongNgay = 0;
        private double TongTien = 0;

        //private phongDTO Phong;
        public frmQLPhong(nhanvienDTO nhanvien)
        {
            InitializeComponent();
            this.NhanVienLogin = nhanvien;
            loadcbLoaiPhong();
            LoadCBTrangThai(cbTrangThai);
            loadThongTinKhach(KhachHangSource);
        }
        private nhanvienDTO NhanVienLogin;
        private phieuDangKyDTO PhieuDangKy = null;
        private List<khachHangDTO> KhachHangSource = new List<khachHangDTO>();

        private void btnAddTTPhong_Click(object sender, EventArgs e)
        {
                frmPhieuDangKy f = new frmPhieuDangKy(NhanVienLogin);
                f.Show();
                frmQLPhong_Load(sender, e);
        }
        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            currentClickButton = null;
            LoadPhong(phongBUS.Instance.LayListPhong());
        }
        private void LoadPhong(List<phongDTO> phonglist)
        {
            flpListPhong.Controls.Clear();
            foreach (phongDTO item in phonglist)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.tenPhong;
                button.Click += btn_Click;
                button.Tag = item;
                button.ImageList = imageList1;

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
        void loadcbLoaiPhong()
        {
            cbLoaiPhong.DataSource = loaiPhongBUS.Instance.LayDanhSachLoaiPhong();
            cbLoaiPhong.ValueMember = "MALP";
            cbLoaiPhong.DisplayMember = "TenLP";
        }
        void loadcbPhieuDangKys(List<phieuDangKyDTO> listphieu)
        {
            cbPhieuDangKy.DataSource = listphieu;
            cbPhieuDangKy.ValueMember = "MAPDK";
            cbPhieuDangKy.DisplayMember = "MAPDK";
        }
        void LoadCBTrangThai(System.Windows.Forms.ComboBox cbTrangThai)
        {
            List<trangThaiPhongDTO> listTrangThai = new List<trangThaiPhongDTO>();
            listTrangThai.Add(new trangThaiPhongDTO(-1, "Tất cả"));
            listTrangThai.Add(new trangThaiPhongDTO(0, "Trống"));
            listTrangThai.Add(new trangThaiPhongDTO(1, "Đã có khách"));
            cbTrangThai.DataSource = listTrangThai;
        }
        private void ShowKhach(phongDTO phong)
        {
            gcDsKhach.DataSource = null;
            cbPhieuDangKy.SelectedItem = null;
           // lsvKhach.Items.Clear();
            if (phong == null) return;
            List<phieuDangKyDTO> listphieudk = phieuDangKyBUS.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(phong.maP);
            if (listphieudk.Count <= 0) return;
            PhieuDangKy = listphieudk.ToArray()[0];
            dtpkThoiGianDen.Value = PhieuDangKy.ThoiGianDen;
            dtpkDuKhienTraPhong.Value = PhieuDangKy.ThoiGianDi;
            listphieudk.Add(phieuDangKyBUS.Instance.LayTheoMAPdanhSachChuaDenPhieuDangKy(phong.maP));
            loadcbPhieuDangKys(listphieudk);
            // txtMaPhieuDangKy.Text=PhieuDangKy.MaPDK;
            //Thông tin khách hàng
            List<CTPDKDTO> dskhach = CTPDKBUS.Instance.LayDanhSachChuaDenTheoPhongCTPDK(PhieuDangKy.MaPDK, phong.maP);
            List<khachHangDTO> dsKhachHang = new List<khachHangDTO>(); ;
            foreach (CTPDKDTO item in dskhach)
            {
                //ListViewItem lsvItem = new ListViewItem(item.CMND.ToString());
                dsKhachHang.Add(khachHangBUS.Instance.LayTheoCMNDKhachHang(item.CMND));
                //lsvKhach.Items.Add(lsvItem);
            }
            gcDsKhach.DataSource = dsKhachHang;
            gvDSKhach.Columns[0].Caption = "CMND";
            gvDSKhach.Columns[1].Caption = "Tên Khách Hàng";
            gvDSKhach.Columns[2].Visible = false;
            gvDSKhach.Columns[3].Caption = "Số Điện Thoại";
            gvDSKhach.Columns[5].Caption = "Quốc tịch";
            gvDSKhach.Columns[4].Visible = false;

            //foreach (khachHangDTO item in dsKhachHang)
            //{
            //    ListViewItem lsvItem = new ListViewItem(item.cMND.ToString());
            //    lsvItem.SubItems.Add(item.tenKhachHang.ToString());
            //    lsvItem.SubItems.Add(item.soDienThoai.ToString());
            //    lsvItem.SubItems.Add(item.maQT.ToString());
            //}
            DateTime dateNow = DateTime.Now;
            TimeSpan timeDaO = dateNow.Subtract(PhieuDangKy.ThoiGianDen);
            TongNgay = timeDaO.TotalDays;
            if (TongNgay <= 0) TongNgay = 0;
            txtSoNgayThue.Text = string.Format("{0:0.##}", TongNgay);
            thamSoDTO ThamSo = thamSoBUS.Instance.layThamSo();
            bool isKhachNuocNgoai = false;
            foreach (khachHangDTO item in dsKhachHang)
            {
                if (item.maQT != "Vi")
                {
                    isKhachNuocNgoai = true;
                    break;
                }
            }
            loaiPhongDTO LoaiPhong = loaiPhongBUS.Instance.LayLoaiPhongMALP(phong.maLP);
            if (isKhachNuocNgoai)
            {
                if (dsKhachHang.Count >= 3)
                {
                    TongTien = LoaiPhong.Gia * TongNgay * ThamSo.tyLePhuThuKhachNuocNgoai;
                    TongTien += TongTien * ThamSo.tyLePhuThuKhachThu3 / 100;
                }
                else
                {
                    TongTien = LoaiPhong.Gia * TongNgay * ThamSo.tyLePhuThuKhachNuocNgoai;
                }
            }
            else
            {
                if (dsKhachHang.Count >= 3)
                {
                    TongTien = LoaiPhong.Gia * TongNgay;
                    TongTien += TongTien * ThamSo.tyLePhuThuKhachThu3 / 100;
                }
                else
                {
                    TongTien = LoaiPhong.Gia * TongNgay;
                }
            }
            if (TongTien <= 0) TongTien = 0;
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = TongTien.ToString("c", culture);
            TongTien= Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]) * 1000;

        }

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
            string maP = ((sender as SimpleButton).Tag as phongDTO).maP;
            gcDsKhach.Tag=(sender as SimpleButton).Tag;
            ShowKhach((phongDTO)(sender as SimpleButton).Tag);         
            currentClickButton = sender as SimpleButton;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            phongDTO Phong = gcDsKhach.Tag as phongDTO;
            if (Phong == null)
                return;
            List<phieuDangKyDTO> listphieudk = phieuDangKyBUS.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(Phong.maP);
            if (listphieudk.Count <= 0) return;
            PhieuDangKy = listphieudk.ToArray()[0];
            dtpkThoiGianDen.Value = PhieuDangKy.ThoiGianDen;
            dtpkDuKhienTraPhong.Value = PhieuDangKy.ThoiGianDi;
            CultureInfo culture = new CultureInfo("vi-VN");
            if (PhieuDangKy == null) return;

            if (MessageBox.Show("Thanh toán hóa đơn với " + TongTien.ToString("c", culture), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string MAHD = Cons.Random(10);
            if (!(hoaDonBUS.Instance.insertHoaDon(MAHD, PhieuDangKy.MaPDK, NhanVienLogin.MaNV, TongNgay, DateTime.Now, TongTien, Phong.maP)
                && (phieuDangKyBUS.Instance.updatePhieuDangKy(Phong.maP, PhieuDangKy.MaPDK, PhieuDangKy.ThoiGianDen, DateTime.Now))))
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmQLPhong_Load(sender, e);
            if (MessageBox.Show("Bạn có muốn in hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ReportHoaDon report = new ReportHoaDon();
                report.DataSource = hoaDonBUS.Instance.LayThongTinHoaDon(MAHD);
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
                //crHoaDonTraPhong crhoaDon = new crHoaDonTraPhong();
                //crhoaDon.SetDataSource(busHoaDon.Instance.LayThongTinHoaDon(MAHD));
                //fReport f = new fReport(crhoaDon);
                //f.ShowDialog();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            phongDTO Phong = gcDsKhach.Tag as phongDTO;
            if (Phong == null)
                return;
            List<phieuDangKyDTO> listphieudk = phieuDangKyBUS.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(Phong.maP);
            if (listphieudk.Count <= 0) return;
            PhieuDangKy = listphieudk.ToArray()[0];
            dtpkThoiGianDen.Value = PhieuDangKy.ThoiGianDen;
            dtpkDuKhienTraPhong.Value = PhieuDangKy.ThoiGianDi;
            if (PhieuDangKy == null) return;

            if (!phieuDangKyBUS.Instance.updatePhieuDangKy(Phong.maP, PhieuDangKy.MaPDK, PhieuDangKy.ThoiGianDen, dtpkDuKhienTraPhong.Value))
            {
                MessageBox.Show("Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void btnDaDen_Click(object sender, EventArgs e)
        {
            if (cbPhieuDangKy.SelectedItem == null) return;
            if (((phongDTO)gcDsKhach.Tag).tinhTrang == 1)
            {
                MessageBox.Show("Phòng đang có khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            phieuDangKyDTO phieudk = (phieuDangKyDTO)cbPhieuDangKy.SelectedItem;
            if (!phieuDangKyBUS.Instance.updateDaDenPhieuDangKy(phieudk.MaPDK))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadPhong(phongBUS.Instance.LayListPhong());
            loadThongTinKhach(new List<khachHangDTO>());
        }
        List<phongDTO> loadDSPhongtheoLoaivsTinhTrang(string maLP, int tinhTrang)
        {
            List<phongDTO> result = new List<phongDTO>();
            result = phongBUS.Instance.LayDanhSachPhongTheoTrangThaivaMaLP(maLP, tinhTrang);
            return result;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedItem == null || cbTrangThai.SelectedItem == null) return;
            loaiPhongDTO LP = ((loaiPhongDTO)cbLoaiPhong.SelectedItem);
            trangThaiPhongDTO trangThai = ((trangThaiPhongDTO)cbTrangThai.SelectedItem);
            LoadPhong(loadDSPhongtheoLoaivsTinhTrang(LP.MaLP, trangThai.maTrangthai));
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            LoadPhong(phongBUS.Instance.LayListPhong());
            cbPhieuDangKy.DataSource = null;
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiPhongDTO loaiPhong = (loaiPhongDTO)cbLoaiPhong.SelectedItem;
            LoadPhong(phongBUS.Instance.LayDanhSachPhongTheoTrangThaivaMaLP(loaiPhong.MaLP, -1));
            loadThongTinKhach(new List<khachHangDTO>());
            cbPhieuDangKy.DataSource = null;
        }
        void loadThongTinKhach(List<khachHangDTO> result)
        {
            KhachHangSource = result;
            gcDsKhach.DataSource = KhachHangSource;
            gcDsKhach.Refresh();
            gvDSKhach.Columns[0].Caption = "CMND";
            gvDSKhach.Columns[1].Caption = "Tên Khách Hàng";
            gvDSKhach.Columns[2].Visible = false;
            gvDSKhach.Columns[3].Caption = "Số Điện Thoại";
            gvDSKhach.Columns[5].Caption = "Quốc tịch";
            gvDSKhach.Columns[4].Visible = false;
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (cbPhieuDangKy.SelectedItem == null) return;
            phieuDangKyDTO phieudk = (phieuDangKyDTO)cbPhieuDangKy.SelectedItem;
            if (MessageBox.Show(string.Format("Bạn muốn xóa bỏ hóa đơn {0}!", phieudk.MaPDK), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel) return;
            if (!phieuDangKyBUS.Instance.deletePhieuDangKy(phieudk.MaPDK))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPhong(phongBUS.Instance.LayListPhong());
            loadThongTinKhach(new List<khachHangDTO>());
            cbPhieuDangKy.DataSource = null;
        }

        private void cbPhieuDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhieuDangKy.SelectedItem == null) return;
            phieuDangKyDTO phieuDangKy = (phieuDangKyDTO)(cbPhieuDangKy.SelectedItem);
            dtpkThoiGianDen.Value = phieuDangKy.ThoiGianDen;
            dtpkDuKhienTraPhong.Value = phieuDangKy.ThoiGianDi;
            List<CTPDKDTO> listCTPDK = CTPDKBUS.Instance.LayDanhSachChuaDenTheoPhongCTPDK(phieuDangKy.MaPDK, ((phongDTO)gcDsKhach.Tag).maP);
            List<khachHangDTO> listKhachHang = new List<khachHangDTO>();
            foreach (CTPDKDTO item in listCTPDK)
            {
                listKhachHang.Add(khachHangBUS.Instance.LayTheoCMNDKhachHang(item.CMND));
            }
            loadThongTinKhach(listKhachHang);
        }
    }
}