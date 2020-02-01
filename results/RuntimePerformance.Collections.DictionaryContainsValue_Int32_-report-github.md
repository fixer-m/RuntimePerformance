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
|                   Method |       Runtime |  Size |          Mean |         Error |        StdDev | Ratio | RatioSD |
|------------------------- |-------------- |------ |--------------:|--------------:|--------------:|------:|--------:|
| **Dictionary_ContainsValue** |      **.NET 4.8** |   **100** |      **8.508 us** |     **0.0038 us** |     **0.0020 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 |   100 |      4.672 us |     0.0124 us |     0.0065 us |  0.55 |    0.00 |
| Dictionary_ContainsValue | .NET Core 3.1 |   100 |      4.629 us |     0.0088 us |     0.0053 us |  0.54 |    0.00 |
|                          |               |       |               |               |               |       |         |
| **Dictionary_ContainsValue** |      **.NET 4.8** |  **1000** |    **735.914 us** |     **0.1090 us** |     **0.0721 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 |  1000 |    398.368 us |     0.6860 us |     0.4538 us |  0.54 |    0.00 |
| Dictionary_ContainsValue | .NET Core 3.1 |  1000 |    397.771 us |     0.1071 us |     0.0708 us |  0.54 |    0.00 |
|                          |               |       |               |               |               |       |         |
| **Dictionary_ContainsValue** |      **.NET 4.8** | **10000** | **72,841.676 us** |   **954.2843 us** |   **631.2000 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 | 10000 | 39,311.639 us |     2.8570 us |     1.7002 us |  0.54 |    0.00 |
| Dictionary_ContainsValue | .NET Core 3.1 | 10000 | 41,674.486 us | 3,620.3854 us | 3,386.5107 us |  0.57 |    0.05 |
