using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils
{
    internal class Cryptography
    {
        public static string Encrypt(string entry)
        {
            MD5 md5 = MD5.Create();
            byte[] entryBytes = Encoding.UTF8.GetBytes(entry);
            return Convert.ToBase64String(md5.ComputeHash(entryBytes));
        }
    }
}
