using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class loaiKhachDTO
    {

        private string MaQT { get; set; }
        private string TenNuoc { get; set; }

        public loaiKhachDTO (){}

        public loaiKhachDTO( string maQT, string tenNuoc)
        {
            this.MaQT = MaQT;
            this.TenNuoc = tenNuoc;
        }
        public loaiKhachDTO( DataRow row)
        {
            this.MaQT = row["MAQT"].ToString();
            this.TenNuoc = row["TenNuoc"].ToString();
        }

        public override string ToString()
        {
            return TenNuoc;
        }

        public string maQT
        {
            get
            {
                return MaQT;
            }
            set
            {
                value = MaQT;
            }
        }
        public string tenNuoc
        {
            get
            {
                return TenNuoc;
            }
            set
            {
                value = TenNuoc;
            }
        }
    }
}
