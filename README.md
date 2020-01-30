## .NET Core vs Framework: Common Collections Performance 
This repo contains benchmarks to compare performance of common dotnet collections in .NET Core and .NET Framework.  
This is addendum to my blog post: [.NET Core vs Framework: Collections Performance](https://habr.com/ru/post/481558) (RU)  
It uses [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) for benchmarking and contains results from my PC as well.

### Run steps
- Install .NET Core 3.1, .NET Core 2.1, .NET Framework 4.8 ([download](https://dotnet.microsoft.com/download))
- Change build mode to **Release** 
- Open `Program.cs` and make adjustsments if needed (see below)
- Run project

### BenchmarkDotNet Options
There is a couple of options you may want to change in `Program.cs`.

```csharp
var bdnArgs = new string[] { "--filter=RuntimePerformance.Collections*" };
```
Here you can pass any arguments to BenchmarkDotNet, for example - filter for benchmarks.  
Set it to `RuntimePerformance.Collections.List*` if you want to run only **List** tests.  
Full run can take 1 hour approx, so this can be useful.

```csharp
return DefaultConfig.Instance.With(jobs).WithArtifactsPath(@"..\..\..\..\..\");
```
Here you can set `ArtifactsPath` - the results folder path.