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
|       Method |       Runtime |  Size |          Mean |       Error |     StdDev | Ratio |
|------------- |-------------- |------ |--------------:|------------:|-----------:|------:|
| **List_IndexOf** |      **.NET 4.8** |   **100** |      **5.857 us** |   **0.0064 us** |  **0.0043 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 |   100 |      5.560 us |   0.0027 us |  0.0016 us |  0.95 |
| List_IndexOf | .NET Core 3.1 |   100 |      2.164 us |   0.0011 us |  0.0007 us |  0.37 |
|              |               |       |               |             |            |       |
| **List_IndexOf** |      **.NET 4.8** |  **1000** |    **458.680 us** |   **0.2177 us** |  **0.1295 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 |  1000 |    455.820 us |   0.2372 us |  0.1569 us |  0.99 |
| List_IndexOf | .NET Core 3.1 |  1000 |    195.600 us |   0.0980 us |  0.0583 us |  0.43 |
|              |               |       |               |             |            |       |
| **List_IndexOf** |      **.NET 4.8** | **10000** | **44,812.154 us** |  **17.6187 us** |  **9.2149 us** |  **1.00** |
| List_IndexOf | .NET Core 2.1 | 10000 | 44,668.832 us | 114.5413 us | 68.1617 us |  1.00 |
| List_IndexOf | .NET Core 3.1 | 10000 | 18,174.536 us |   7.0272 us |  4.1817 us |  0.41 |
