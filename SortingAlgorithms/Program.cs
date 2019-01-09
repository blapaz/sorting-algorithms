using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();

            int[] values = new int[]
            {
                9, 8, 7, 6, 5, 6, 4, 3, 2, 1, 0, 10
            };

            Sort sort = new Sort();
            int[] sorted = sort.Merge(values);

            watch.Stop();

            Console.WriteLine("[Elapsed: " + watch.Elapsed + "] " + string.Join(",", sorted));
            Console.ReadLine();
        }
    }
}
