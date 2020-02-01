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
|          Method |       Runtime |  Size |        Mean |     Error |    StdDev | Ratio |
|---------------- |-------------- |------ |------------:|----------:|----------:|------:|
| **List_IterateFor** |      **.NET 4.8** |   **100** |    **63.02 ns** |  **0.039 ns** |  **0.023 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 |   100 |    49.46 ns |  0.048 ns |  0.032 ns |  0.78 |
| List_IterateFor | .NET Core 3.1 |   100 |    56.84 ns |  0.056 ns |  0.037 ns |  0.90 |
|                 |               |       |             |           |           |       |
| **List_IterateFor** |      **.NET 4.8** |  **1000** |   **574.80 ns** |  **6.795 ns** |  **4.494 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 |  1000 |   460.86 ns |  3.771 ns |  2.494 ns |  0.80 |
| List_IterateFor | .NET Core 3.1 |  1000 |   460.35 ns |  0.681 ns |  0.405 ns |  0.80 |
|                 |               |       |             |           |           |       |
| **List_IterateFor** |      **.NET 4.8** | **10000** | **5,948.44 ns** | **30.772 ns** | **16.094 ns** |  **1.00** |
| List_IterateFor | .NET Core 2.1 | 10000 | 4,554.79 ns | 23.546 ns | 15.574 ns |  0.77 |
| List_IterateFor | .NET Core 3.1 | 10000 | 4,562.94 ns | 16.552 ns | 10.948 ns |  0.77 |
