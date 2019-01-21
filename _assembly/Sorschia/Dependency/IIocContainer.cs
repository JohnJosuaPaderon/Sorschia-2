namespace Sorschia.Dependency
{
    public interface IIocContainer
    {
        T Resolve<T>();
    }
}
