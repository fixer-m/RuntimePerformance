``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-RISTTO : .NET Framework 4.8 (4.8.4075.0), X64 RyuJIT
  Job-OWFTDA : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-GIGXFX : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|              Method |       Runtime |  Size |         Mean |       Error |      StdDev | Ratio |
|-------------------- |-------------- |------ |-------------:|------------:|------------:|------:|
| **Dictionary_GetValue** |      **.NET 4.8** |   **100** |     **967.5 ns** |     **8.82 ns** |     **5.25 ns** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 |   100 |     636.6 ns |     2.61 ns |     1.55 ns |  0.66 |
| Dictionary_GetValue | .NET Core 3.1 |   100 |     641.5 ns |     0.86 ns |     0.45 ns |  0.66 |
|                     |               |       |              |             |             |       |
| **Dictionary_GetValue** |      **.NET 4.8** |  **1000** |  **10,660.3 ns** |    **32.31 ns** |    **19.23 ns** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 |  1000 |  11,258.3 ns |    80.47 ns |    53.23 ns |  1.06 |
| Dictionary_GetValue | .NET Core 3.1 |  1000 |   9,433.0 ns |    67.74 ns |    44.80 ns |  0.88 |
|                     |               |       |              |             |             |       |
| **Dictionary_GetValue** |      **.NET 4.8** | **10000** | **133,020.1 ns** | **1,168.54 ns** |   **695.38 ns** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 | 10000 | 143,140.9 ns | 1,774.51 ns | 1,173.73 ns |  1.08 |
| Dictionary_GetValue | .NET Core 3.1 | 10000 | 140,359.3 ns | 1,906.13 ns | 1,260.79 ns |  1.06 |
