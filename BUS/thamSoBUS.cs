using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class thamSoBUS
    {
        private static thamSoBUS instance;

        public static thamSoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new thamSoBUS();
                return instance;
            }
        }
        private thamSoBUS () { }
        public thamSoDTO layThamSo()
        {
            return thamSoDAO.Instance.layThamSo();
        }
        public bool capNhatThamSo(double tLNNN, double tLNT3)
        {
            return thamSoDAO.Instance.capNhatThamSo(tLNNN, tLNT3);
        }
    }
}
