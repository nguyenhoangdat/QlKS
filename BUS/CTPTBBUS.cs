using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class CTPTBBUS
    {
        private static CTPTBBUS instance;

        public static CTPTBBUS Instance
        {
            get
            {
                if (instance == null) instance = new CTPTBBUS();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }
        private CTPTBBUS () { }
        public bool xoaCTPTBtheoMALP(string MaLP)
        {
            if (CTPTBBUS.instance.laySoLuongCTTBtheoLP(MaLP) <= 0)
                return true;
            return CTPTBDAO.Instance.xoaCTPTBtheoMALP(MaLP);
        }
        public int laySoLuongCTTBtheoLP(string MaLP)
        {
            return CTPTBDAO.Instance.laySoLuongCTTBtheoLP(MaLP);
        }
        public bool themCTPTBtheoMALP(string maLP, string maTB, int SL)
        {
            return CTPTBDAO.Instance.themCTPTBtheoMALP(maLP, maTB, SL);
        }
        public List<CTPTBDTO> LayCTPTBTheoMaLP (string maLP)
        {
            List<CTPTBDTO> ListTb = new List<CTPTBDTO>();
            DataTable dt; 
            try           
            {
                dt = CTPTBDAO.Instance.LayCTPTBTheoLP(maLP);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow item in dt.Rows)
            {
                ListTb.Add(new CTPTBDTO(item));
            }
            return ListTb;
        }
    }
}
