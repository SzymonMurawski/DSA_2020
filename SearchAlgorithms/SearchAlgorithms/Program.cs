using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearchEngine engine = GetSearchEngine();
            Measure(engine);
        }

        static ISearchEngine GetSearchEngine()
        {
            Console.WriteLine("select mode: SIMPLE, IMPROVED or BINARY");
            string mode = Console.ReadLine();
            switch (mode)
            {
                case "SIMPLE":
                    return new SimpleSearchEngine();;
                case "IMPROVED":
                    return new ImprovedSearchEngine();
                case "BINARY":
                    return new BinarySearchEngine();
                default:
                    Console.WriteLine("No mode chosen, closing");
                    return null;
            }
        }

        static void Measure(ISearchEngine engine)
        {
            int[] Array1 = CreateArray(100000000);
            int bestCase = Array1[0];
            int worstCase = -1;
            long bestCaseTime;
            long worstCaseTime;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            engine.Search(Array1, bestCase);
            watch.Stop();
            bestCaseTime = watch.ElapsedMilliseconds;
            watch.Reset();
            watch.Start();
            engine.Search(Array1, worstCase);
            watch.Stop();
            worstCaseTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Best case: {bestCaseTime}ms,\nWorst case: {worstCaseTime}ms");
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }
        static void Filling(int[] Array)
        {
            Random rd = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rd.Next(7, 101);
            }
            //Array[99999] = 6;
        }
    }
}
