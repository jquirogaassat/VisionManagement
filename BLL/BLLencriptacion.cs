using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL
{
    public class BLLencriptacion
    {
        public static string IV = "aloqzmwixnsjdheu";//128

        public static string Key = "aloqzmwixnsjdheualoqzmwixnsjdheu";//256

        public static string Salt = "asd";

        //metodo reversible
        public string encriptarAES(string pDesencriptado)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pDesencriptado);

            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

            aesCryptoServiceProvider.BlockSize = 128;

            aesCryptoServiceProvider.KeySize = 256;

            aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(Key);

            aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);

            aesCryptoServiceProvider.Mode = CipherMode.CBC;

            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;

            ICryptoTransform icrypt = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);

            byte[] enc = icrypt.TransformFinalBlock(bytes, 0, bytes.Length);

            icrypt.Dispose();


            return Convert.ToBase64String(enc);
        }


        public string desencriptarAes(string pEncriptado)
        {
            try
            {
                byte[] desencriptar = Convert.FromBase64String(pEncriptado);
                AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();

                aesCryptoServiceProvider.BlockSize = 128;
                aesCryptoServiceProvider.KeySize = 256;
                aesCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(Key);
                aesCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(IV);
                aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                aesCryptoServiceProvider.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key,
                                                                                  aesCryptoServiceProvider.IV);

                byte[] dec = icrypt.TransformFinalBlock(desencriptar, 0, desencriptar.Length);
                icrypt.Dispose();

                return Encoding.UTF8.GetString(dec);
            }
            catch (Exception)
            {

                return ("Error en la base de datos");
            }
        }

        public string encriptarSha256(string str)
        {
            

            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
