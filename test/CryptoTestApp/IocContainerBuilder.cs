using Microsoft.Extensions.DependencyInjection;
using Sorschia;
using Sorschia.Dependency;
using Sorschia.Security;
using System.IO;

namespace CryptoTestApp
{
    public sealed class IocContainerBuilder
    {
        public void Build()
        {
            var serviceProvider = new ServiceCollection()
                .AddSorschia2JsonCryptoKey(Path.Combine(Directory.GetCurrentDirectory(), "crypto_key.json"))
                .AddSingleton<ICryptor, DefaultCryptor>()
                .AddSingleton<IPlatformKeyProvider, PlatformKeyProvider>()
                .BuildServiceProvider();

            Global.Initialize(() => new IocContainer(serviceProvider));
        }
    }
}
