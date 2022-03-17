using System;

namespace RPS
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new RPS())
                game.Run();
        }
    }
}
