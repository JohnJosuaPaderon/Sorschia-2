using Sorschia.Validation;

namespace Sorschia.Configuration
{
    public sealed class CryptoKeyFileProvider
    {
        public CryptoKeyFileProvider(string filePath)
        {
            Validator.NullOrWhiteSpace(filePath, "File path is required.");
            FilePath = filePath;
        }

        public string FilePath { get; }
    }
}
