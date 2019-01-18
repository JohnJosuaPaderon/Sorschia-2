using Sorschia.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Configuration
{
    public abstract class ConfigurationManagerBase<TKey, TValue, TWriter, TReader>
        where TWriter : IConfigurationWriter<TKey, TValue>
        where TReader : IConfigurationReader<TKey, TValue>
    {
        public ConfigurationManagerBase(TWriter writer, TReader reader)
        {
            Source = new Dictionary<TKey, TValue>();
            Writer = writer;
            Reader = reader;
        }

        protected Dictionary<TKey, TValue> Source { get; }
        protected TWriter Writer { get; }
        protected TReader Reader { get; }
        protected bool IsLoaded { get; private set; }

        public TValue this[TKey key]
        {
            get
            {
                Validator.Default(key, "Key is required.");
                TryLoad();
                return Source.ContainsKey(key) ? Source[key] : default(TValue);
            }
            set
            {
                Validator.Default(key, "Key is required.");
                TryLoad();

                if (Source.ContainsKey(key))
                {
                    Source[key] = value;
                }
                else
                {
                    Source.Add(key, value);
                }
            }
        }

        public void Remove(TKey key)
        {
            Validator.Default(key, "Key is required.");
            TryLoad();

            if (Source.ContainsKey(key))
            {
                Source.Remove(key);
            }
        }

        public void Clear()
        {
            Source.Clear();
        }

        public void Reload()
        {
            IsLoaded = false;
        }

        private void TryLoad()
        {
            if (!IsLoaded)
            {
                var result = Reader.Read();
                Source.Clear();

                if (result != null && result.Any())
                {
                    foreach (var pair in result)
                    {
                        Validator.Default(pair.Key, "Key is required.");

                        if (Source.ContainsKey(pair.Key))
                        {
                            throw new Exception("Duplicate key.");
                        }
                        else
                        {
                            Source.Add(pair.Key, pair.Value);
                        }
                    }
                }

                IsLoaded = true;
            }
        }

        public void SaveChanges()
        {
            if (Source.Any())
            {
                var data = new Dictionary<TKey, TValue>();

                foreach (var pair in Source)
                {
                    data.Add(pair.Key, pair.Value);
                }

                Writer.Write(data);
            }
        }
    }
}
