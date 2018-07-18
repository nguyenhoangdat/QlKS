using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    // chi tiết phòng thiết bị 
    public class CTPTBDTO
    {
        public string MaLP { get; set; }

        public string MaTB { get; set; }
        public string TenTB { get; set; }
        public int SoLuong { get; set; }


        public CTPTBDTO () { }

        public CTPTBDTO (string maLP, string maTB, string tenTB, int soLuong)
        {
            this.MaLP = maLP;
            this.MaTB = maTB;
            this.TenTB = tenTB;
            this.SoLuong = soLuong;
        }
        public CTPTBDTO (DataRow row)
        {
            this.MaLP = row["MALP"].ToString();
            this.MaTB = row["MATB"].ToString();
            this.TenTB = row["TenTB"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
