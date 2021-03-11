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
            throw new NotImplementedException();
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
