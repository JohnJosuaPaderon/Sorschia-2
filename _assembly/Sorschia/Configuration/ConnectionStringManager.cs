using System.Security;

namespace Sorschia.Configuration
{
    public sealed class ConnectionStringManager : ConfigurationManagerBase<string, SecureString, IConnectionStringWriter, IConnectionStringReader>
    {
        public ConnectionStringManager(IConnectionStringWriter writer, IConnectionStringReader reader) : base(writer, reader)
        {
        }
    }
}
