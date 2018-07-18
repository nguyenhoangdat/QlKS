using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class phongDAO
    {
        private static phongDAO instance;
        public static phongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new phongDAO();
                return instance;
            }
        }

        private phongDAO() {  }

        public DataTable LayTatCaCacPhong()
        {
            DataTable dt;
            string query = string.Format("USP_getListPhong");
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable DanhSachPhongTheoMaLP (string maLP)
        {
            DataTable dt;
            string query = string.Format("USP_getListPhongbyMAP @MALP");
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maLP });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
       
        public phongDTO LayTheoMaPhong (string maP)
        {
            phongDTO result = new phongDTO();
            string query = string.Format("USP_getListPhongbyMAP @maP");
            DataTable dt;
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maP });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach( DataRow item in dt.Rows)
            {
                result = new phongDTO(item);
            }
            return result;
        }
        public DataTable LayPhongTheoTrangThaiVaMaLoaiPhong(string maLP, int trangThai)
        {
            DataTable dt;
            string query = string.Format("USP_getListPhongbyMALPvsTrangThai @malp , @TrangThai ");
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maLP, trangThai });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        /// <summary>
        /// Lấy danh sách phòng hợp lệ từ ngày đến ngày
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public DataTable LayDanhSachPhongHopLe(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt;
            string query = string.Format("USP_LayDanhSachPhongHopLe @tungay , @denngay ");
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        /// <summary>
        /// Lấy danh sách phòng hợp lệ từ ngày đến ngày lọc theo mã phòng
        /// </summary>
        /// <param name="maLP"></param>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public List<phongDTO> LayDanhSachPhongHopLe(string maP, DateTime tuNgay, DateTime denNgay)
        {
            List<phongDTO> result = new List<phongDTO>();
            string query = "USP_LayDanhSachPhongHopLeKhacPhong @MAP , @tungay , @denngay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maP, tuNgay, denNgay });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new phongDTO(item));
            }
            return result;
        }
        /// <summary>
        /// Cập nhật phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="soKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool capNhatThongTinPhong(string maP, string tenPhong, int tinhTrang, string ghiChu, int soKhachToiDa, string maLP)
        {
            string query = "USP_updatePhong @MAP , @TenPhong , @TinhTrang , @GhiChu , @soKhachToiDa , @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maP, tenPhong, tinhTrang, ghiChu, soKhachToiDa, maLP }) > 0;
        }
        /// <summary>
        /// thêm phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="soKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool themPhong(string maP, string tenPhong, int tinhTrang, string ghiChu, int soKhachToiDa, string maLP)
        {
            string query = "USP_insertPhong @MAP , @TenPhong , @TinhTrang , @GhiChu , @soKhachToiDa , @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {  maP,  tenPhong,  tinhTrang,  ghiChu,  soKhachToiDa,  maLP }) > 0;
        }

        /// <summary>
        /// Xoa phong
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool xoaPhong(string maP)
        {
            string query = "USP_deletePhong @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maP }) > 0;
        }
        /// <summary>
        /// Kiem tra phong co ton tai hay khong
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool isTonTaiPhong(string maP)
        {
            string query = "USP_isTonTaiPhong @MAP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maP }) > 0;
        }
        public List<phongDTO> LayTheoThietBiCoTrongPhong(string maTB)
        {
            List<phongDTO> result = new List<phongDTO>();
            string query = "USP_layTheoThietBiPhong @MATB";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTB });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new phongDTO(item));
            }
            return result;
        }
        public List<phongDTO> LayTheoMAPDK(string maPDK)
        {
            List<phongDTO> result = new List<phongDTO>();
            string query = "USP_getDanhSachPhongTheoHoaDon @MADK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPDK });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new phongDTO(item));
            }
            return result;
        }
   
    }
}
