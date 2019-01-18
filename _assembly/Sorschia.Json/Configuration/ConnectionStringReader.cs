using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class ConnectionStringReader : ConfigurationReaderBase<string, SecureString>, IConnectionStringReader
    {
        public ConnectionStringReader(ConnectionStringFileProvider fileProvider) : base(fileProvider.FilePath)
        {
        }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override SecureString TransformValue(JToken value)
        {
            return SecureStringConverter.Convert(value.ToString());
        }
    }
}
