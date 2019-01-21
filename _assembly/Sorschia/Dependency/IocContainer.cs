using System;

namespace Sorschia.Dependency
{
    internal sealed class IocContainer : IIocContainer
    {
        public IocContainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider _serviceProvider;

        public T Resolve<T>()
        {
            return (T)_serviceProvider.GetService(typeof(T));
        }
    }
}
