using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaPDK { get; set; }   
        public string MaNV { get; set; }
        public double SoNgay { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double TongTien { get; set; }

        public string MaP { get; set; } 

        public HoaDonDTO() { }

        public HoaDonDTO(string maHD, string maPDK, string maNV, double soNgay, DateTime ngayThanhToan, double tongTien, string maP)
        {
            this.MaHD = maHD;
            this.MaPDK = maPDK;
            this.MaNV = maNV;
            this.SoNgay = SoNgay;
            this.NgayThanhToan = NgayThanhToan;
            this.TongTien = TongTien;
            this.MaP = maP;
        }

        public HoaDonDTO(DataRow row)
        {
            this.MaHD = (string)row["MAHD"];
            this.MaPDK = (string)row["MAPDK"];
            this.MaNV = (string)row["MANV"];
            this.SoNgay = float.Parse(row["SoNgay"].ToString());
            this.NgayThanhToan = (DateTime)row["NgayThanhToan"];
            this.TongTien = float.Parse(row["TongTien"].ToString());
            this.MaP = (string)row["MAP"];
        }

    }
}
