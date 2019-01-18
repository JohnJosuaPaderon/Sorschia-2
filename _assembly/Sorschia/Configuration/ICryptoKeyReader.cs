using System.Security;

namespace Sorschia.Configuration
{
    public interface ICryptoKeyReader : IConfigurationReader<string, SecureString>
    {
    }
}
