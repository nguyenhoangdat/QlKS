using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class nhanvienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MatKhauDangNhap { get; set; }
        public string MaCV { get; set; }

        public nhanvienDTO() {  } // contructor rỗng
        public nhanvienDTO(string maNV, string tenNV, int gioiTinh,DateTime ngaySinh, string sDT, string diaChi, string matKhauDangNhap, string maCV)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.MatKhauDangNhap = matKhauDangNhap;
            this.MaCV = maCV;
        }
        public nhanvienDTO(DataRow row)
        {
           this.MaNV = row["MaNV"].ToString();
           this.TenNV = (string)row["TenNv"];
           this.GioiTinh = (int)row["GioiTinh"];
           this.SDT = (string)row["SDT"];
           this.NgaySinh = (DateTime)row["NgaySinh"];
           this.DiaChi = (string)row["DiaChi"];
           this.MatKhauDangNhap = (string)row["MatKhauDangNhap"];
           this.MaCV = (string)row["MACV"];
        }
    }
}
