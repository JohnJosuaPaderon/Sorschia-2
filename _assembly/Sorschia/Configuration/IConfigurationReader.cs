using System.Collections.Generic;

namespace Sorschia.Configuration
{
    public interface IConfigurationReader<TId, TValue>
    {
        Dictionary<TId, TValue> Read();
    }
}
