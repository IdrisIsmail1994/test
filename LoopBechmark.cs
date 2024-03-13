using BenchmarkDotNet.Attributes;

namespace BenchmarkLoops;

[MemoryDiagnoser]
[ShortRunJob]
public class LoopBechmark
{
    [Params(100, 10000)]
    public int size { get; set; }
    private List<int> items = new();

    [GlobalSetup]
    public void InitList()
    {
        items = Enumerable.Range(1, size).Select(x => Random.Shared.Next()).ToList();
    }

    [Benchmark]
    public void For()
    {
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
        }
    }

    /* public void While()
     {
         var i = 0;
         while (i < items.Count)
         {
             var item = items[1];
             i++;
         }
     }*/
}
