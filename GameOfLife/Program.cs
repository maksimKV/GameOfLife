using GameSimulation;

namespace GameOfLife
{
    public class Program
    {
        // Rules of the game.
        private const int Heigth = 10;
        private const int Width = 30;
        private const uint MaxRuns = 100;

        private static void Main(string[] args)
        {
            int runs = 0;
            GameProcess game = new GameProcess(Heigth, Width);

            while (runs++ < MaxRuns)
            {
                game.DrawAndGrow();

                // Slowing down the game, so that the results are readable.
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
