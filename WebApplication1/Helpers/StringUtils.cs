using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication1.Helpers
{
    public class StringUtils
    {
        public static string Md5(string strInput)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] input = Encoding.Default.GetBytes(strInput);
            byte[] ouput = md5.ComputeHash(input);
            string ret = BitConverter.ToString(ouput).Replace("-", "");
            return ret;
        }
    }
}