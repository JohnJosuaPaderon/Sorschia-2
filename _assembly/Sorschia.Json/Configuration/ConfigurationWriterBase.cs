using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sorschia.Validation;
using System.Collections.Generic;
using System.IO;

namespace Sorschia.Configuration
{
    public abstract class ConfigurationWriterBase<TKey, TValue>
    {
        public ConfigurationWriterBase(string filePath)
        {
            Validator.NullOrWhiteSpace(filePath, "File path is required.");
            FilePath = filePath;
        }

        protected string FilePath { get; }

        protected abstract string TransformKey(TKey key);
        protected abstract JToken TransformValue(TValue value);

        public void Write(Dictionary<TKey, TValue> source)
        {
            Validator.EmptyIEnumerable(source, "Source is required.");
            var json = new JObject();

            foreach (var pair in source)
            {
                json.Add(TransformKey(pair.Key), TransformValue(pair.Value));
            }

            using (var writer = File.CreateText(FilePath))
            {
                using (var textWriter = new JsonTextWriter(writer))
                {
                    textWriter.Formatting = Formatting.Indented;
                    textWriter.Indentation = 4;
                    json.WriteTo(textWriter);
                }
            }
        }
    }
}
