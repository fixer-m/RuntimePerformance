using BenchmarkDotNet.Attributes;
using RuntimePerformance.Utils;
using System.Collections.Generic;
using System.Linq;

namespace RuntimePerformance.Collections
{
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class DictionaryCtor<T>
    {
        [Benchmark]
        public Dictionary<T, T> Dictionary_Ctor() => new Dictionary<T, T>();
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class DictionaryAdd<T>
    {
        private T[] _uniqueValues;

        [Params(100, 1_000, 10_000)]
        public int Size;

        [GlobalSetup]
        public void Setup() => _uniqueValues = ValuesGenerator.ArrayOfUniqueValues<T>(Size);

        [Benchmark]
        public Dictionary<T, T> Dictionary_Add()
        {
            var collection = new Dictionary<T, T>(Size);
            var uniqueValues = _uniqueValues;

            for (int i = 0; i < uniqueValues.Length; i++)
                collection.Add(uniqueValues[i], uniqueValues[i]);

            return collection;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class DictionaryGetValue<T>
    {
        private Dictionary<T, T> _dictionary;
        private T[] _values;

        [Params(100, 1_000, 10_000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            _values = ValuesGenerator.ArrayOfUniqueValues<T>(Size);
            _dictionary = _values.ToDictionary(i => i);
        }

        [Benchmark]
        public T Dictionary_GetValue()
        {
            Dictionary<T, T> collection = _dictionary;
            T[] values = _values;

            T result = default;

            for (int i = 0; i < values.Length; i++)
                result = collection[values[i]];

            return result;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class DictionaryContainsKey<T>
    {
        private Dictionary<T, T> _dictionary;
        private T[] _values;

        [Params(100, 1_000, 10_000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            _values = ValuesGenerator.ArrayOfUniqueValues<T>(Size);
            _dictionary = _values.ToDictionary(i => i);
        }

        [Benchmark]
        public bool Dictionary_ContainsKey()
        {
            bool result = false;
            var collection = _dictionary;
            var values = _values;

            for (int i = 0; i < values.Length; i++)
                result ^= collection.ContainsKey(values[i]);

            return result;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class DictionaryContainsValue<T>
    {
        private Dictionary<T, T> _dictionary;
        private T[] _values;

        [Params(100, 1_000, 10_000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            _values = ValuesGenerator.ArrayOfUniqueValues<T>(Size);
            _dictionary = _values.ToDictionary(i => i);
        }

        [Benchmark]
        public int Dictionary_ContainsValue()
        {
            Dictionary<T, T> collection = _dictionary;
            T[] values = _values;

            int count = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (collection.ContainsValue(values[i]))
                    count++;
            }

            return count;
        }
    }
}