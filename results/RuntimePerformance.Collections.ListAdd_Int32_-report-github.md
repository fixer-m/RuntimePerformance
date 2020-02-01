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
|   Method |       Runtime |  Size |        Mean |    Error |   StdDev | Ratio |
|--------- |-------------- |------ |------------:|---------:|---------:|------:|
| **List_Add** |      **.NET 4.8** |   **100** |    **209.4 ns** |  **0.19 ns** |  **0.13 ns** |  **1.00** |
| List_Add | .NET Core 2.1 |   100 |    134.1 ns |  0.08 ns |  0.05 ns |  0.64 |
| List_Add | .NET Core 3.1 |   100 |    135.3 ns |  0.58 ns |  0.30 ns |  0.65 |
|          |               |       |             |          |          |       |
| **List_Add** |      **.NET 4.8** |  **1000** |  **2,006.5 ns** | **11.65 ns** |  **6.93 ns** |  **1.00** |
| List_Add | .NET Core 2.1 |  1000 |  1,249.0 ns |  1.00 ns |  0.60 ns |  0.62 |
| List_Add | .NET Core 3.1 |  1000 |  1,260.9 ns |  5.88 ns |  3.89 ns |  0.63 |
|          |               |       |             |          |          |       |
| **List_Add** |      **.NET 4.8** | **10000** | **19,611.9 ns** | **48.59 ns** | **28.92 ns** |  **1.00** |
| List_Add | .NET Core 2.1 | 10000 | 12,240.1 ns | 16.89 ns |  8.83 ns |  0.62 |
| List_Add | .NET Core 3.1 | 10000 | 12,360.1 ns | 36.74 ns | 24.30 ns |  0.63 |
