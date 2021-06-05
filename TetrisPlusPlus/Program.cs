using System;

namespace TetrisPlusPlus
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TetrisPlusPlus())
                game.Run();
        }
    }
}
