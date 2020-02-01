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
|               Method |       Runtime |  Size |        Mean |     Error |    StdDev | Ratio |
|--------------------- |-------------- |------ |------------:|----------:|----------:|------:|
| **Array_IterateForEach** |      **.NET 4.8** |   **100** |    **45.84 ns** |  **0.109 ns** |  **0.072 ns** |  **1.00** |
| Array_IterateForEach | .NET Core 2.1 |   100 |    45.45 ns |  0.169 ns |  0.112 ns |  0.99 |
| Array_IterateForEach | .NET Core 3.1 |   100 |    44.04 ns |  0.141 ns |  0.093 ns |  0.96 |
|                      |               |       |             |           |           |       |
| **Array_IterateForEach** |      **.NET 4.8** |  **1000** |   **408.00 ns** |  **1.099 ns** |  **0.727 ns** |  **1.00** |
| Array_IterateForEach | .NET Core 2.1 |  1000 |   408.65 ns |  1.409 ns |  0.932 ns |  1.00 |
| Array_IterateForEach | .NET Core 3.1 |  1000 |   407.07 ns |  0.771 ns |  0.510 ns |  1.00 |
|                      |               |       |             |           |           |       |
| **Array_IterateForEach** |      **.NET 4.8** | **10000** | **4,050.65 ns** |  **9.680 ns** |  **6.403 ns** |  **1.00** |
| Array_IterateForEach | .NET Core 2.1 | 10000 | 4,050.51 ns |  5.151 ns |  3.407 ns |  1.00 |
| Array_IterateForEach | .NET Core 3.1 | 10000 | 3,697.88 ns | 54.923 ns | 28.726 ns |  0.91 |
