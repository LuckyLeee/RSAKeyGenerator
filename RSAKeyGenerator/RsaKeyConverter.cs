using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAKeyGenerator
{
    public static class RsaKeyConverter
    {
        public static AsymmetricCipherKeyPair GetKeyPair(this RSA rsa)
        {
            try
            {
                return DotNetUtilities.GetRsaKeyPair(rsa);
            }
            catch
            {
                return null;
            }
        }

        public static RsaKeyParameters GetPublicKey(this RSA rsa)
        {
            try
            {
                return DotNetUtilities.GetRsaPublicKey(rsa);
            }
            catch
            {
                return null;
            }
        }


        public static string XmlToPem(string xml)
        {
            using (var rsa = RSA.Create())
            {
                rsa.FromXmlString(xml);

                var keyPair = rsa.GetKeyPair(); // try get private and public key pair
                if (keyPair != null) // if XML RSA key contains private key
                {
                    var privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keyPair.Private);
                    return FormatPem(Convert.ToBase64String(privateKeyInfo.GetEncoded()), "PRIVATE KEY");
                }

                var publicKey = rsa.GetPublicKey(); // try get public key
                if (publicKey != null) // if XML RSA key contains public key
                {
                    var publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
                    return FormatPem(Convert.ToBase64String(publicKeyInfo.GetEncoded()), "PUBLIC KEY");
                }
            }

            throw new InvalidKeyException("Invalid RSA Xml Key");
        }

        public static async Task<string> XmlToPemAsync(string xml)
        {
            return await Task.Run(() => XmlToPem(xml));
        }

        private static string FormatPem(string pem, string keyType)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"-----BEGIN {keyType}-----");

            int line = 1, width = 64;

            while ((line - 1) * width < pem.Length)
            {
                int startIndex = (line - 1) * width;
                int len = line * width > pem.Length ? pem.Length - startIndex : width;
                sb.AppendLine(pem.Substring(startIndex, len));
                line++;
            }

            sb.Append($"-----END {keyType}-----");
            return sb.ToString();
        }

        public static string PemToXml(string pem)
        {
            if (pem.StartsWith("-----BEGIN RSA PRIVATE KEY-----")
                || pem.StartsWith("-----BEGIN PRIVATE KEY-----"))
            {
                return GetXmlRsaKey(pem, obj =>
                {
                    if ((obj as RsaPrivateCrtKeyParameters) != null)
                        return DotNetUtilities.ToRSA(obj as RsaPrivateCrtKeyParameters);
                    var keyPair = obj as AsymmetricCipherKeyPair;
                    return DotNetUtilities.ToRSA(keyPair.Private as RsaPrivateCrtKeyParameters);
                }, rsa => rsa.ToXmlString(true));
            }

            if (pem.StartsWith("-----BEGIN PUBLIC KEY-----"))
            {
                return GetXmlRsaKey(pem, obj =>
                {
                    var publicKey = obj as RsaKeyParameters;
                    return DotNetUtilities.ToRSA(publicKey);
                }, rsa => rsa.ToXmlString(false));
            }

            throw new InvalidKeyException("Unsupported PEM format...");
        }

        public static async Task<string> PemToXmlAsync(string pem)
        {
            return await Task.Run(() => PemToXml(pem));
        }

        private static string GetXmlRsaKey(string pem, Func<object, RSA> getRsa, Func<RSA, string> getKey)
        {
            using (var ms = new MemoryStream())
            using (var sw = new StreamWriter(ms))
            using (var sr = new StreamReader(ms))
            {
                sw.Write(pem);
                sw.Flush();
                ms.Position = 0;
                var pr = new PemReader(sr);
                var keyPair = pr.ReadObject();
                using (var rsa = getRsa(keyPair))
                {
                    var xml = getKey(rsa);
                    return xml;
                }
            }
        }
    }
}