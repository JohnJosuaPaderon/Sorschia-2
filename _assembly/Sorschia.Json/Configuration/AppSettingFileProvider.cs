using Sorschia.Validation;

namespace Sorschia.Configuration
{
    public sealed class AppSettingFileProvider
    {
        public AppSettingFileProvider(string filePath)
        {
            Validator.NullOrWhiteSpace(filePath, "File path is required.");
            FilePath = filePath;
        }

        public string FilePath { get; }
    }
}
