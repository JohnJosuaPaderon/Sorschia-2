using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class CryptoKeyWriter : ConfigurationWriterBase<string, SecureString>, ICryptoKeyWriter
    {
        public CryptoKeyWriter(CryptoKeyFileProvider fileProvider, ICryptor cryptor, IPlatformKeyProvider platformKeyProvider) : base(fileProvider.FilePath)
        {
            Cryptor = cryptor;
        }

        private ICryptor Cryptor { get; }
        private IPlatformKeyProvider PlatformKeyProvider { get; }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override JToken TransformValue(SecureString value)
        {
            return new JValue(Cryptor.Encrypt(SecureStringConverter.Convert(value), PlatformKeyProvider.PlatformKey));
        }
    }
}
