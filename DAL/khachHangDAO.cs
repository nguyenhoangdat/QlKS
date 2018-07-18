using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class khachHangDAO
    {
        private static khachHangDAO instance;
        public static khachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance =new khachHangDAO();
                return khachHangDAO.instance;
            }
        }
        public khachHangDAO() {  }

        #region Lấy theo cmnd
        /// <summary>
        /// Đổ lên data table 
        /// </summary>
        /// <param name="cMND"></param>
        /// <returns></returns>
        public khachHangDTO LayTheoCMNDKhachHang(string cMND)
        {
            khachHangDTO result = null;
            string query = "USP_getKhachHangbyMAKH @MAKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { cMND });
            foreach (DataRow item in data.Rows)
            {
                result = new khachHangDTO(item);
            }
            return result;
        }
        #endregion

        /// <summary>
        /// Thêm khách hàng 
        /// </summary>
        /// <param name="cMND"></param>
        /// <param name="tenKhachHang"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="soDienThoai"></param>
        /// <param name="diaChi"></param>
        /// <param name="maQT"></param>
        /// <returns></returns>
        public bool themKhachHang (string cMND, string tenKhachHang, int gioiTinh, string soDienThoai, string diaChi, string maQT)
        {
            string query = string.Format("USP_insertKhachHang @cmnd , @tenkhachhang , @gioitnh , @sdt , @diachi , @maqt");
            int result; 
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cMND, tenKhachHang, gioiTinh, soDienThoai, diaChi, maQT });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0 ;
        }
        /// <summary>
        /// cập nhật khách hàng
        /// </summary>
        /// <param name="cMND"></param>
        /// <param name="tenKhachHang"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="soDienThoai"></param>
        /// <param name="diaChi"></param>
        /// <param name="maQT"></param>
        /// <returns></returns>
        public bool updateKhachHang(string cMND, string tenKhachHang, int gioiTinh, string soDienThoai, string diaChi, string maQT)
        {
            string query = string.Format("USP_updateKhachHang @cmnd , @tenkhachhang , @gioitnh , @sdt , @diachi , @maqt");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cMND, tenKhachHang, gioiTinh, soDienThoai, diaChi, maQT });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        /// <summary>
        /// Xóa khách hàng 
        /// </summary>
        /// <param name="cMND"></param>
        /// <returns></returns>
        public bool deleteKhachHang(string cMND)
        {
            string query = string.Format("USP_deleteKhachHang @cmnd ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cMND });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        /// <summary>
        /// Lấy danh sách theo tên khách hàng 
        /// </summary>
        /// <param name="tenKhachHang"></param>
        /// <returns></returns>
        public List<khachHangDTO> LayTheoTenKhachHang(string tenKhachHang)
        {
            List<khachHangDTO> list = new List<khachHangDTO>();

            string query = string.Format("USP_layTheoTenKhachHang @TenKh");

            DataTable dt = new DataTable();
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKhachHang });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach(DataRow item in dt.Rows)
            {
                list.Add(new khachHangDTO(item));
            }
            return list;
        }
        /// <summary>
        /// lấy list khách hàng đổ lên datatable 
        /// </summary>
        /// <returns></returns>
        public DataTable LayTatCaKhachHang()
        {
            string query = string.Format("USP_getListKhachHang");
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
