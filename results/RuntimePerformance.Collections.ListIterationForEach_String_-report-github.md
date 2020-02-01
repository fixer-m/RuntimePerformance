``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-NQUFEE : .NET Framework 4.8 (4.8.4075.0), X64 RyuJIT
  Job-PEORHL : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-VUFXNK : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|              Method |       Runtime |  Size |        Mean |     Error |    StdDev | Ratio |
|-------------------- |-------------- |------ |------------:|----------:|----------:|------:|
| **List_IterateForEach** |      **.NET 4.8** |   **100** |    **842.3 ns** |   **2.72 ns** |   **1.80 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 |   100 |    669.7 ns |   2.07 ns |   1.37 ns |  0.80 |
| List_IterateForEach | .NET Core 3.1 |   100 |    610.5 ns |   3.80 ns |   2.51 ns |  0.72 |
|                     |               |       |             |           |           |       |
| **List_IterateForEach** |      **.NET 4.8** |  **1000** |  **8,046.3 ns** |  **36.51 ns** |  **24.15 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 |  1000 |  6,465.0 ns |  15.26 ns |  10.09 ns |  0.80 |
| List_IterateForEach | .NET Core 3.1 |  1000 |  5,886.3 ns |  14.65 ns |   9.69 ns |  0.73 |
|                     |               |       |             |           |           |       |
| **List_IterateForEach** |      **.NET 4.8** | **10000** | **80,025.2 ns** | **265.48 ns** | **175.60 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 | 10000 | 64,393.8 ns | 355.27 ns | 234.99 ns |  0.80 |
| List_IterateForEach | .NET Core 3.1 | 10000 | 63,879.0 ns | 171.30 ns | 113.31 ns |  0.80 |
