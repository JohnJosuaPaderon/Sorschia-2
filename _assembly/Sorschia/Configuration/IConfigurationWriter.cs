using System.Collections.Generic;

namespace Sorschia.Configuration
{
    public interface IConfigurationWriter<TId, TValue>
    {
        void Write(Dictionary<TId, TValue> source);
    }
}
