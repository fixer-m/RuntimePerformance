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
|    Method |       Runtime |     Mean |     Error |    StdDev | Ratio |
|---------- |-------------- |---------:|----------:|----------:|------:|
| List_Ctor |      .NET 4.8 | 6.959 ns | 0.0358 ns | 0.0237 ns |  1.00 |
| List_Ctor | .NET Core 2.1 | 5.713 ns | 0.0052 ns | 0.0031 ns |  0.82 |
| List_Ctor | .NET Core 3.1 | 3.291 ns | 0.0239 ns | 0.0158 ns |  0.47 |
