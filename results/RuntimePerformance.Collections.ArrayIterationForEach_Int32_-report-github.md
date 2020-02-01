``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-HMONJZ : .NET Framework 4.8 (4.8.4075.0), X64 RyuJIT
  Job-RANOSB : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-AJVGBG : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|               Method |       Runtime |  Size |        Mean |      Error |     StdDev | Ratio | RatioSD |
|--------------------- |-------------- |------ |------------:|-----------:|-----------:|------:|--------:|
| **Array_IterateForEach** |      **.NET 4.8** |   **100** |    **46.54 ns** |   **0.363 ns** |   **0.190 ns** |  **1.00** |    **0.00** |
| Array_IterateForEach | .NET Core 2.1 |   100 |    39.10 ns |   0.222 ns |   0.147 ns |  0.84 |    0.01 |
| Array_IterateForEach | .NET Core 3.1 |   100 |    46.18 ns |   0.137 ns |   0.091 ns |  0.99 |    0.00 |
|                      |               |       |             |            |            |       |         |
| **Array_IterateForEach** |      **.NET 4.8** |  **1000** |   **410.34 ns** |   **2.896 ns** |   **1.723 ns** |  **1.00** |    **0.00** |
| Array_IterateForEach | .NET Core 2.1 |  1000 |   347.12 ns |  12.048 ns |  11.270 ns |  0.84 |    0.03 |
| Array_IterateForEach | .NET Core 3.1 |  1000 |   408.07 ns |   0.604 ns |   0.316 ns |  0.99 |    0.00 |
|                      |               |       |             |            |            |       |         |
| **Array_IterateForEach** |      **.NET 4.8** | **10000** | **4,058.78 ns** |  **10.933 ns** |   **5.718 ns** |  **1.00** |    **0.00** |
| Array_IterateForEach | .NET Core 2.1 | 10000 | 3,736.57 ns | 247.031 ns | 231.073 ns |  0.93 |    0.06 |
| Array_IterateForEach | .NET Core 3.1 | 10000 | 4,050.61 ns |   5.588 ns |   3.696 ns |  1.00 |    0.00 |
