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
|              Method |       Runtime |  Size |       Mean |     Error |    StdDev | Ratio |
|-------------------- |-------------- |------ |-----------:|----------:|----------:|------:|
| **Dictionary_GetValue** |      **.NET 4.8** |   **100** |   **2.685 us** | **0.0047 us** | **0.0028 us** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 |   100 |   2.546 us | 0.0149 us | 0.0089 us |  0.95 |
| Dictionary_GetValue | .NET Core 3.1 |   100 |   1.737 us | 0.0040 us | 0.0026 us |  0.65 |
|                     |               |       |            |           |           |       |
| **Dictionary_GetValue** |      **.NET 4.8** |  **1000** |  **31.622 us** | **0.2949 us** | **0.1755 us** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 |  1000 |  31.787 us | 0.0908 us | 0.0475 us |  1.00 |
| Dictionary_GetValue | .NET Core 3.1 |  1000 |  23.572 us | 0.0982 us | 0.0584 us |  0.75 |
|                     |               |       |            |           |           |       |
| **Dictionary_GetValue** |      **.NET 4.8** | **10000** | **386.021 us** | **1.2105 us** | **0.8006 us** |  **1.00** |
| Dictionary_GetValue | .NET Core 2.1 | 10000 | 394.758 us | 0.7032 us | 0.4651 us |  1.02 |
| Dictionary_GetValue | .NET Core 3.1 | 10000 | 333.750 us | 1.1174 us | 0.7391 us |  0.86 |
