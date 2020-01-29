using BenchmarkDotNet.Attributes;
using RuntimePerformance.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RuntimePerformance.Collections
{
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListCtor<T>
    {
        [Benchmark]
        public List<T> List_Ctor() => new List<T>();
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListIterationFor<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private List<T> _list;

        [GlobalSetup]
        public void Setup() => _list = new List<T>(ValuesGenerator.ArrayOfUniqueValues<T>(Size));

        [Benchmark]
        public T List_IterateFor()
        {
            T result = default;
            List<T> collection = _list;

            for (int i = 0; i < collection.Count; i++)
                result = collection[i];

            return result;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListIterationForEach<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private List<T> _list;

        [GlobalSetup]
        public void Setup() => _list = new List<T>(ValuesGenerator.ArrayOfUniqueValues<T>(Size));

        [Benchmark]
        public T List_IterateForEach()
        {
            T result = default;
            List<T> collection = _list;

            foreach (var item in collection)
                result = item;

            return result;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListAdd<T>
    {
        private T[] _uniqueValues;

        [Params(100, 1_000, 10_000)]
        public int Size;

        [GlobalSetup]
        public void Setup() => _uniqueValues = ValuesGenerator.ArrayOfUniqueValues<T>(Size);

        [Benchmark]
        public List<T> List_Add()
        {
            List<T> collection = new List<T>(Size);
            T[] uniqueValues = _uniqueValues;

            for (int i = 0; i < uniqueValues.Length; i++)
                collection.Add(uniqueValues[i]);

            return collection;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListContains<T> where T : IEquatable<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private List<T> _list;
        private T[] _lookupValues;

        [GlobalSetup]
        public void Setup()
        {
            var uniqueValues = ValuesGenerator.ArrayOfUniqueValues<T>(Size * 2);
            _list = uniqueValues.Take(Size).ToList();
            _lookupValues = uniqueValues.Skip(Size).ToArray();
        }

        [Benchmark]
        public int List_Contains()
        {
            int count = 0;
            List<T> collection = _list;
            T[] array = _lookupValues;

            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]))
                    count++;
            }

            return count;
        }
    }

    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ListIndexOf<T> where T : IEquatable<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private List<T> _list;
        private T[] _lookupValues;

        [GlobalSetup]
        public void Setup()
        {
            var uniqueValues = ValuesGenerator.ArrayOfUniqueValues<T>(Size * 2);
            _list = uniqueValues.Take(Size).ToList();
            _lookupValues = uniqueValues.Skip(Size).ToArray();
        }

        [Benchmark]
        public int List_IndexOf()
        {
            int count = 0;
            List<T> collection = _list;
            T[] array = _lookupValues;

            for (int i = 0; i < array.Length; i++)
            {
                if (collection.IndexOf(array[i]) > -1)
                    count++;
            }

            return count;
        }
    }
}