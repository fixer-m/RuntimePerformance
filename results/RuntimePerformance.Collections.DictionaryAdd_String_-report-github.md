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
|         Method |       Runtime |  Size |       Mean |     Error |    StdDev | Ratio |
|--------------- |-------------- |------ |-----------:|----------:|----------:|------:|
| **Dictionary_Add** |      **.NET 4.8** |   **100** |   **2.625 us** | **0.0049 us** | **0.0029 us** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 |   100 |   2.866 us | 0.0060 us | 0.0040 us |  1.09 |
| Dictionary_Add | .NET Core 3.1 |   100 |   2.069 us | 0.0029 us | 0.0019 us |  0.79 |
|                |               |       |            |           |           |       |
| **Dictionary_Add** |      **.NET 4.8** |  **1000** |  **33.229 us** | **0.0331 us** | **0.0219 us** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 |  1000 |  35.303 us | 0.1821 us | 0.1084 us |  1.06 |
| Dictionary_Add | .NET Core 3.1 |  1000 |  26.976 us | 0.1248 us | 0.0825 us |  0.81 |
|                |               |       |            |           |           |       |
| **Dictionary_Add** |      **.NET 4.8** | **10000** | **437.559 us** | **1.9989 us** | **1.1895 us** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 | 10000 | 442.574 us | 0.6222 us | 0.3702 us |  1.01 |
| Dictionary_Add | .NET Core 3.1 | 10000 | 354.815 us | 1.1211 us | 0.5863 us |  0.81 |
