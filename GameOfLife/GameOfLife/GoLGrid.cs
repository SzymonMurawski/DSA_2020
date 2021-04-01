using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    class GoLGrid
    {
        private bool[,] Grid;
        public GoLGrid() // Constructor
        {
            Grid = new bool[20, 20];
        }

        public void Initialize()
        {
            Grid[1, 1] = true;
            Grid[1, 2] = true;
            Grid[1, 3] = true;
            Grid[2, 3] = true;
            Grid[2, 5] = true;
            Grid[3, 5] = true;
            Grid[4, 5] = true;
        }

        public void InitializeRandomly()
        {
            Random engine = new Random();
            for (int y = 0; y < Grid.GetLength(0); y++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    Grid[x, y] = engine.Next() % 2 == 0;
                }
            }
        }

        public void Display()
        {
            Console.Clear();
            for (int y = 0; y < Grid.GetLength(0); y++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    if (Grid[x, y])
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        public void Transform()
        {
            bool[,] new_grid = new bool[Grid.GetLength(0), Grid.GetLength(1)];
            for (int y = 0; y < Grid.GetLength(0); y++)
            {
                for (int x = 0; x < Grid.GetLength(1); x++)
                {
                    int aliveNeighbours = NumberOfAliveNeighbours(x, y);
                    if (Grid[x, y]) // cell is alive
                    {
                        if (aliveNeighbours == 2 || aliveNeighbours == 3)
                        {
                            new_grid[x, y] = true;
                        }
                        else
                        {
                            new_grid[x, y] = false;
                        }

                    }
                    else // cell is dead
                    {
                        if (aliveNeighbours == 3)
                        {
                            new_grid[x, y] = true;
                        }
                        else
                        {
                            new_grid[x, y] = false;
                        }
                    }
                }
            }
            Grid = new_grid;
        }

        public int NumberOfAliveNeighbours(int cell_x, int cell_y)
        {
            int aliveNeighbours = 0;
            int dx = Grid.GetLength(0);
            int dy = Grid.GetLength(1);
            // We are using periodic boundary conditions, hence the modulo division
            if (Grid[(cell_x - 1 + dx) % dx, (cell_y - 1 + dy) % dy])
            {
                aliveNeighbours++;
            }
            if (Grid[cell_x, (cell_y - 1 + dy) % dy])
            {
                aliveNeighbours++;
            }
            if (Grid[(cell_x + 1) % dx, (cell_y - 1 + dy) % dy])
            {
                aliveNeighbours++;
            }

            if (Grid[(cell_x - 1 + dx) % dx, cell_y])
            {
                aliveNeighbours++;
            }
            if (Grid[(cell_x + 1) % dx, cell_y])
            {
                aliveNeighbours++;
            }

            if (Grid[(cell_x - 1 + dx) % dx, (cell_y + 1) % dy])
            {
                aliveNeighbours++;
            }
            if (Grid[cell_x, (cell_y + 1) % dy])
            {
                aliveNeighbours++;
            }
            if (Grid[(cell_x + 1) % dx, (cell_y + 1) % dy])
            {
                aliveNeighbours++;
            }

            return aliveNeighbours;
        }
    }
}
