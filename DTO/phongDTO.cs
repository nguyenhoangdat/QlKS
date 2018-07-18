using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class phongDTO
    {
        private string MaP;
        private string TenPhong;
        private int TinhTrang;
        private int SoKhachToiDa;
        private string GhiChu;
        private string MaLP;
        public phongDTO () { }

        public  phongDTO( string maP, string tenPhong, int tinhTrang , int soKhachToiDa, string ghiChu, string maLP)
        {
            this.MaP = maP;
            this.TenPhong = tenPhong;
            this.TinhTrang = tinhTrang;
            this.SoKhachToiDa = soKhachToiDa;
            this.GhiChu = ghiChu;
            this.MaP = maP;
        }
        public phongDTO (DataRow row)
        {
            this.MaP = row["MaP"].ToString();
            this.TenPhong = row["TenPhong"].ToString();
            this.TinhTrang = (int)row["TinhTrang"];
            this.GhiChu = row["GhiChu"].ToString();
            this.soKhachToiDa = (int)row["soKhachToiDa"];
            this.MaLP = row["MALP"].ToString() ;
        }
        public override string ToString()
        {
            return this.TenPhong;
        }
        public string maP
        {
            get
            {
                return MaP;
            }

            set
            {
                MaP = value;
            }
        }

        public string tenPhong
        {
            get
            {
                return TenPhong;
            }

            set
            {
                TenPhong = value;
            }
        }

        public int tinhTrang
        {
            get
            {
                return TinhTrang;
            }

            set
            {
                TinhTrang = value;
            }
        }

        public string ghiChu
        {
            get
            {
                return GhiChu;
            }

            set
            {
                GhiChu = value;
            }
        }

        public int soKhachToiDa
        {
            get
            {
                return SoKhachToiDa;
            }

            set
            {
                SoKhachToiDa = value;
            }
        }

        public string maLP
        {
            get
            {
                return MaLP;
            }

            set
            {
                MaLP = value;
            }
        }
    }
}
