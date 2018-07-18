using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BUS
{
    public class hoaDonBUS
    {
        private static hoaDonBUS instance;

        public static hoaDonBUS Instance
        {
            get
            {
                if (instance == null) instance = new hoaDonBUS();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }
        private hoaDonBUS() { }
        public bool tonTaiHoaDonHoaDon(string maHD)
        {
            return hoaDonDAO.Instance.tonTaiHoaDonHoaDon(maHD);
        }
        public bool insertHoaDon(string maHD, string maPDK, string maNV, double soNgay, DateTime ngayThanhToan, double tongTien, string maP)
        {
            if (hoaDonBUS.instance.tonTaiHoaDonHoaDon(maHD))
            {
                return false;
            }
            return hoaDonDAO.Instance.insertHoaDon(maHD, maPDK, maNV, soNgay, ngayThanhToan, tongTien, maP);
        }

        public DataTable LayThongTinHoaDon(string maHD)
        {
            return hoaDonDAO.Instance.LayThongTinHoaDon(maHD);
        }
        public List<HoaDonDTO> LayThongTinHoaDonR(string maHD)
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            DataTable dt;
            dt= hoaDonDAO.Instance.LayThongTinHoaDon(maHD);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new HoaDonDTO(item));
            }
            return list;
        }
        public List<HoaDonDTO> layDanhSachHoaDonbyKhoanThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            return hoaDonDAO.Instance.layDanhSachHoaDonbyKhoanThoiGian(tuNgay, denNgay);
        }
        public DataTable LayThongTinHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            return hoaDonDAO.Instance.LayThongTinHoaDon(tuNgay, denNgay);
        }
        public DataTable LayThongTinHoaDonLoaiP(DateTime tuNgay, DateTime denNgay)
        {
            return hoaDonDAO.Instance.LayThongTinHoaDonLoaiP(tuNgay, denNgay);
        }
    }
}
