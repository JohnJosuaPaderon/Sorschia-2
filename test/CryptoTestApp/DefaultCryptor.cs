using Sorschia.Security;
using System.Text;

namespace CryptoTestApp
{
    public sealed class DefaultCryptor : CryptorBase, ICryptor
    {
        private const int KEY_SIZE = 16;
        private const int DERIVATION_ITERATIONS = 1000;

        public DefaultCryptor() : base(KEY_SIZE, DERIVATION_ITERATIONS, Encoding.UTF8)
        {
        }
    }
}
