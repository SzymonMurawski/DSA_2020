using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int[] Array1 = CreateArray(100000000);
            int bestCase = Array1[0];
            int worstCase = -1;
            
            watch.Start();
            Search(Array1, bestCase);
            watch.Stop();
            long bestCaseTime = watch.ElapsedMilliseconds;
            
            watch.Reset();


            watch.Start();
            Search(Array1, worstCase);
            watch.Stop();
            long worstCaseTime = watch.ElapsedMilliseconds;
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



        static bool Search(int[] Array, int x)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
