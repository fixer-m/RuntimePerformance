using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Reflection;

namespace RuntimePerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAssembly = typeof(Program).GetTypeInfo().Assembly;
            var bdnArgs = new string[] { "--filter=RuntimePerformance.Collections*" };

            BenchmarkSwitcher.FromAssembly(currentAssembly).Run(bdnArgs, MyConfig.Create());
        }
    }

    public static class MyConfig
    {
        public static IConfig Create()
        {
            var jobNet48 = Job.Default.With(ClrRuntime.Net48).WithDefault().AsBaseline();
            var jobCore21 = Job.Default.With(CoreRuntime.Core21).WithDefault();
            var jobCore31 = Job.Default.With(CoreRuntime.Core31).WithDefault();

            var jobs = new Job[] { jobNet48, jobCore21, jobCore31 };

            return DefaultConfig.Instance.With(jobs).WithArtifactsPath(@"..\..\..\..\..\");
        }
    }

    public static class JobExt
    {
        public static Job WithDefault(this Job job)
        {
            return job.With(Jit.RyuJit)
               .With(Platform.X64)
               .WithWarmupCount(2)
               .WithMinIterationCount(10)
               .WithMaxIterationCount(15);
        }
    }
}