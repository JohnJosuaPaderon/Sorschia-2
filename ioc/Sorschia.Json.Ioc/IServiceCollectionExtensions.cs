using Microsoft.Extensions.DependencyInjection;
using Sorschia.Configuration;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschia2JsonAppSetting(this IServiceCollection instance, string filePath)
        {
            return instance
                .AddSingleton(new AppSettingFileProvider(filePath))
                .AddSingleton<AppSettingManager>()
                .AddSingleton<IAppSettingReader, AppSettingReader>()
                .AddSingleton<IAppSettingWriter, AppSettingWriter>();
        }

        public static IServiceCollection AddSorschia2JsonConnectionString(this IServiceCollection instance, string filePath)
        {
            return instance
                .AddSingleton(new ConnectionStringFileProvider(filePath))
                .AddSingleton<ConnectionStringManager>()
                .AddSingleton<IConnectionStringReader, ConnectionStringReader>()
                .AddSingleton<IConnectionStringWriter, ConnectionStringWriter>();
        }

        public static IServiceCollection AddSorschia2JsonCryptoConnectionString(this IServiceCollection instance, string filePath)
        {
            return instance
                .AddSingleton(new ConnectionStringFileProvider(filePath))
                .AddSingleton<ConnectionStringManager>()
                .AddSingleton<IConnectionStringReader, CryptoConnectionStringReader>()
                .AddSingleton<IConnectionStringWriter, CryptoConnectionStringWriter>();
        }

        public static IServiceCollection AddSorschia2JsonCryptoKey(this IServiceCollection instance, string filePath)
        {
            return instance
                .AddSingleton(new CryptoKeyFileProvider(filePath))
                .AddSingleton<CryptoKeyManager>()
                .AddSingleton<ICryptoKeyReader, CryptoKeyReader>()
                .AddSingleton<ICryptoKeyWriter, CryptoKeyWriter>();
        }
    }
}
