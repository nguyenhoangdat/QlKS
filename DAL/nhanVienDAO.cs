using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class nhanVienDAO
    {
        private static nhanVienDAO instance;

        public static nhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhanVienDAO();
                return nhanVienDAO.instance;
            }
        }

        private nhanVienDAO() { } //tạo contructor rỗng

        ///<summary>
        /// lấy thông tin nhân viên theo mã nhân viên 
        /// </summary>
        /// <param name="MANV"></param>
        /// <return></return>

        public nhanvienDTO LayTheoMaNhanVien(string maNV)
        {
            nhanvienDTO result = null; //khởi tạo null
            string query = "USP_getNhanVienbyMANV @maNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
            foreach (DataRow item in data.Rows)
            {
                result = new nhanvienDTO(item);
            }
            return result;
        }
        ///<summary>
        /// lấy tất cả danh sách nhân viên 
        /// </summary>
        /// <returns></returns>
        public List<nhanvienDTO> LayTatCaNhanVien()
        {
            List<nhanvienDTO> result = new List<nhanvienDTO>();
            string query = "USP_getListNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new nhanvienDTO(item));
            }
            return result;
        }
        ///<summary>
        ///lấy nhân viên theo tên gần đúng 
        /// </summary>
        /// <param name="TenNV"</param>
        /// <returns></returns>
        public List<nhanvienDTO> LayTheoTenNV(string tenNV)
        {
            List<nhanvienDTO> result = new List<nhanvienDTO>();
            string query = "USP_getListNhanVientheoTen @TenNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenNV });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new nhanvienDTO(item));
            }
            return result;
        }
        ///<summary>
        ///update thông tin nhân viên 
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioitinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="sdt"></param>
        /// <param name="diachi"></param> 
        /// <returns></returns>

        public bool updateNhanvien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi)
        {
            string query = string.Format("USP_updateNhanVien @manv, @TenNV, @GioiTinh, @ngaysinh, @SDT, @diaChi");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        ///<summary>
        ///update thông tin nhân viên 
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioitinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="sdt"></param>
        /// <param name="diachi"></param> 
        /// <param name="maCV"></param>
        /// <returns></returns>

        public bool updateNhanvien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string maCV)
        {

            string query = string.Format("USP_updateNhanVienAll @manv , @TenNV , @GioiTinh , @ngaysinh , @SDT , @diaChi , @macv");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi,maCV });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="tenNV"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="sDT"></param>
        /// <param name="diaChi"></param>
        /// <param name="matKhauDangNhap"></param>
        /// <param name="maCV"></param>
        /// <returns></returns>
        public bool themNhanVien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string matKhauDangNhap, string maCV)
        {
             
            string query = string.Format("USP_insertNhanVien @MANV , @TenNV , @Gioitinh , @NgaySinh , @SDT , @DiaChi , @MatKhau , @MACV");
            int result;
            try{
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { maNV,  tenNV,  gioiTinh,  ngaySinh,  sDT,  diaChi,  matKhauDangNhap,  maCV});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        ///<summary>
        ///update mật khẩu nhân viên 
        /// </summary>
        /// <param name="MaNV"></param>
        /// <param name="MatKhau"></param>
        /// <returns></returns>
        public bool updateMatKhau(string maNV, string matKhauMoi)
        {
            string query = " USP_updateMatKhauNhanVien @MANV, @MatKhau";
            int result; 
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV, matKhauMoi });
            }
            catch (Exception ex )
            {
                throw ex;
            }
            return result > 0;
            
        }
        ///<summary>
        ///xóa nhân viên 
        ///</summary>
        ///<param name="manv"></param>
        ///<returns></returns>
        public bool xoaNhanVien(string maNV)
        {
            string query = "USP_deleteNhanVien @manv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV }) > 0;
        }
    }

}
