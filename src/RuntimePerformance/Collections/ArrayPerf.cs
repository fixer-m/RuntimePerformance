using BenchmarkDotNet.Attributes;
using RuntimePerformance.Utils;
using System;

namespace RuntimePerformance.Collections
{
    [BenchmarkCategory("Collections")]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ArrayCtor<T>
    {
        [Benchmark]
        public T[] Array_Ctor() => new T[] { };
    }

    [BenchmarkCategory("Collections")]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ArrayIterationFor<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private T[] _array;

        [GlobalSetup]
        public void SetupArray() => _array = ValuesGenerator.ArrayOfUniqueValues<T>(Size);

        [Benchmark]
        public T Array_IterateFor()
        {
            T result = default;
            T[] collection = _array;

            for (int i = 0; i < collection.Length; i++)
                result = collection[i];

            return result;
        }
    }

    [BenchmarkCategory("Collections")]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class ArrayIterationForEach<T>
    {
        [Params(100, 1_000, 10_000)]
        public int Size;

        private T[] _array;

        [GlobalSetup]
        public void SetupArray() => _array = ValuesGenerator.ArrayOfUniqueValues<T>(Size);

        [Benchmark]
        public T Array_IterateForEach()
        {
            T result = default;
            T[] collection = _array;

            for (int i = 0; i < collection.Length; i++)
                result = collection[i];

            return result;
        }
    }
}