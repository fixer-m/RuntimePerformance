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
| **Array_IterateFor** |      **.NET 4.8** |   **100** |    **46.25 ns** |  **0.062 ns** |  **0.041 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 |   100 |    39.42 ns |  0.514 ns |  0.340 ns |  0.85 |
| Array_IterateFor | .NET Core 3.1 |   100 |    46.50 ns |  0.111 ns |  0.073 ns |  1.01 |
|                  |               |       |             |           |           |       |
| **Array_IterateFor** |      **.NET 4.8** |  **1000** |   **409.24 ns** |  **1.042 ns** |  **0.689 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 |  1000 |   340.15 ns |  5.757 ns |  3.011 ns |  0.83 |
| Array_IterateFor | .NET Core 3.1 |  1000 |   408.88 ns |  1.174 ns |  0.699 ns |  1.00 |
|                  |               |       |             |           |           |       |
| **Array_IterateFor** |      **.NET 4.8** | **10000** | **4,055.72 ns** |  **4.597 ns** |  **3.041 ns** |  **1.00** |
| Array_IterateFor | .NET Core 2.1 | 10000 | 3,515.57 ns | 47.362 ns | 24.771 ns |  0.87 |
| Array_IterateFor | .NET Core 3.1 | 10000 | 4,063.31 ns | 17.123 ns | 11.326 ns |  1.00 |
