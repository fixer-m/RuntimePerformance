``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-XDNTWG : .NET Framework 4.8 (4.8.4121.0), X64 RyuJIT
  Job-IDDWWU : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-EHAEIO : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|                 Method |       Runtime |  Size |         Mean |     Error |    StdDev | Ratio |
|----------------------- |-------------- |------ |-------------:|----------:|----------:|------:|
| **Dictionary_ContainsKey** |      **.NET 4.8** |   **100** |     **895.4 ns** |   **1.49 ns** |   **0.78 ns** |  **1.00** |
| Dictionary_ContainsKey | .NET Core 2.1 |   100 |     544.2 ns |   1.51 ns |   0.90 ns |  0.61 |
| Dictionary_ContainsKey | .NET Core 3.1 |   100 |     609.4 ns |   9.72 ns |   6.43 ns |  0.68 |
|                        |               |       |              |           |           |       |
| **Dictionary_ContainsKey** |      **.NET 4.8** |  **1000** |   **9,890.5 ns** |  **53.45 ns** |  **31.81 ns** |  **1.00** |
| Dictionary_ContainsKey | .NET Core 2.1 |  1000 |   8,252.4 ns |  81.43 ns |  53.86 ns |  0.84 |
| Dictionary_ContainsKey | .NET Core 3.1 |  1000 |   7,706.2 ns |  45.90 ns |  30.36 ns |  0.78 |
|                        |               |       |              |           |           |       |
| **Dictionary_ContainsKey** |      **.NET 4.8** | **10000** | **122,083.8 ns** | **756.57 ns** | **500.42 ns** |  **1.00** |
| Dictionary_ContainsKey | .NET Core 2.1 | 10000 | 126,300.4 ns | 144.08 ns |  85.74 ns |  1.04 |
| Dictionary_ContainsKey | .NET Core 3.1 | 10000 | 129,909.7 ns | 404.90 ns | 267.82 ns |  1.06 |
