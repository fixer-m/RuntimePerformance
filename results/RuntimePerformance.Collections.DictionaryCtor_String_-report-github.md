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
|          Method |       Runtime |     Mean |    Error |   StdDev | Ratio | RatioSD |
|---------------- |-------------- |---------:|---------:|---------:|------:|--------:|
| Dictionary_Ctor |      .NET 4.8 | 11.98 ns | 0.072 ns | 0.047 ns |  1.00 |    0.00 |
| Dictionary_Ctor | .NET Core 2.1 | 48.68 ns | 0.197 ns | 0.130 ns |  4.06 |    0.02 |
| Dictionary_Ctor | .NET Core 3.1 | 45.92 ns | 0.190 ns | 0.113 ns |  3.84 |    0.01 |
