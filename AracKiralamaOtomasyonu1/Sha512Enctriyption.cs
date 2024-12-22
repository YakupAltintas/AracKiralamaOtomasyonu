using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace AracKiralamaOtomasyonu1
{
    class Sha512Enctriyption
    {
        public static string SHA512Enctriyption(string sifrelenecekMetin)
        {
            SHA512 sha512Hash = SHA512.Create();
            byte[] dizi = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(sifrelenecekMetin));
            dizi = sha512Hash.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            sb.Append(item.ToString("x1").ToLower());
            return sb.ToString();
        }
    }
}
