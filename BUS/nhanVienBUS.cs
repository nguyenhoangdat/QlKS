using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class nhanVienBUS
    {
        private static nhanVienBUS instance;

        public static nhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhanVienBUS();
                return instance;
            }
        }


        private nhanVienBUS() {  }

        ///<summary>
        ///lấy thông tin nhân viên theo mã nv
        /// </summary>
        /// <param name="MANV"></param>
        /// <returns></returns>
        
        public nhanvienDTO LayTheoMaNhanVien(string maNV)
        {
            return nhanVienDAO.Instance.LayTheoMaNhanVien(maNV);
        }

        public List<nhanvienDTO> LayNhanVienTheoTen(string tenNV)
        {
            return nhanVienDAO.Instance.LayTheoTenNV(tenNV);
        }
        ///<summary>
        /// Lấy danh sách nhân viên 
        /// </summary>
        /// <returns></returns>
        public List<nhanvienDTO> LayTatCaNhanVien()
        {
            return nhanVienDAO.Instance.LayTatCaNhanVien();
        }
        ///<summary>
        ///update thông tin nhân viên 
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioitinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="sdt"></param>
        /// <param name="diachi"></param> 
        /// <returns></returns>

        public bool updateNhanVien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi)
        {
            return nhanVienDAO.Instance.updateNhanvien(maNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi);
        }
        ///<summary>
        ///update thông tin nhân viên 
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioitinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="sdt"></param>
        /// <param name="diachi"></param> 
        /// <param name="maCV"></param>
        /// <returns></returns>
        public bool updateNhanVien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string maCV)
        {
            return nhanVienDAO.Instance.updateNhanvien(maNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi, maCV);
        }
        ///<summary>
        ///update mật khẩu nhân viên 
        /// </summary>
        /// <param name="MaNV"></param>
        /// <param name="MatKhau"></param>
        /// <returns></returns>
        public bool updateMatKhau(string maNV, string matKhauMoi)
        {
            return nhanVienDAO.Instance.updateMatKhau(maNV, matKhauMoi);
        }
        /// <summary>
        /// Thêm nhân viên 
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="tenNV"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="sDT"></param>
        /// <param name="diaChi"></param>
        /// <param name="maCV"></param>
        /// <returns></returns>
        
        public bool themNhanVien (string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string matKhauDangNhap, string maCV)
        {
            if(nhanVienBUS.instance.LayTheoMaNhanVien(maNV)!=null)
            {
                MessageBox.Show("Đã Tồn Tại" + maNV, "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return nhanVienDAO.Instance.themNhanVien(maNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi, matKhauDangNhap, maCV);
        }
        public bool xoaNhanVien(string maNV)
        {
            try
            {
                return nhanVienDAO.Instance.xoaNhanVien(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
