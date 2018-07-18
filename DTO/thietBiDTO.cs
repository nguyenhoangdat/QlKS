using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class thietBiDTO
    {
        private string MATB;
        private string TenTB;

        public thietBiDTO() { }
        
        public thietBiDTO (string maTB, string tenTB)
        {
            this.MATB = maTB;
            this.TenTB = tenTB;
        }
        public thietBiDTO (DataRow row)
        {
            this.MATB = row["MATB"].ToString();
            this.TenTB = row["TenTB"].ToString();
        }
        public override string ToString()
        {
            return TenTB;
        }
        public string maTB
        {
            get
            {
                return MATB;
            }

            set
            {
                MATB = value;
            }
        }

        public string tenTB
        {
            get
            {
                return TenTB;
            }

            set
            {
                TenTB = value;
            }
        }

    }
}
