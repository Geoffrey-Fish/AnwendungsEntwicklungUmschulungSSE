using static System.Console;
namespace SSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //init gameloop main
            bool exit = false;
            //init Highscore of the game
            HighScore High = new HighScore("Nemo", 100);

            //welcome
            WriteLine("Welcome to As Cold As Hot \n" +
            "aka 'ACAS'");

            //Main gameloop
            while (exit == false)
            {
                //Check number of players
                WriteLine("------------------");
                WriteLine("One or two players?");
                Write("==>");
                bool input = Int32.TryParse(ReadLine(), out int playerNumber);
                if (!input)
                {
                    WriteLine("Wrong Input");
                }

                //normal(100) or hard(1000)
                WriteLine("(N)ormal or (H)ardcore?");
                Write("==>");
                char? level = Convert.ToChar(ReadLine().ToLower().Trim());

                //See that data is stored ( just in session so far) 
                //todo: persistent data storage
                WriteLine("Want to know the highscore to beat?");
                Write("(Y)es/(N)o ==>");
                char? scoreCheck = Convert.ToChar(ReadLine().ToLower().Trim());
                if (scoreCheck == 'y')
                    High.Display();
                //Bad position for an exit, but whatever.
                WriteLine("Want to exit?");
                Write("Y or N: ==>");
                char? stop = Convert.ToChar(ReadLine().ToLower().Trim());
                if (stop == 'y')
                {
                    exit = true;
                    Environment.Exit(0);
                }
                //game starter
                switch (playerNumber)
                {
                    //invoke singleplayer game
                    case 1:
                        SinglePlayer.singlePlayer((char)level, High);
                        break;
                    //invoke multiplayer game
                    case 2:
                        MultiPlayer.multiPlayer((char)level, High);
                        break;
                    //sum ting wong
                    default:
                        WriteLine("ERROR MAIN GAME CALL");
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}