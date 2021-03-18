using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GoLGrid gameGrid = new GoLGrid();
            gameGrid.Initialize();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                gameGrid.Display();
                gameGrid.Transform();
            }
        }
    }
}
