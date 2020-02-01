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
|              Method |       Runtime |  Size |        Mean |    Error |   StdDev | Ratio |
|-------------------- |-------------- |------ |------------:|---------:|---------:|------:|
| **List_IterateForEach** |      **.NET 4.8** |   **100** |    **169.9 ns** |  **0.11 ns** |  **0.07 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 |   100 |    169.7 ns |  0.66 ns |  0.39 ns |  1.00 |
| List_IterateForEach | .NET Core 3.1 |   100 |    164.6 ns |  0.05 ns |  0.03 ns |  0.97 |
|                     |               |       |             |          |          |       |
| **List_IterateForEach** |      **.NET 4.8** |  **1000** |  **1,574.5 ns** |  **2.73 ns** |  **1.81 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 |  1000 |  1,575.8 ns |  3.82 ns |  2.27 ns |  1.00 |
| List_IterateForEach | .NET Core 3.1 |  1000 |  1,568.1 ns |  0.61 ns |  0.40 ns |  1.00 |
|                     |               |       |             |          |          |       |
| **List_IterateForEach** |      **.NET 4.8** | **10000** | **15,647.1 ns** | **76.69 ns** | **50.72 ns** |  **1.00** |
| List_IterateForEach | .NET Core 2.1 | 10000 | 15,620.7 ns | 16.84 ns | 10.02 ns |  1.00 |
| List_IterateForEach | .NET Core 3.1 | 10000 | 17,799.4 ns |  3.50 ns |  2.32 ns |  1.14 |
