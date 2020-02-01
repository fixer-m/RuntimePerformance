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
|                 Method |       Runtime |  Size |       Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------- |-------------- |------ |-----------:|----------:|----------:|------:|--------:|
| **Dictionary_ContainsKey** |      **.NET 4.8** |   **100** |   **2.584 us** | **0.0019 us** | **0.0012 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsKey | .NET Core 2.1 |   100 |   2.416 us | 0.0115 us | 0.0076 us |  0.93 |    0.00 |
| Dictionary_ContainsKey | .NET Core 3.1 |   100 |   1.664 us | 0.0361 us | 0.0338 us |  0.64 |    0.01 |
|                        |               |       |            |           |           |       |         |
| **Dictionary_ContainsKey** |      **.NET 4.8** |  **1000** |  **31.277 us** | **0.5703 us** | **0.5056 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsKey | .NET Core 2.1 |  1000 |  30.699 us | 0.0711 us | 0.0423 us |  0.99 |    0.02 |
| Dictionary_ContainsKey | .NET Core 3.1 |  1000 |  22.458 us | 0.1164 us | 0.0609 us |  0.73 |    0.01 |
|                        |               |       |            |           |           |       |         |
| **Dictionary_ContainsKey** |      **.NET 4.8** | **10000** | **376.539 us** | **0.1523 us** | **0.1007 us** |  **1.00** |    **0.00** |
| Dictionary_ContainsKey | .NET Core 2.1 | 10000 | 383.214 us | 7.1669 us | 6.3532 us |  1.02 |    0.02 |
| Dictionary_ContainsKey | .NET Core 3.1 | 10000 | 321.555 us | 0.4373 us | 0.2603 us |  0.85 |    0.00 |
