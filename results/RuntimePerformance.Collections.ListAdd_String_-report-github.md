``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-HBUMGT : .NET Framework 4.8 (4.8.4075.0), X64 RyuJIT
  Job-XKAFUZ : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-LQIAZL : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|   Method |       Runtime |  Size |        Mean |     Error |    StdDev | Ratio |
|--------- |-------------- |------ |------------:|----------:|----------:|------:|
| **List_Add** |      **.NET 4.8** |   **100** |    **330.2 ns** |   **1.80 ns** |   **1.07 ns** |  **1.00** |
| List_Add | .NET Core 2.1 |   100 |    316.9 ns |   1.90 ns |   1.13 ns |  0.96 |
| List_Add | .NET Core 3.1 |   100 |    247.4 ns |   4.82 ns |   3.19 ns |  0.75 |
|          |               |       |             |           |           |       |
| **List_Add** |      **.NET 4.8** |  **1000** |  **3,250.8 ns** |  **53.13 ns** |  **35.14 ns** |  **1.00** |
| List_Add | .NET Core 2.1 |  1000 |  2,816.8 ns |  37.26 ns |  22.18 ns |  0.87 |
| List_Add | .NET Core 3.1 |  1000 |  2,538.2 ns |  30.55 ns |  20.21 ns |  0.78 |
|          |               |       |             |           |           |       |
| **List_Add** |      **.NET 4.8** | **10000** | **33,501.8 ns** | **486.39 ns** | **321.71 ns** |  **1.00** |
| List_Add | .NET Core 2.1 | 10000 | 29,492.8 ns | 291.46 ns | 192.78 ns |  0.88 |
| List_Add | .NET Core 3.1 | 10000 | 25,307.5 ns | 351.70 ns | 232.63 ns |  0.76 |
