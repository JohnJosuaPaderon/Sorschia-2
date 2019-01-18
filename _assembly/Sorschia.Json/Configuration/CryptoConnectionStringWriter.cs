using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class CryptoConnectionStringWriter : ConfigurationWriterBase<string, SecureString>, IConnectionStringWriter
    {
        public CryptoConnectionStringWriter(ConnectionStringFileProvider fileProvider, ICryptor cryptor, IConnectionStringCryptoKeyProvider cryptoKeyProvider) : base(fileProvider.FilePath)
        {
            Cryptor = cryptor;
            CryptoKeyProvider = cryptoKeyProvider;
        }

        private ICryptor Cryptor { get; }
        private IConnectionStringCryptoKeyProvider CryptoKeyProvider { get; }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override JToken TransformValue(SecureString value)
        {
            return new JValue(Cryptor.Encrypt(SecureStringConverter.Convert(value), SecureStringConverter.Convert(CryptoKeyProvider.CryptoKey)));
        }
    }
}
