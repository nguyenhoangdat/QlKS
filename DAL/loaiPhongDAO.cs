using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class loaiPhongDAO
    {
        private static loaiPhongDAO instance;

        public static loaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new loaiPhongDAO();
                return loaiPhongDAO.instance;
            }
        }
        
        public loaiPhongDAO() { }

        public DataTable LayDanhSachLoaiPhongTheoTen (string tenLP)
        {
            DataTable dt;
            string query = string.Format("USP_getListLoaiPhongTheoTen @Ten");
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLP });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public bool  themLoaiPhong( string maLP, string tenLP, double gia)
        {
            string query = string.Format("USP_insertLoaiPhong @MALP , @TenLP , @Gia");
            int result; 
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLP, tenLP, gia });
            }
            catch( Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public loaiPhongDTO LayPhongTheoMaLP(string maLP)
        {
            loaiPhongDTO result = new loaiPhongDTO();
            string query = "USP_getLoaiPhongbyMALP @MaLP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maLP });
            foreach(DataRow item in dt.Rows)
            {
                result = new loaiPhongDTO(item);
            }
            return result;
        }
        public bool updateLoaiPhong(string maLP, string tenLP, double gia)
        {
            string query = string.Format("USP_updateLoaiPhong @MALP , @TenLP , @Gia");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLP, tenLP, gia });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool deleteLoaiPhong(string maLP)
        {
            string query = string.Format("USP_deleteLoaiPhong @MALP");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLP});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool isTonTaiPhong(string maLP)
        {
            string query = "USP_isTonTaiLoaiPhong @MaLP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maLP}) >0 ;
        }
        public loaiPhongDTO LayLoaiPhongmaLP(string maLP)
        {
            loaiPhongDTO result = new loaiPhongDTO();
            string query = "USP_getLoaiPhongbyMALP @MALP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maLP });
            foreach (DataRow item in data.Rows)
            {
                result = (new loaiPhongDTO(item));
            }
            return result;
        }
        public DataTable LayDanhSachLoaiPhong()
        {
            DataTable dt;
            string query = string.Format("USP_getListLoaiPhong");

            try
            {
                dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
