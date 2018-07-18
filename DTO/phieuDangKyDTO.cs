using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class phieuDangKyDTO
    {
        public string MaPDK { get; set; }
        public string CMND { get; set; }
        public string MaNV { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public DateTime ThoiGianDi { get; set; }
        public int TrangThai { get; set; }

        public phieuDangKyDTO ( ) { }
        public phieuDangKyDTO(string maPDK, string cMND, string maNV, DateTime thoiGianDen, DateTime thoiGianDi, int trangThai)
        {
            this.MaPDK = maPDK;
            this.CMND = cMND;
            this.MaNV = maNV;
            this.ThoiGianDen = thoiGianDen;
            this.ThoiGianDi = thoiGianDi;
            this.TrangThai = trangThai;
        }
        public phieuDangKyDTO(DataRow row)
        {
            this.MaPDK = (string)row["MAPDK"];
            this.CMND = (string)row["CMND"];
            this.MaNV = (string)row["MANV"];
            this.ThoiGianDen = (DateTime)row["ThoiGianDen"];
            this.ThoiGianDi = (DateTime)row["ThoiGianDi"];
            this.TrangThai = (int)row["TrangThai"];
        }

    }
}
