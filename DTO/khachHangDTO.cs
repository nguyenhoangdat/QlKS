using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class khachHangDTO
    {
        private string CMND;
        private string TenKhachHang;

        private int GioiTinh;
        private string SoDienThoai;
        private string DiaChi;
        private string MaQT;

        public khachHangDTO () {} // contructor rỗng

        public khachHangDTO (string cMND, string tenKhachHang, int gioiTinh, string soDienThoai, string diaChi, string maQT)
        {
            this.CMND = cMND;
            this.TenKhachHang = tenKhachHang;
            this.GioiTinh = gioiTinh;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.MaQT = maQT;
        }
        public khachHangDTO (DataRow row)
        {
            this.CMND = row["CMND"].ToString();
            this.TenKhachHang = row["TenKhachHang"].ToString();
            this.GioiTinh = (int)row["GioiTinh"];
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.MaQT = row["MAQT"].ToString();
        }
        public string cMND
        {
            get
            {
                return CMND;
            }

            set
            {
                CMND = value;
            }
        }

        public string tenKhachHang
        {
            get
            {
                return TenKhachHang;
            }

            set
            {
                TenKhachHang = value;
            }
        }

        public int gioiTinh
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

        public string soDienThoai
        {
            get
            {
                return SoDienThoai;
            }

            set
            {
                SoDienThoai = value;
            }
        }

        public string diaChi
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public string maQT
        {
            get
            {
                return MaQT;
            }

            set
            {
                MaQT = value;
            }
        }
    }
}
