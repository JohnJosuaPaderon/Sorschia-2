using Newtonsoft.Json.Linq;

namespace Sorschia.Configuration
{
    internal sealed class AppSettingWriter : ConfigurationWriterBase<string, object>, IAppSettingWriter
    {
        public AppSettingWriter(AppSettingFileProvider fileProvider) : base(fileProvider.FilePath)
        {
        }

        protected override string TransformKey(string key)
        {
            return key;
        }

        protected override JToken TransformValue(object value)
        {
            return new JValue(value);
        }
    }
}
