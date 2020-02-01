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
|         Method |       Runtime |  Size |         Mean |     Error |    StdDev | Ratio |
|--------------- |-------------- |------ |-------------:|----------:|----------:|------:|
| **Dictionary_Add** |      **.NET 4.8** |   **100** |     **905.8 ns** |   **1.33 ns** |   **0.69 ns** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 |   100 |     903.9 ns |   1.63 ns |   1.08 ns |  1.00 |
| Dictionary_Add | .NET Core 3.1 |   100 |     858.6 ns |   6.79 ns |   3.55 ns |  0.95 |
|                |               |       |              |           |           |       |
| **Dictionary_Add** |      **.NET 4.8** |  **1000** |  **10,449.4 ns** |  **68.99 ns** |  **45.63 ns** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 |  1000 |  12,270.6 ns |  49.23 ns |  32.56 ns |  1.17 |
| Dictionary_Add | .NET Core 3.1 |  1000 |  11,355.6 ns |  72.33 ns |  47.84 ns |  1.09 |
|                |               |       |              |           |           |       |
| **Dictionary_Add** |      **.NET 4.8** | **10000** | **148,645.5 ns** | **783.64 ns** | **518.33 ns** |  **1.00** |
| Dictionary_Add | .NET Core 2.1 | 10000 | 147,787.7 ns | 101.97 ns |  67.45 ns |  0.99 |
| Dictionary_Add | .NET Core 3.1 | 10000 | 137,900.7 ns | 940.49 ns | 622.08 ns |  0.93 |
