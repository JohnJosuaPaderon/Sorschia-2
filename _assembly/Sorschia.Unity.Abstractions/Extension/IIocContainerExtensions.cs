using Sorschia.Dependency;
using System;
using Unity.Resolution;

namespace Sorschia.Extension
{
    public static class IIocContainerExtensions
    {
        private static IocContainer GetConcrete(this IIocContainer instance)
        {
            if (instance is IocContainer concrete)
            {
                return concrete;
            }
            else
            {
                throw new InvalidOperationException("Concrete instance for Sorschia.Dependency.IIocContainer doesn't have an access to Unity.IUnityContainer.");
            }
        }

        public static T Resolve<T>(this IIocContainer instance, string name)
        {
            return instance.GetConcrete().Resolve<T>(name);
        }

        public static T Resolve<T>(this IIocContainer instance, string name, params ResolverOverride[] overrides)
        {
            return instance.GetConcrete().Resolve<T>(name, overrides);
        }

        public static T Resolve<T>(this IIocContainer instance, params ResolverOverride[] overrides)
        {
            return instance.GetConcrete().Resolve<T>(overrides);
        }
    }
}
