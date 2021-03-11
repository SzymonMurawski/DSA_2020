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
                GridDisplay(grid);
                grid = GridTransformation(grid);
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
            throw new NotImplementedException();
        }

        static bool[,] GridTransformation(bool[,] grid)
        {
            throw new NotImplementedException();
        }
    }
}
