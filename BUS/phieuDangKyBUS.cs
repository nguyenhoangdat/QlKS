using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using DAL;
using DTO;

namespace BUS
{
    public class phieuDangKyBUS
    {
        private static phieuDangKyBUS instance;

        public static phieuDangKyBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new phieuDangKyBUS();
                return instance;
            }
        }
        private phieuDangKyBUS ( ) { }
        public bool isTonTaiPhieuDangKy(string maPDK)
        {
            return phieuDangKyDAO.Instance.isTonTaiPhieuDangKy(maPDK);
        }
        public bool themPhieuDangKy(string maPDK, string cMND, string maNV, DateTime thoiGianDen, DateTime thoiGianDi, int trangThai)
        {
            bool isHopLe = true;
            if (thoiGianDen > thoiGianDi)
                isHopLe = false;
            if (!isHopLe)
            {
                MessageBox.Show("Thời gian không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phieuDangKyBUS.instance.isTonTaiPhieuDangKy(maPDK))
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phiếu đăng ký! vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return phieuDangKyDAO.Instance.themPhieuDangKy(maPDK, cMND, maNV, thoiGianDen, thoiGianDi, trangThai);
        }
        public phieuDangKyDTO LayTheoMAPdanhSachChuaDenPhieuDangKy(string maP)
        {
            return phieuDangKyDAO.Instance.LayTheoMAPdanhSachChuaDenPhieuDangKy(maP);
        }
        public bool updatePhieuDangKy(string maP, string maPDK, DateTime thoiGianDen, DateTime thoiGianDi)
        {

            List<phongDTO> list = phongDAO.Instance.LayDanhSachPhongHopLe(maP, thoiGianDen, thoiGianDi);
            bool isHopLe = false;

            foreach (phongDTO item in list)
            {
                if (maP == item.maP)
                {
                    isHopLe = true;
                }
            }
            if (thoiGianDen > thoiGianDi)
                isHopLe = false;
            if (isHopLe)
            {
                return phieuDangKyDAO.Instance.updatePhieuDangKy(maPDK, thoiGianDen, thoiGianDi);
            }
            else
            {
                MessageBox.Show("Thời gian cập nhật bị trùng với phiếu đăng ký khác hoặc thời gian đến lớn hơn thời gian dự kiến đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
        }
        public bool updateDaDenPhieuDangKy(string maPDK)
        {

            return phieuDangKyDAO.Instance.updateDaDenPhieuDangKy(maPDK);
        }
        public bool deletePhieuDangKy(string maPDK)
        {
            return phieuDangKyDAO.Instance.deletePhieuDangKy(maPDK);
        }
        public List<phieuDangKyDTO> LayTheoMAPdanhSachDaDenPhieuDangKy(string MAP)
        {

            return phieuDangKyDAO.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(MAP);
        }
    }
}
