using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new array filled with random values (seeded)
            int[] values = NewIntArray(15, 1);
            // Print to console the unsorted array
            Console.WriteLine("Unsorted: " + string.Join(",", values));

            // Start stopwatch
            Stopwatch watch = Stopwatch.StartNew();

            // Sort using selected sort method 
            int[] sorted = Sort.Comb(values);

            // Stop stopwatch
            watch.Stop();

            // Print to console time elapsed and sorted array
            Console.WriteLine("Sorted:   " + string.Join(",", sorted));
            Console.WriteLine("Elapsed:  " + watch.Elapsed);
            Console.ReadLine();
        }

        /// <summary>
        /// Creates int array populated with random values
        /// </summary>
        /// <param name="size"></param>
        /// <param name="seed"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static int[] NewIntArray(int size, int seed = 0, int max = 15)
        {
            int[] values = new int[size];

            if (seed == 0)
            {
                seed = Guid.NewGuid().GetHashCode();
            }
            Random rnd = new Random(seed);

            for (int i = 0; i < size; i++)
            {
                values[i] = rnd.Next(max);
            }

            return values;
        }
    }
}
