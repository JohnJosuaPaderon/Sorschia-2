using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class CryptoKeyReader : ConfigurationReaderBase<string, SecureString>, ICryptoKeyReader
    {
        public CryptoKeyReader(CryptoKeyFileProvider fileProvider, ICryptor cryptor, IPlatformKeyProvider platformKeyProvider) : base(fileProvider.FilePath)
        {
            Cryptor = cryptor;
            PlatformKeyProvider = platformKeyProvider;
        }

        private ICryptor Cryptor { get; }
        private IPlatformKeyProvider PlatformKeyProvider { get; }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override SecureString TransformValue(JToken value)
        {
            return SecureStringConverter.Convert(Cryptor.Decrypt(value.ToString(), PlatformKeyProvider.PlatformKey));
        }
    }
}
