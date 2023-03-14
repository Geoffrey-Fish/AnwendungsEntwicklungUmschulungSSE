using static System.Console;
namespace SSE
{
    public class SinglePlayer
    {
        public static void singlePlayer(char c, HighScore High)
        {
            //Take the name
            WriteLine("Your Name is?");
            Write("==>");
            string? playerName = ReadLine();
            //instanciate player
            Player player = new Player(c, playerName, 9000, 10000, 0, false);
            //Gameloop
            do
                GameRound.gameround(player, High);
            while (player.solved == false);
        }
    }
}