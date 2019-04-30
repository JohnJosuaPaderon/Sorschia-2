using Sorschia.Security;

namespace CryptoTestApp
{
    public sealed class PlatformKeyProvider : IPlatformKeyProvider
    {
        public string PlatformKey { get; } = "sorschia.test";
    }
}
