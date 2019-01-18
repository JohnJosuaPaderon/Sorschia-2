using Newtonsoft.Json.Linq;

namespace Sorschia.Configuration
{
    internal sealed class AppSettingReader : ConfigurationReaderBase<string, object>, IAppSettingReader
    {
        public AppSettingReader(AppSettingFileProvider fileProvider) : base(fileProvider.FilePath)
        {
        }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override object TransformValue(JToken value)
        {
            return value;
        }
    }
}
