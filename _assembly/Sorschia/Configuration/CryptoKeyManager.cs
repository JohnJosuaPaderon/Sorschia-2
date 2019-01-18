using System.Security;

namespace Sorschia.Configuration
{
    public sealed class CryptoKeyManager : ConfigurationManagerBase<string, SecureString, ICryptoKeyWriter, ICryptoKeyReader>
    {
        public CryptoKeyManager(ICryptoKeyWriter writer, ICryptoKeyReader reader) : base(writer, reader)
        {
        }
    }
}
