namespace Sorschia.Configuration
{
    public sealed class AppSettingManager : ConfigurationManagerBase<string, object, IAppSettingWriter, IAppSettingReader>
    {
        public AppSettingManager(IAppSettingWriter writer, IAppSettingReader reader) : base(writer, reader)
        {
        }
    }
}
