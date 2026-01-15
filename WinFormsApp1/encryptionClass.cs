using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class encryptionClass
    {
        private static readonly byte[] key = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456");

        public static string EncryptString(string plainText)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = key;
            aes.IV = iv;
            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new System.IO.MemoryStream();
            using (var cs = new System.Security.Cryptography.CryptoStream(ms, encryptor, System.Security.Cryptography.CryptoStreamMode.Write))
            using (var sw = new System.IO.StreamWriter(cs))
            {
                sw.Write(plainText);
            }
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string DecryptString(string cipher)
        {
            using var aes = System.Security.Cryptography.Aes.Create();
            aes.Key = key;
            aes.IV = iv;
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new System.IO.MemoryStream(Convert.FromBase64String(cipher));
            using var cs = new System.Security.Cryptography.CryptoStream(ms, decryptor, System.Security.Cryptography.CryptoStreamMode.Read);
            using var sr = new System.IO.StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}
