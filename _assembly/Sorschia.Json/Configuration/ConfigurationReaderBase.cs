using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sorschia.Validation;
using System.Collections.Generic;
using System.IO;

namespace Sorschia.Configuration
{
    public abstract class ConfigurationReaderBase<TKey, TValue>
    {
        public ConfigurationReaderBase(string filePath)
        {
            Validator.NullOrWhiteSpace(filePath, "File path is required.");
            FilePath = filePath;
        }

        protected string FilePath { get; }

        protected abstract TKey TransformKey(string key);
        protected abstract TValue TransformValue(JToken value);

        public Dictionary<TKey, TValue> Read()
        {
            if (File.Exists(FilePath))
            {
                using (var reader = File.OpenText(FilePath))
                {
                    using (var textReader = new JsonTextReader(reader))
                    {
                        var json = (JObject)JToken.ReadFrom(textReader);
                        var result = new Dictionary<TKey, TValue>();

                        foreach (var item in json)
                        {
                            result.Add(TransformKey(item.Key), TransformValue(item.Value));
                        }

                        return result;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
