using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class CryptoConnectionStringReader : ConfigurationReaderBase<string, SecureString>, IConnectionStringReader
    {
        public CryptoConnectionStringReader(ConnectionStringFileProvider fileProvider, ICryptor cryptor, IConnectionStringCryptoKeyProvider cryptoKeyProvider) : base(fileProvider.FilePath)
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

        protected override SecureString TransformValue(JToken value)
        {
            return SecureStringConverter.Convert(Cryptor.Decrypt(value.ToString(), SecureStringConverter.Convert(CryptoKeyProvider.CryptoKey)));
        }
    }
}
