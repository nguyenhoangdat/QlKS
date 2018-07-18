using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class chucvuDTO
    {
        private string MaCV;
        private string TenChucVu;
        public chucvuDTO() { }
        public chucvuDTO(string maCV, string tenChucVu)
        {
            this.MaCV = maCV;
            this.TenChucVu = tenChucVu;
        }
        public chucvuDTO(DataRow row)
        {
            this.maCV = (string)row["MACV"];
            this.TenChucVu = (string)row["TenChucVu"];
        }
        public override string ToString()
        {
            return tenChucVu;
        }
        public string maCV
        {
            get
            {
                return MaCV;
            }

            set
            {
                MaCV = value;
            }
        }

        public string tenChucVu
        {
            get
            {
                return TenChucVu;
            }

            set
            {
                TenChucVu = value;
            }
        }
    }

}
