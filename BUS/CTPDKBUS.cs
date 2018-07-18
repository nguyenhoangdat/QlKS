using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using DAL;
using DTO;


namespace BUS
{
    public class CTPDKBUS
    {
        private static CTPDKBUS instance;

        public static CTPDKBUS Instance
        {
            get
            {
                if (instance == null) instance = new CTPDKBUS();
                return instance;
            }
            // thường k quan trọng nên có khi lượt qua
            private set
            {
                instance = value;
            }
        }
        private CTPDKBUS() { }
        public bool isTonTaiCTPDK(string cMND, string maPDK, string maP)
        {
            return CTPDKDAO.Instance.isTonTaiCTPDK(cMND, maPDK, maP);
        }
        public bool themCTPDK(string cMND, string maPDK, string maP)
        {
            if (CTPDKBUS.instance.isTonTaiCTPDK(cMND, maPDK, maP))
            {
                MessageBox.Show("Đã tồn tại CTPDK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return CTPDKDAO.Instance.themCTPDK(cMND, maPDK, maP);
        }
        public List<CTPDKDTO> LayDanhSachChuaDenTheoPhongCTPDK(string maPDK, string maP)
        {
            return CTPDKDAO.Instance.LayDanhSachTheoPhongvaMAPDKCTPDK(maPDK,maP);
        }
        public bool xoaCTPDK(string maPDK, string maP)
        {
            return CTPDKDAO.Instance.xoaCTPDK(maPDK, maP);
        }
    }
}
