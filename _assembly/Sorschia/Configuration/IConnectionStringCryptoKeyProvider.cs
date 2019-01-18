using System.Security;

namespace Sorschia.Configuration
{
    public interface IConnectionStringCryptoKeyProvider
    {
        SecureString CryptoKey { get; }
    }
}
