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
    public class khachHangBUS
    {
        private static khachHangBUS instance;
        public static khachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new khachHangBUS();
                return instance;
            }
        }

        public khachHangBUS() { }

        public bool themKhachHang (string cMND, string tenKhachHang, int gioiTinh, string soDienThoai, string diaChi, string maQT)
        {
            try
            {
                return khachHangDAO.Instance.themKhachHang(cMND, tenKhachHang, gioiTinh, soDienThoai, diaChi, maQT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool updateKhachHang(string cMND, string tenKhachHang, int gioiTinh, string soDienThoai, string diaChi, string maQT)
        {
            try
            {
                return khachHangDAO.Instance.updateKhachHang(cMND, tenKhachHang, gioiTinh, soDienThoai, diaChi, maQT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool xoaKhachHang(string cMND)
        {
            try
            {
                return khachHangDAO.Instance.deleteKhachHang(cMND);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<khachHangDTO> LayTheoTenKhachHang(string tenKhachHang)
        {
            try
            {
                return khachHangDAO.Instance.LayTheoTenKhachHang(tenKhachHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LayListKhachang()
        {
            try
            {
                return khachHangDAO.Instance.LayTatCaKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<khachHangDTO> LayDanhSachKhachHang()
        {
            List<khachHangDTO> list = new List<khachHangDTO>();
            DataTable dt;
            try
            {
                dt= khachHangDAO.Instance.LayTatCaKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new khachHangDTO(item));
            }
            return list;
        }
        public khachHangDTO LayTheoCMNDKhachHang(string CMND)
        {
            return khachHangDAO.Instance.LayTheoCMNDKhachHang(CMND);
        }
        public khachHangDTO LayDSKhachHangTheoCMND(string cMND)
        {
            try
            {
                return khachHangDAO.Instance.LayTheoCMNDKhachHang(cMND);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
