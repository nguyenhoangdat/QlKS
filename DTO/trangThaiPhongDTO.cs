using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class trangThaiPhongDTO
    {
        private int MaTrangThai;
        private string TenTrangThai;

        public trangThaiPhongDTO(int maTrangThai, string tenTrangThai)
        {
            this.MaTrangThai = maTrangThai;
            this.TenTrangThai = tenTrangThai;
        }
        public override string ToString()
        {
            return this.TenTrangThai;
        }
        public int maTrangthai
        {
            get
            {
                return MaTrangThai;
            }
            set
            {
                value = MaTrangThai;
            }
        }
        public string tenTrangThai
        {
            get
            {
                return TenTrangThai;
            }
            set
            {
                value = TenTrangThai ;
            }
        }


    }
}
