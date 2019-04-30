using Sorschia.Validation;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Sorschia.Security
{
    public abstract class CryptorBase
    {
        public CryptorBase(int keySize, int derivationIterations, Encoding encoding)
        {
            Validator.LessThanOrEqual(keySize, 0, "Key size is required.");
            Validator.LessThanOrEqual(derivationIterations, 0, "Derivation iterations are required.");
            Validator.Null(encoding, "Encoding is required.");
            KeySize = keySize;
            DerivationIterations = derivationIterations;
            Encoding = encoding;
        }

        protected int KeySize { get; }
        protected int DerivationIterations { get; }
        protected Encoding Encoding { get; }

        public virtual string Encrypt(string plainText, string cryptoKey)
        {
            return Encrypt(plainText, cryptoKey, RandomBytes.Generate(KeySize), RandomBytes.Generate(KeySize));
        }

        public virtual string Encrypt(string plainText, string cryptoKey, byte[] salt, byte[] iv)
        {
            Validator.NullOrWhiteSpace(plainText, "Plain text is required.");
            Validator.NullOrWhiteSpace(cryptoKey, "Crypto key is required.");
            Validator.EmptyIEnumerable(salt, "Salt is required.");
            Validator.EmptyIEnumerable(iv, "IV is required.");
            var bytes = Encoding.GetBytes(plainText);

            using (var rfc2898DeriveBytes = GetCryptoKeyRfc2898DeriveBytes(cryptoKey, salt))
            {
                using (var algorithm = InitializeAlgorithm())
                {
                    using (var encryptor = algorithm.CreateEncryptor(GetCryptoKeyBytes(rfc2898DeriveBytes), iv))
                    {
                        using (var stream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(bytes, 0, bytes.Length);
                                cryptoStream.FlushFinalBlock();

                                var resultBytes = salt.Concat(iv).Concat(stream.ToArray());
                                return Convert.ToBase64String(resultBytes.ToArray());
                            }
                        }
                    }
                }
            }
        }

        public virtual string Decrypt(string cipherText, string cryptoKey)
        {
            Validator.NullOrWhiteSpace(cipherText, "Cipher text is required.");
            Validator.NullOrWhiteSpace(cryptoKey, "Crypto key is required.");
            var bytes = Convert.FromBase64String(cipherText);
            var salt = bytes.Take(KeySize).ToArray();
            var iv = bytes.Skip(KeySize).Take(KeySize).ToArray();
            bytes = bytes.Skip(KeySize * 2).Take(bytes.Length - (KeySize * 2)).ToArray();

            using (var rfc2898DeriveBytes = GetCryptoKeyRfc2898DeriveBytes(cryptoKey, salt))
            {
                using (var algorithm = InitializeAlgorithm())
                {
                    using (var decryptor = algorithm.CreateDecryptor(GetCryptoKeyBytes(rfc2898DeriveBytes), iv))
                    {
                        using (var stream = new MemoryStream(bytes))
                        {
                            using (var cryptoStream = new CryptoStream(stream, decryptor, CryptoStreamMode.Read))
                            {
                                var resultBytes = new byte[bytes.Length];
                                var resultBytesCount = cryptoStream.Read(resultBytes, 0, resultBytes.Length);
                                return Encoding.GetString(resultBytes, 0, resultBytesCount);
                            }
                        }
                    }
                }
            }
        }

        private Rfc2898DeriveBytes GetCryptoKeyRfc2898DeriveBytes(string cryptoKey, byte[] salt)
        {
            return new Rfc2898DeriveBytes(cryptoKey, salt, DerivationIterations);
        }

        private byte[] GetCryptoKeyBytes(Rfc2898DeriveBytes rfc2898DeriveBytes)
        {
            return rfc2898DeriveBytes.GetBytes(KeySize);
        }

        private RijndaelManaged InitializeAlgorithm()
        {
            return new RijndaelManaged
            {
                BlockSize = 128,
                //BlockSize = 256,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
        }
    }
}
