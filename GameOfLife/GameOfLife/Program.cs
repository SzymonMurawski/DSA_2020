﻿using System;

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
            bool[,] new_grid = grid;
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    int aliveNeighbours = numberOfAliveNeighbours(x, y, grid);
                    if (grid[x, y]) // cell is alive
                    {
                        if (aliveNeighbours == 2 || aliveNeighbours == 3)
                        {
                            new_grid[x, y] = true;
                        } else
                        {
                            new_grid[x, y] = false;
                        }

                    } else // cell is dead
                    {
                        if (aliveNeighbours == 3)
                        {
                            new_grid[x, y] = true;
                        } else
                        {
                            new_grid[x, y] = false;
                        }
                    }
                }
            }
            return new_grid;
        }

        static int numberOfAliveNeighbours(int cell_x, int cell_y, bool[,] grid)
        {
            int aliveNeighbours = 0;
            if(grid[cell_x - 1, cell_y - 1])
            {
                aliveNeighbours++;
            }
            if (grid[cell_x, cell_y - 1])
            {
                aliveNeighbours++;
            }
            if (grid[cell_x + 1, cell_y - 1])
            {
                aliveNeighbours++;
            }

            if (grid[cell_x - 1, cell_y])
            {
                aliveNeighbours++;
            }
            if (grid[cell_x + 1, cell_y])
            {
                aliveNeighbours++;
            }

            if (grid[cell_x - 1, cell_y + 1])
            {
                aliveNeighbours++;
            }
            if (grid[cell_x, cell_y + 1])
            {
                aliveNeighbours++;
            }
            if (grid[cell_x + 1, cell_y + 1])
            {
                aliveNeighbours++;
            }

            return aliveNeighbours;
        }
    }
}
