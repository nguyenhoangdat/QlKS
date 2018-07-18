using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class CTPTBDAO
    {
        private static CTPTBDAO instance;
        
        public static CTPTBDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPTBDAO();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }
      
        private CTPTBDAO () { }
        public bool themCTPTBtheoMALP(string maLP, string maTB, int SL)
        {
            string query = "USP_insertCTPTB @MALP , @MATB , @SL";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLP, maTB, SL }) > 0;
        }
        public int laySoLuongCTTBtheoLP(string MaLP)
        {
            string query = "USP_soLuongCTPTBtheoMALP @MALP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MaLP });
        }
        public bool xoaCTPTBtheoMALP(string MaLP)
        {
            string query = "USP_deleteCTPTBtheoMALP @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLP }) > 0;
        }
        public DataTable LayCTPTBTheoLP( string maLP)
        {
            string query = string.Format("USP_getListCTPTBbyMALP @MALP");
            DataTable dt; 
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


    }
}
