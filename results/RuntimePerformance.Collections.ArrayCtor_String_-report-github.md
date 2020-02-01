``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-HMONJZ : .NET Framework 4.8 (4.8.4075.0), X64 RyuJIT
  Job-RANOSB : .NET Core 2.1.15 (CoreCLR 4.6.28325.01, CoreFX 4.6.28327.02), X64 RyuJIT
  Job-AJVGBG : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

Jit=RyuJit  Platform=X64  MaxIterationCount=15  
MinIterationCount=10  WarmupCount=2  

```
|     Method |       Runtime |     Mean |     Error |    StdDev | Ratio |
|----------- |-------------- |---------:|----------:|----------:|------:|
| Array_Ctor |      .NET 4.8 | 2.721 ns | 0.0271 ns | 0.0179 ns |  1.00 |
| Array_Ctor | .NET Core 2.1 | 2.052 ns | 0.0182 ns | 0.0120 ns |  0.75 |
| Array_Ctor | .NET Core 3.1 | 2.276 ns | 0.0383 ns | 0.0253 ns |  0.84 |
