using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class loaikhachDAO
    {
        private static loaikhachDAO instance;

        public static loaikhachDAO Instance
        {
            get
            {
                if(instance== null)
                    instance = new loaikhachDAO();
                return loaikhachDAO.instance;
            }
        }

        private loaikhachDAO() { }

        /// <summary>
        /// Lấy tất cả quốc tịch
        /// </summary>
        /// <returns></returns>
        public List<loaiKhachDTO> LayQuocTich()
        {
            List<loaiKhachDTO> list = new List<loaiKhachDTO>();
            DataTable dt = new DataTable();
            try
            {
                dt= DataProvider.Instance.ExecuteQuery("USP_getListQuocTich");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            foreach (DataRow item in dt.Rows )
            {
                list.Add(new loaiKhachDTO(item));
            }
            return list;
        }
        /// <summary>
        /// Lấy quốc tịch theo tên nước
        /// </summary>
        /// <param name="tenNuoc"></param>
        /// <returns></returns>
        public List<loaiKhachDTO> LayTheoTenQuocTich ( string tenNuoc)
        {
            List<loaiKhachDTO> list = new List<loaiKhachDTO>();
            string query = "USP_getListQuocTichtheoTen @TenNuoc";
            DataTable data = new DataTable();
            try
            {
                data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenNuoc });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        /// <summary>
        /// Thêm quốc tịch
        /// </summary>
        /// <param name="maQT"></param>
        /// <param name="tenNuoc"></param>
        /// <returns></returns>
        public bool ThemQuocTich (string maQT, string tenNuoc)
        {
            int result;
            string query = string.Format("USP_themQuocTich @MAQT , @TenNuoc");
            
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maQT, tenNuoc });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        /// <summary>
        /// Update Quốc tịch
        /// </summary>
        /// <param name="maQT"></param>
        /// <param name="tenNuoc"></param>
        /// <returns></returns>
        public bool UpdateQuocTich (string maQT, string tenNuoc)
        {
            int result;
            string query = string.Format("USP_updateQuocTich @MAQT , @TenNuoc");
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maQT,tenNuoc });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool DeleteQuocTich (string maQT)
        {
            int result;
            string query = string.Format("USP_deleteQucTich @maQT");
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maQT });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

    }
}
