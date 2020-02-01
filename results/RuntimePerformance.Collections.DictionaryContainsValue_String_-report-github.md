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
|                   Method |       Runtime |  Size |          Mean |        Error |       StdDev | Ratio | RatioSD |
|------------------------- |-------------- |------ |--------------:|-------------:|-------------:|------:|--------:|
| **Dictionary_ContainsValue** |      **.NET 4.8** |   **100** |      **22.33 us** |     **0.021 us** |     **0.013 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 |   100 |      19.37 us |     0.304 us |     0.201 us |  0.87 |    0.01 |
| Dictionary_ContainsValue | .NET Core 3.1 |   100 |      20.20 us |     0.031 us |     0.019 us |  0.90 |    0.00 |
|                          |               |       |               |              |              |       |         |
| **Dictionary_ContainsValue** |      **.NET 4.8** |  **1000** |   **2,137.78 us** |     **1.277 us** |     **0.845 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 |  1000 |   1,837.97 us |    11.663 us |     6.940 us |  0.86 |    0.00 |
| Dictionary_ContainsValue | .NET Core 3.1 |  1000 |   1,923.06 us |     2.937 us |     1.536 us |  0.90 |    0.00 |
|                          |               |       |               |              |              |       |         |
| **Dictionary_ContainsValue** |      **.NET 4.8** | **10000** | **217,861.61 us** | **4,328.209 us** | **4,048.609 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsValue | .NET Core 2.1 | 10000 | 183,085.73 us |   133.946 us |    88.597 us |  0.85 |    0.02 |
| Dictionary_ContainsValue | .NET Core 3.1 | 10000 | 191,701.10 us |    84.645 us |    50.371 us |  0.89 |    0.02 |
