using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class CTPDKDAO
    {
        private static CTPDKDAO instance;

        public static CTPDKDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPDKDAO();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }
        private CTPDKDAO () { }
        public bool isTonTaiCTPDK(string cMND, string maPDK, string maP)
        {
            string query = "USP_isTonTaiCTPDK @@CMND , @MAPDK , @MAP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { cMND, maPDK, maP }) > 0;
        }
        public bool themCTPDK(string cMND, string maPDK, string maP)
        {
            string query = "USP_insertCTPDK @CMND , @MAPDK , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { cMND, maPDK, maP }) > 0;
        }
        public List<CTPDKDTO> LayDanhSachTheoPhongvaMAPDKCTPDK(string maPDK, string maP)
        {
            List<CTPDKDTO> result = new List<CTPDKDTO>();
            string query = "USP_getListCTPDKbyMAPandMAPDK @MAP , @mapdk";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maP, maPDK });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new CTPDKDTO(item));
            }
            return result;
        }
        public bool xoaCTPDK(string maPDK, string maP)
        {
            string query = "USP_deleteCTPDKbyMAPDKvaMAP  @MAPDK , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPDK, maP }) > 0;
        }
    }
}
