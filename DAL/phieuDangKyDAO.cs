using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class phieuDangKyDAO
    {
        private static phieuDangKyDAO instance;

        public static phieuDangKyDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new phieuDangKyDAO();
                return instance;
            }
        }
        private phieuDangKyDAO () { }
        public bool isTonTaiPhieuDangKy(string maPDK)
        {
            string query = "USP_isTonTaiPhieuDangKy @mapdk";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maPDK }) > 0;
        }
        public bool themPhieuDangKy(string maPDK, string cMND, string maNV, DateTime thoiGianDen, DateTime thoiGianDi, int trangThai)
        {
            string query = "USP_insertPhieuDangKy @MAPDK , @CMND , @MANV , @ThoiGianDen , @ThoiGianDi , @TrangThai";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPDK, cMND, maNV, thoiGianDen, thoiGianDi, trangThai }) > 0;
        }
        public phieuDangKyDTO LayTheoMAPdanhSachChuaDenPhieuDangKy(string maP)
        {
            phieuDangKyDTO result = null ;
            string query = "USP_getListPhieuDangKyChuaDenbyMAP @map";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maP });
            foreach (DataRow item in data.Rows)
            {
                result= new phieuDangKyDTO(item);
            }
            return result;
        }
        public List<phieuDangKyDTO> LayTheoMAPdanhSachDaDenPhieuDangKy(string maP)
        {
            List<phieuDangKyDTO> result = new List<phieuDangKyDTO>();
            string query = "USP_getListPhieuDangKyDaDenbyMAP @map";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maP });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new phieuDangKyDTO(item));
            }
            return result;
        }
        public bool updatePhieuDangKy(string maPDK, DateTime thoiGianDen, DateTime thoiGianDi)
        {
            string query = "USP_updateThoiGianPhieuDangKy @maPDK , @ThoiGianDen , @thoiGianDi";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPDK, thoiGianDen, thoiGianDi }) > 0;
        }
        public bool updateDaDenPhieuDangKy(string maPDK)
        {
            string query = "USP_updateDaDenPhieuDangKy @MAPDK ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPDK }) > 0;
        }
        public bool deletePhieuDangKy(string maPDK)
        {
            string query = "USP_deletePhieuDangKy @MAPDK ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPDK }) > 0;
        }
    }
}
