using System.Security;

namespace Sorschia.Configuration
{
    public interface ICryptoKeyWriter : IConfigurationWriter<string, SecureString>
    {
    }
}
