using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class thietBiBUS
    {
        private static thietBiBUS instance;

        public static thietBiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new thietBiBUS();
                return instance;
            }
        }

        public thietBiBUS () { }

        public List<thietBiDTO> LayDanhSachThietbi()
        {

            DataTable table;
            try
            {
                table =thietBiDAO.Instance.LayDanhSachThietbi();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<thietBiDTO> list = new List<thietBiDTO>();
            foreach (DataRow  row in table.Rows)
            {
                thietBiDTO tb = new thietBiDTO(row);
                list.Add(tb);
            }
            return list;
        }
        public List<thietBiDTO> LayDanhSachThietBiTheoTen(string tenTB)
        {
            try
            {
                return thietBiDAO.Instance.LayDanhSachThietBiTheoTen(tenTB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<thietBiDTO> LayDanhSachMaLPTheoMaTB(string maTB)
        {
            try
            {
                return thietBiDAO.Instance.LayDanhSachMaLPTheoMaTB(maTB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool themThietBi (string maTB, string tenTB)
        {
            try
            {
                return thietBiDAO.Instance.themThietBi(maTB, tenTB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool updateThietBi(string maTB, string tenTB)
        {
            try
            {
                return thietBiDAO.Instance.updateThietBi(maTB, tenTB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool deleteThietBi(string maTB)
        {
            try
            {
                return thietBiDAO.Instance.deleteThietBi(maTB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
