using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RSAKeyGenerator
{
    public sealed class Cryptographer
    {
        private static RSACryptoServiceProvider GenerateRSAProvider(string xml = null, int size = 2048)
        {
            var rsaPro = new RSACryptoServiceProvider(size);
            if (xml != null)
            {
                rsaPro.FromXmlString(xml);
            }

            return rsaPro;
        }

        public static RSAParameters GenerateRSAKeys(bool publicOnly = true)
        {
            var rsaPro = GenerateRSAProvider();
            return rsaPro.ExportParameters(!publicOnly);
        }

        public static List<string> GenerateRSAKeysArray(int size = 2048)
        {
            var rsaPro = GenerateRSAProvider(null, size);
            var publicKey = rsaPro.ToXmlString(false);
            var privateKey = rsaPro.ToXmlString(true);
            return new List<string> { publicKey, privateKey };
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="dataToEncrypt">待加密数据</param>
        /// <returns></returns>
        public static string RSAEncrypt(string dataToEncrypt)
        {
            var encoder = Encoding.UTF8;
            var buffer = encoder.GetBytes(dataToEncrypt);
            return RSAEncrypt(buffer);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="dataToEncrypt">待加密数据</param>
        /// <returns></returns>
        public static string RSAEncrypt(byte[] dataToEncrypt)
        {
            using (RSACryptoServiceProvider rsaPro = GenerateRSAProvider())
            {
                byte[] buffer = rsaPro.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(buffer);
            }
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="encryptedData">待解密数据</param>
        /// <returns></returns>
        public static string RSADecrypt(string encryptedData)
        {
            using (RSACryptoServiceProvider rsaPro = GenerateRSAProvider())
            {
                Encoding encoder = Encoding.UTF8;
                var buffer = Convert.FromBase64String(encryptedData);
                var decryptedBuffer = rsaPro.Decrypt(buffer, false);
                return encoder.GetString(decryptedBuffer);
            }
        }
    }
}