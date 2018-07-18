using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class thietBiDAO
    {
        private static thietBiDAO instance;

        public static thietBiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new thietBiDAO();
                return thietBiDAO.instance;
            }
        }

        public thietBiDAO () { }

        public bool themThietBi(string maTB, string tenTB)
        {
            int result;
            string query = string.Format("USP_insertThietBi @MATB , @TenTb");

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTB, tenTB });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool updateThietBi(string maTB, string tenTB)
        {
            int result;
            string query = string.Format("USP_updateThietBi @MATB , @TenTb");

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTB, tenTB });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool deleteThietBi(string maTB)
        {
            int result;
            string query = string.Format("USP_deleteThietBi @MATB");

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTB});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public DataTable LayDanhSachThietbi()
        {
            string query = "USP_LayTatCaThietBi";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<thietBiDTO> LayDanhSachThietBiTheoTen(string tenTB)
        {
            List<thietBiDTO> list = new List<thietBiDTO>();
            string query = "USP_LayTheoTenThietBi @TenTB";
            DataTable data = new DataTable();
            try
            {
                data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTB });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public List<thietBiDTO> LayDanhSachMaLPTheoMaTB(string maTB)
        {
            List<thietBiDTO> list = new List<thietBiDTO>();
            string query = "USP_LayTenMaLPByMaTB @MaTB";
            DataTable data = new DataTable();
            try
            {
                data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTB });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        
    }
}
