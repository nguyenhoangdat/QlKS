using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class loaiKhachBUS
    {
        private static loaiKhachBUS instance;

        public static loaiKhachBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new loaiKhachBUS();
                return instance;
            }
        }

        public List<loaiKhachDTO> LayDSQT()
        {
            try
            {
                return loaikhachDAO.Instance.LayQuocTich();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<loaiKhachDTO> LayTheoTenQT(string tenNuoc)
        {
            return loaikhachDAO.Instance.LayTheoTenQuocTich(tenNuoc);
        }

        public bool DeleteQuocTich ( string maQT)
        {
            try
            {
                return loaikhachDAO.Instance.DeleteQuocTich(maQT);
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemQuoctich(string maQT, string tenNuoc)
        {
            try
            {
                return loaikhachDAO.Instance.ThemQuocTich( maQT, tenNuoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateQuocTich(string maQT, string tenNuoc)
        {
            try
            {
                return loaikhachDAO.Instance.UpdateQuocTich(maQT , tenNuoc );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
    }
}
