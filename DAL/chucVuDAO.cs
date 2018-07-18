using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class chucVuDAO
    {
        private static chucVuDAO instance;

        public static chucVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new chucVuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        /// <summary>
        /// lấy danh sách chức vụ 
        /// </summary>
        /// <returns></returns>
        private chucVuDAO() {  }
        public chucvuDTO LayTheoMaChucVuDTO(string macv)
        {
            chucvuDTO result = new chucvuDTO();
            string query = "USP_LayTheoMaChucvu @macv";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { macv });
            foreach (DataRow item in data.Rows)
            {
                result = (new chucvuDTO(item));
            }
            return result;
        }
        public List<chucvuDTO> LayTheoMaChucVu(string macv)
        {
            List<chucvuDTO> result = new List<chucvuDTO>();
            string query = "USP_layDanhSachChucvu  @MaCV";

            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query, new object[] { macv });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            foreach ( DataRow row in table.Rows)
            {
                chucvuDTO cv = new chucvuDTO();
                result.Add(cv);
            }
            return result;
        }

        /// <summary>
        /// Lấy Chức Vụ Theo Mã Chức Vụ
        /// </summary>
        /// <param name="macv"></param>
        /// <returns></returns>
        public List<chucvuDTO> LayDSChucVu()
        {
            List<chucvuDTO> result = new List<chucvuDTO>();
            string query = "USP_layDanhSachChucvu";


            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (DataRow row in table.Rows)
            {
                chucvuDTO cv = new chucvuDTO();
                result.Add(cv);
            }
            return result;
        }
        public List<chucvuDTO> LayDanhSachChucVu()
        {
            List<chucvuDTO> result = new List<chucvuDTO>();
            string query = "USP_layDanhSachChucvu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new chucvuDTO(item));
            }
            return result;
        }
    }
}
