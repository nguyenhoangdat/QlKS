using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class hoaDonDAO
    {
        private static hoaDonDAO instance;

        public static hoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new hoaDonDAO();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }

        private hoaDonDAO() { }

        public bool insertHoaDon(string maHD, string maPDK, string maNV, double soNgay, DateTime ngayThanhToan, double tongTien, string maP)
        {
            string query = "USP_insertHoaDon @MAHD , @MAPDK , @MANV , @SoNgay , @NgayThanhToan , @TongTien , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maPDK, maNV, soNgay, ngayThanhToan, tongTien, maP }) > 0;
        }
        public bool tonTaiHoaDonHoaDon(string maHD)
        {
            string query = "USP_isTonTaiHoaDon @mahd";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maHD }) > 0;
        }
        public DataTable LayThongTinHoaDon(string maHD)
        {
            string query = "USP_getThongTinHoaDon @maHD";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maHD });
        }
       
        public DataTable LayThongTinHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            string query = "USP_getThongTinHoaDonThoiGian @tuNgay , @denNgay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
        }
        public DataTable LayThongTinHoaDonLoaiP(DateTime tuNgay, DateTime denNgay)
        {
            string query = "USP_getThongTinHoaDonThoiGianLoaiP @tuNgay , @denNgay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
        }
        public List<HoaDonDTO> layDanhSachHoaDonbyKhoanThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDonDTO> result = new List<HoaDonDTO>();
            string query = "USP_getListHoaDonKhoanThoiGian @tuNgay , @denNgay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new HoaDonDTO(item));
            }
            return result;
        }
    }
}
