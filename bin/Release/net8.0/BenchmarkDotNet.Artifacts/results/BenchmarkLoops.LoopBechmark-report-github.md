```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3996/22H2/2022Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method | size  | Mean        | Error       | StdDev     |
|------- |------ |------------:|------------:|-----------:|
| **For**    | **100**   |    **76.05 ns** |    **28.00 ns** |   **1.535 ns** |
| **For**    | **10000** | **6,735.11 ns** | **2,568.70 ns** | **140.799 ns** |
