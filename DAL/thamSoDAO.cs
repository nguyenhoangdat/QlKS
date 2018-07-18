using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class thamSoDAO
    {
        private static thamSoDAO instance;
        public static thamSoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new thamSoDAO();
                return instance;
            }
        }
        private thamSoDAO() { }

        public thamSoDTO layThamSo()
        {
            thamSoDTO result = null;
            string query = "USP_getThamSo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result = new thamSoDTO(item);
            }
            return result;
        }
        /// <summary>
        /// cập nhật tham số
        /// </summary>
        /// <param name="TLNNN"></param>
        /// <param name="TLNT3"></param>
        /// <returns></returns>
        public bool capNhatThamSo(double tLNNN, double tLNT3)
        {
            string query = "USP_updateThamSo @TLNNN , @TLNT3";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tLNNN, tLNT3 }) > 0;
        }
    }
}
