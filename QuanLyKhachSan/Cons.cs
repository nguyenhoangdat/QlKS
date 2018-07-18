using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyKhachSan
{
    public class Cons
    {
        public static int sizeLeave = 15;


        ///<summary>
        ///Chuyển sang hệ mã asskII mật khẩu 
        /// </summary>
        /// <param name="password"></param>
        /// <return></return>


        public static string hasPass(string PassWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(PassWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            hasPass.Reverse();
            return hasPass;
        }
        ///<summary>
        ///xóa khoảng trắng 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        public static string xoakhoangtrang(string a)
        {
            string s = a.Trim();
            while (s.IndexOf("  ") >= 0)
                s = s.Replace("  ", " ");
            return s;
        }
        public static string Random(int length)
        {
            string result = "";
            char c;
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(ran.Next(65, 87)));
                result += c;
            }
            return result;
        }
      
    }
}
