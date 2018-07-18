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
    public class chucVuBUS
    {
        private static chucVuBUS instance;

        public static chucVuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new chucVuBUS();
                return instance;
            }
        }
        private chucVuBUS() { }

        public chucvuDTO LayTheoMaChucVuDTO(string macv)
        {
            return chucVuDAO.Instance.LayTheoMaChucVuDTO(macv);

        }
        /// <summary>
        /// Lấy theo mã chưucs vụ 
        /// </summary>
        /// <returns></returns>
        public List<chucvuDTO> LayTheoMaChucVu(string macv)
        {
            try
            {
                return chucVuDAO.Instance.LayTheoMaChucVu(macv);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Lấy danh sách chức vụ
        /// </summary>
        /// <param name="macv"></param>
        /// <returns></returns>
        public List<chucvuDTO> LayDSChucVu()
        {
            try
            {
                return chucVuDAO.Instance.LayDSChucVu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<chucvuDTO> LayDanhSachChucVu()
        {
            return chucVuDAO.Instance.LayDanhSachChucVu();
        }
    }
}
