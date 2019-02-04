using Sorschia.Dependency;
using System;

namespace Sorschia
{
    public static class Global
    {
        private static IIocContainer _iocContainer;
        public static IIocContainer IocContainer
        {
            get => TryGet(ref _iocContainer, _iocContainerInitializer, nameof(IocContainer));
        }

        private static Func<IIocContainer> _iocContainerInitializer;

        private static T TryGet<T>(ref T backingField, Func<T> initializer, string propertyName)
        {
            if (Equals(backingField, default(T)) && initializer != null)
            {
                backingField = initializer();
            }

            return backingField;
        }

        public static void Initialize(Func<IIocContainer> iocContainerInitializer = null)
        {
            _iocContainerInitializer = iocContainerInitializer;
        }
    }
}
