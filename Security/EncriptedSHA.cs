using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class EncriptedSHA
    {
        public static string GenerarHashCodeSecurity(string password)
        {
            UnicodeEncoding codigo = new UnicodeEncoding();

            byte[] ByteTextoOrigen = codigo.GetBytes(password);

            SHA1CryptoServiceProvider hash = new SHA1CryptoServiceProvider();

            byte[] byteHash = hash.ComputeHash(codigo.GetBytes(password));
            return Convert.ToBase64String(byteHash);
        }
    }
}
