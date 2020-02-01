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
|          Method |       Runtime |  Size |        Mean |    Error |   StdDev | Ratio |
|---------------- |-------------- |------ |------------:|---------:|---------:|------:|
| **List_IterateFor** |      **.NET 4.8** |   **100** |    **64.14 ns** | **0.293 ns** | **0.194 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 |   100 |    50.38 ns | 0.089 ns | 0.053 ns |  0.79 |
| List_IterateFor | .NET Core 3.1 |   100 |    50.34 ns | 0.019 ns | 0.013 ns |  0.78 |
|                 |               |       |             |          |          |       |
| **List_IterateFor** |      **.NET 4.8** |  **1000** |   **565.09 ns** | **0.191 ns** | **0.127 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 |  1000 |   451.14 ns | 0.236 ns | 0.156 ns |  0.80 |
| List_IterateFor | .NET Core 3.1 |  1000 |   451.08 ns | 0.143 ns | 0.085 ns |  0.80 |
|                 |               |       |             |          |          |       |
| **List_IterateFor** |      **.NET 4.8** | **10000** | **5,679.11 ns** | **6.847 ns** | **3.581 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 | 10000 | 4,459.83 ns | 1.633 ns | 0.972 ns |  0.79 |
| List_IterateFor | .NET Core 3.1 | 10000 | 4,458.24 ns | 0.737 ns | 0.385 ns |  0.79 |
