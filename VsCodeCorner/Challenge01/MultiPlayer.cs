using static System.Console;
namespace SSE
{
    public class MultiPlayer
    {
        public static void multiPlayer(char c, HighScore High)
        {
            //params

            //Take the name of player one
            WriteLine("PLAYER ONE:\n Your Name is?");
            Write("==>");
            string? playerName = ReadLine();

            Player playerOne = new Player(c, playerName, 9000, 10000, 0, false);

            //Take the name of player two
            WriteLine("PLAYER TWO:\n Your Name is?");
            string playerName2 = ReadLine();
            Player playerTwo = new Player(c, playerName2, 9000, 10000, 0, false);
            //GameLoop
            bool stop = false;
            while (stop == false)
            {
                stop = GameRound.gameround(playerOne, High);
                if (stop == true)
                {
                    break;
                }
                stop = GameRound.gameround(playerTwo, High);
            }
        }
    }
}