using Sorschia.Validation;

namespace Sorschia.Configuration
{
    public sealed class ConnectionStringFileProvider
    {
        public ConnectionStringFileProvider(string filePath)
        {
            Validator.NullOrWhiteSpace(filePath, "File path is required.");
            FilePath = filePath;
        }

        public string FilePath { get; }
    }
}
