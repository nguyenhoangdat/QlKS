using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BUS
{
    public class phongBUS
    {
        private static phongBUS instance;
        public static phongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new phongBUS();
                return instance;
            }
        }

        private phongBUS () { }
        

        public List<phongDTO> LayListPhong ()
        {
            DataTable dt;
            List<phongDTO> ListPhong = new List<phongDTO>();
            try
            {
                dt = phongDAO.Instance.LayTatCaCacPhong();
            }
            catch (Exception ex) { throw ex; }
            foreach (DataRow item in dt.Rows)
            {
                ListPhong.Add(new phongDTO(item));
            }
            return ListPhong;
        }
        public List<phongDTO> LayDanhSachPhongHopLe(DateTime TuNgay, DateTime DenNgay)
        {
            DataTable dt;
            List<phongDTO> ListPhong = new List<phongDTO>();
            dt= phongDAO.Instance.LayDanhSachPhongHopLe(TuNgay, DenNgay);
            foreach (DataRow item in dt.Rows)
            {
                ListPhong.Add(new phongDTO(item));
            }
            return ListPhong;
        }
        public phongDTO LayTheoMaPhong(string MAP)
        {
            return phongDAO.Instance.LayTheoMaPhong(MAP);
        }
        /// <summary>
        /// Cập nhật phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="soKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool capNhatThongTinPhong(string maP, string tenPhong, int tinhTrang, string ghiChu, int soKhachToiDa, string maLP)
        {
            return phongDAO.Instance.capNhatThongTinPhong(maP, tenPhong, tinhTrang, ghiChu, soKhachToiDa, maLP);
        }
        /// <summary>
        /// them phong với các thông tin
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="soKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool themPhong(string maP, string tenPhong, int tinhTrang, string ghiChu, int soKhachToiDa, string maLP)
        {
            if (phongDAO.Instance.isTonTaiPhong(maP))
            {
                MessageBox.Show("Đã tồn tại phòng " + maP + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return phongDAO.Instance.themPhong(maP, tenPhong, tinhTrang, ghiChu, soKhachToiDa, maLP);
        }
        public bool xoaPhong(string maP)
        {
            return phongDAO.Instance.xoaPhong(maP);
        }
        public DataTable DanhSachPhongTheoMaLP(string maLP)
        {
            DataTable dt; 
            try
            {
                dt=  phongDAO.Instance.DanhSachPhongTheoMaLP(maLP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable LayPhongTheoTrangThaiVaMaLoaiPhong(string maLP, int trangThai)
        {
            DataTable dt;
            try
            {
                dt = phongDAO.Instance.LayPhongTheoTrangThaiVaMaLoaiPhong(maLP, trangThai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public List<phongDTO> LayDanhSachPhongTheoTrangThaivaMaLP(string maLP, int trangThai)
        {
            DataTable dt;
            List<phongDTO> ListPhong = new List<phongDTO>();
            dt = phongDAO.Instance.LayPhongTheoTrangThaiVaMaLoaiPhong(maLP, trangThai);
            foreach (DataRow item in dt.Rows)
            {
                ListPhong.Add(new phongDTO(item));
            }
            return ListPhong;
        }
        public List<phongDTO> LayTheoThietBiCoTrongPhong(string maTB)
        {
            return phongDAO.Instance.LayTheoThietBiCoTrongPhong(maTB);
        }
        public List<phongDTO> LayTheoMAPDK(string maPDK)
        {
            return phongDAO.Instance.LayTheoMAPDK(maPDK);
        }

    }
}
