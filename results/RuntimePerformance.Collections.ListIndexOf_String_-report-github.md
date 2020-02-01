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
|       Method |       Runtime |  Size |          Mean |        Error |       StdDev | Ratio |
|------------- |-------------- |------ |--------------:|-------------:|-------------:|------:|
| **List_IndexOf** |      **.NET 4.8** |   **100** |      **38.20 us** |     **0.085 us** |     **0.056 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 |   100 |      44.27 us |     0.127 us |     0.084 us |  1.16 |
| List_IndexOf | .NET Core 3.1 |   100 |      36.13 us |     0.481 us |     0.318 us |  0.95 |
|              |               |       |               |              |              |       |
| **List_IndexOf** |      **.NET 4.8** |  **1000** |   **3,736.84 us** |     **1.638 us** |     **1.083 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 |  1000 |   4,293.88 us |     3.722 us |     2.462 us |  1.15 |
| List_IndexOf | .NET Core 3.1 |  1000 |   3,527.22 us |    13.493 us |     7.057 us |  0.94 |
|              |               |       |               |              |              |       |
| **List_IndexOf** |      **.NET 4.8** | **10000** | **372,583.42 us** |   **629.047 us** |   **374.336 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 | 10000 | 426,979.14 us |   375.231 us |   223.294 us |  1.15 |
| List_IndexOf | .NET Core 3.1 | 10000 | 382,844.29 us | 6,796.575 us | 4,495.513 us |  1.03 |
