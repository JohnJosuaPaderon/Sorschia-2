using Sorschia.Dependency;
using System;

namespace Sorschia
{
    public static class Global
    {
        private static IIocContainer _iocContainer;
        public static IIocContainer IocContainer
        {
            get => TryGet(_iocContainer, nameof(IocContainer));
        }

        private static T TryGet<T>(T backingField, string propertyName)
        {
            if (Equals(backingField, default(T)))
            {
                throw new InvalidOperationException($"Sorschia.Global.{propertyName} was not initialized.");
            }
            else
            {
                return backingField;
            }
        }

        public static void Initialize(IIocContainer iocContainer = null)
        {
            _iocContainer = iocContainer;
        }
    }
}
