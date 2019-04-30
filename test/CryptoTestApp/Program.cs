using Sorschia;
using Sorschia.Configuration;
using Sorschia.Security;
using System;

namespace CryptoTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorschia 2");
            Console.WriteLine("CryptoTestApp");
            Console.WriteLine();

            Console.WriteLine("Initializing variables...");
            var iocContainerBuilder = new IocContainerBuilder();
            Console.WriteLine("Variables were initialized.");

            Console.WriteLine("Building IOC Container...");
            iocContainerBuilder.Build();
            Console.WriteLine("IOC Container was built.");

            Console.WriteLine("Testing Crypto...");

            var cryptor = Global.IocContainer.Resolve<ICryptor>();
            var cryptoKeyManager = Global.IocContainer.Resolve<CryptoKeyManager>();
            cryptoKeyManager["SAMTING"] = SecureStringConverter.Convert("ASDASD");
            cryptoKeyManager.SaveChanges();
            var x = cryptoKeyManager["default"];
            var cryptoKeyId = "default";
            var cryptoKey = "my-secret";
            var plainText = "sorschia";
            var cipherText = cryptor.Encrypt(plainText, cryptoKey);

            Console.WriteLine("Crypto was tested.");

            Console.ReadKey();
        }
    }
}
