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
|        Method |       Runtime |  Size |           Mean |       Error |      StdDev | Ratio |
|-------------- |-------------- |------ |---------------:|------------:|------------:|------:|
| **List_Contains** |      **.NET 4.8** |   **100** |      **12.678 us** |   **0.0313 us** |   **0.0207 us** |  **1.00** |
| List_Contains | .NET Core 2.1 |   100 |       5.567 us |   0.0091 us |   0.0060 us |  0.44 |
| List_Contains | .NET Core 3.1 |   100 |       2.120 us |   0.0025 us |   0.0013 us |  0.17 |
|               |               |       |                |             |             |       |
| **List_Contains** |      **.NET 4.8** |  **1000** |   **1,128.975 us** |   **5.4951 us** |   **3.6347 us** |  **1.00** |
| List_Contains | .NET Core 2.1 |  1000 |     456.040 us |   0.1437 us |   0.0950 us |  0.40 |
| List_Contains | .NET Core 3.1 |  1000 |     188.002 us |   0.1619 us |   0.0964 us |  0.17 |
|               |               |       |                |             |             |       |
| **List_Contains** |      **.NET 4.8** | **10000** | **111,855.904 us** | **529.0166 us** | **349.9117 us** |  **1.00** |
| List_Contains | .NET Core 2.1 | 10000 |  44,659.545 us |  47.3462 us |  28.1749 us |  0.40 |
| List_Contains | .NET Core 3.1 | 10000 |  18,842.103 us |   7.0968 us |   4.6941 us |  0.17 |
