using System.ComponentModel;
using static System.Console;
namespace SSE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            HighScore High = new HighScore("Nemo", 100);
            while (exit == false)
            {
                WriteLine("Welcome to As Cold As Hot \n" +
                "aka 'ACAS'");

                WriteLine("One or two players?");
                Write("==>");
                bool input = Int32.TryParse(ReadLine(), out int playerNumber);
                if (!input)
                {
                    WriteLine("Wrong Input");
                }

                WriteLine("(N)ormal or (H)ardcore?");
                Write("==>");
                char? level = Convert.ToChar(ReadLine().ToLower().Trim());

                WriteLine("Want to know the highscore to beat?");
                Write("(Y)es/(N)o ==>");
                char? scoreCheck = Convert.ToChar(ReadLine().ToLower().Trim());
                if (scoreCheck == 'y')
                    High.Display();

                switch (playerNumber)
                {
                    case 1:
                        SinglePlayer.singlePlayer((char)level, High);
                        break;
                    case 2:
                        MultiPlayer.multiPlayer((char)level, High);
                        break;
                    default:
                        WriteLine("ERROR MAIN GAME CALL");
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}