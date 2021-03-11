using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] grid = GridInitialization();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                GridDisplay(grid);
                //grid = GridTransformation(grid);
            }
        }

        static bool[,] GridInitialization()
        {
            bool[,] grid = new bool[20, 20];
            grid[1, 1] = true;
            grid[1, 2] = true;
            grid[1, 3] = true;
            return grid;
        }

        static void GridDisplay(bool[,] grid)
        {
            Console.Clear();
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    if (grid[x, y])
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static bool[,] GridTransformation(bool[,] grid)
        {
            throw new NotImplementedException();
        }
    }
}
