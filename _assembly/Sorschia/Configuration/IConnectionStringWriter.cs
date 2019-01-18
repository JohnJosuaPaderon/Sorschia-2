using System.Security;

namespace Sorschia.Configuration
{
    public interface IConnectionStringWriter : IConfigurationWriter<string, SecureString>
    {
    }
}
