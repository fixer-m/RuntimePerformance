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
|           Method |       Runtime |  Size |        Mean |     Error |    StdDev | Ratio |
|----------------- |-------------- |------ |------------:|----------:|----------:|------:|
| **Array_IterateFor** |      **.NET 4.8** |   **100** |    **45.86 ns** |  **0.130 ns** |  **0.086 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 |   100 |    45.46 ns |  0.140 ns |  0.083 ns |  0.99 |
| Array_IterateFor | .NET Core 3.1 |   100 |    44.17 ns |  0.216 ns |  0.143 ns |  0.96 |
|                  |               |       |             |           |           |       |
| **Array_IterateFor** |      **.NET 4.8** |  **1000** |   **408.53 ns** |  **0.984 ns** |  **0.651 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 |  1000 |   408.18 ns |  0.975 ns |  0.645 ns |  1.00 |
| Array_IterateFor | .NET Core 3.1 |  1000 |   406.43 ns |  2.400 ns |  1.588 ns |  0.99 |
|                  |               |       |             |           |           |       |
| **Array_IterateFor** |      **.NET 4.8** | **10000** | **4,050.37 ns** |  **8.188 ns** |  **5.416 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 | 10000 | 4,088.64 ns | 24.828 ns | 16.422 ns |  1.01 |
| Array_IterateFor | .NET Core 3.1 | 10000 | 3,689.10 ns | 34.008 ns | 17.787 ns |  0.91 |
