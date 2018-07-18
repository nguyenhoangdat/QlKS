using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using DTO;
using DAL;

namespace BUS
{
    public class loaiPhongBUS
    {
        private static loaiPhongBUS instance;

        public static loaiPhongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new loaiPhongBUS();
                return instance;
            }
        }

        public loaiPhongBUS() { }

        public bool themLoaiPhong(string maLP, string tenLP, double gia)
        {
            try
            {
                return loaiPhongDAO.Instance.themLoaiPhong( maLP, tenLP, gia );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool updateLoaiPhong(string maLP, string tenLP, double gia)
        {
            try
            {
                return loaiPhongDAO.Instance.updateLoaiPhong( maLP, tenLP, gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<loaiPhongDTO> LayTatCaLoaiPhongTheoTen(string tenLP)
        {
            List<loaiPhongDTO> list = new List<loaiPhongDTO>();
            DataTable dt;
            dt= loaiPhongDAO.Instance.LayDanhSachLoaiPhongTheoTen(tenLP);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new loaiPhongDTO(item));
            }
            return list;
        }
        public bool deleteLoaiPhong(string maLP)
        {
                return loaiPhongDAO.Instance.deleteLoaiPhong(maLP) ;
        }

        public List<loaiPhongDTO> LayDanhSachLoaiPhong()
        {
            List<loaiPhongDTO> listPhong = new List<loaiPhongDTO>();
            DataTable dt;
            try
            {
                dt = loaiPhongDAO.Instance.LayDanhSachLoaiPhong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (DataRow item in dt.Rows)
            {
                loaiPhongDTO items = new loaiPhongDTO(item);
                listPhong.Add(items);
            }
            return listPhong;
        }
        public DataTable DanhSachLoaiPhong ()
        {
            try
            {
                return loaiPhongDAO.Instance.LayDanhSachLoaiPhong();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public loaiPhongDTO LayLoaiPhongMALP(string maLP)
        {

            return loaiPhongDAO.Instance.LayLoaiPhongmaLP(maLP);
        }

    }
}
