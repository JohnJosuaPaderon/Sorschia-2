namespace Sorschia.Configuration
{
    public interface IConfigurationManager<TKey, TValue>
    {
        TValue this[TKey key] { get; set; }
        void Remove(TKey key);
        void Reload();
        void Clear();
        void SaveChanges();
    }
}
