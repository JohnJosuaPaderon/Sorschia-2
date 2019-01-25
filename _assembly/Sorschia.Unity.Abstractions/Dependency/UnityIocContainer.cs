using Unity;
using Unity.Resolution;

namespace Sorschia.Dependency
{
    public sealed class UnityIocContainer : IIocContainer
    {
        public UnityIocContainer(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        private readonly IUnityContainer _unityContainer;

        public T Resolve<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public T Resolve<T>(string name)
        {
            return _unityContainer.Resolve<T>(name);
        }

        public T Resolve<T>(string name, params ResolverOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(name, overrides);
        }

        public T Resolve<T>(params ResolverOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
