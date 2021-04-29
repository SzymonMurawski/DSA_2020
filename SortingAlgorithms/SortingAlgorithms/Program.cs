﻿using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Measure(new InsertionSort());
        }

        public static void Measure(ISort sortEngine)
        {
            var arrayGenerator = new DistributionGenerator();
            foreach (int size in new int[] { 1000000, 10000000, 100000000 })
            {
                int[] array = arrayGenerator.GenerateAscendingDistribution(size);
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                sortEngine.Sort(array);
                watch.Stop();
                Console.WriteLine($"Size={size}, Time={watch.ElapsedMilliseconds}ms");
            }

            
        }
    }
}
