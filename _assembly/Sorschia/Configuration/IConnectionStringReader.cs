using System.Security;

namespace Sorschia.Configuration
{
    public interface IConnectionStringReader : IConfigurationReader<string, SecureString>
    {
    }
}
