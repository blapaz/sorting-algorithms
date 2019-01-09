using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[]
            {
                9, 8, 7, 6, 5, 6, 4, 3, 2, 1, 0
            };

            Sort sort = new Sort();
            int[] sorted = sort.Selection(values);

            Console.WriteLine(string.Join(",", values));
            Console.ReadLine();
        }
    }
}
