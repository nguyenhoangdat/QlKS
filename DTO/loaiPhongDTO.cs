using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class loaiPhongDTO
    {
        public string MaLP { get; set; }
        public string TenLP { get; set; } 
        public Double Gia { get; set; }

        public loaiPhongDTO () { }

        public loaiPhongDTO (string maLP, string tenLP, Double gia )
        {
            this.MaLP = maLP;
            this.TenLP = tenLP;
            this.Gia = gia;
        }

        public loaiPhongDTO (DataRow row)
        {
            this.MaLP = row["MaLP"].ToString();
            this.TenLP = row["TenLP"].ToString();
            this.Gia = float.Parse(row["Gia"].ToString());
        }
    }
}
