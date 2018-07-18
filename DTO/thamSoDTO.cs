using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class thamSoDTO
    {
        private double TyLePhuThuKhachThu3;
        private double TyLePhuThuKhachNuocNgoai;
        public thamSoDTO() { }
        public thamSoDTO(double tyLePhuThuKhachThu3, double tyLePhuThuKhachNuocNgoai)
        {
            this.TyLePhuThuKhachNuocNgoai = tyLePhuThuKhachNuocNgoai;
            this.TyLePhuThuKhachThu3 = tyLePhuThuKhachThu3;
        }
        public thamSoDTO(DataRow row)
        {
            this.TyLePhuThuKhachThu3 = double.Parse(row["TyLePhuThuKhachThu3"].ToString());
            this.TyLePhuThuKhachNuocNgoai = double.Parse(row["TyLePhuThuKhachNuocNgoai"].ToString());
        }
        public double tyLePhuThuKhachThu3
        {
            get
            {
                return TyLePhuThuKhachThu3;
            }

            set
            {
                TyLePhuThuKhachThu3 = value;
            }
        }

        public double tyLePhuThuKhachNuocNgoai
        {
            get
            {
                return TyLePhuThuKhachNuocNgoai;
            }

            set
            {
                TyLePhuThuKhachNuocNgoai = value;
            }
        }
    }
}
