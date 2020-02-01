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
|        Method |       Runtime |  Size |          Mean |        Error |       StdDev | Ratio |
|-------------- |-------------- |------ |--------------:|-------------:|-------------:|------:|
| **List_Contains** |      **.NET 4.8** |   **100** |      **40.80 us** |     **0.032 us** |     **0.021 us** |  **1.00** |
| List_Contains | .NET Core 2.1 |   100 |      34.54 us |     0.125 us |     0.083 us |  0.85 |
| List_Contains | .NET Core 3.1 |   100 |      29.04 us |     0.024 us |     0.014 us |  0.71 |
|               |               |       |               |              |              |       |
| **List_Contains** |      **.NET 4.8** |  **1000** |   **4,027.20 us** |     **9.479 us** |     **5.641 us** |  **1.00** |
| List_Contains | .NET Core 2.1 |  1000 |   3,332.93 us |     2.156 us |     1.128 us |  0.83 |
| List_Contains | .NET Core 3.1 |  1000 |   2,723.48 us |     2.460 us |     1.464 us |  0.68 |
|               |               |       |               |              |              |       |
| **List_Contains** |      **.NET 4.8** | **10000** | **404,805.49 us** |   **245.046 us** |   **162.083 us** |  **1.00** |
| List_Contains | .NET Core 2.1 | 10000 | 332,733.82 us | 1,476.076 us |   976.333 us |  0.82 |
| List_Contains | .NET Core 3.1 | 10000 | 354,935.87 us | 3,513.243 us | 2,323.793 us |  0.88 |
