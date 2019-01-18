using Newtonsoft.Json.Linq;
using Sorschia.Security;
using System.Security;

namespace Sorschia.Configuration
{
    internal sealed class ConnectionStringWriter : ConfigurationWriterBase<string, SecureString>, IConnectionStringWriter
    {
        public ConnectionStringWriter(ConnectionStringFileProvider fileProvider) : base(fileProvider.FilePath)
        {
        }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override JToken TransformValue(SecureString value)
        {
            return new JValue(SecureStringConverter.Convert(value));
        }
    }
}
