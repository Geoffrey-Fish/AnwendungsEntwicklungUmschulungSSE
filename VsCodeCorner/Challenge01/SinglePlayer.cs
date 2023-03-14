using static System.Console;
namespace SSE
{
    public class SinglePlayer
    {
        public static void singlePlayer(char c, HighScore High)
        {
            //params
            int chosenNumber = Mode.gameMode(c);
            int diff = 9000;
            int lastDiff = 10000;
            int tries = 0;
            bool solved = false;

            //Take the name
            WriteLine("Your Name is?");
            Write("==>");
            string? playerName = ReadLine();

            //GameLoop
            do
            {
                WriteLine($"{playerName}, guess the Number!");
                Write("==>");
                bool input = Int32.TryParse(ReadLine(), out int playerNumber);
                if (!input)
                {
                    WriteLine("Wrong Input");
                }
                if (playerNumber > chosenNumber)
                {
                    diff = playerNumber - chosenNumber;
                }
                else if (playerNumber < chosenNumber)
                {
                    diff = chosenNumber - playerNumber;
                }
                else if (playerNumber == chosenNumber)
                {
                    solved = true;
                    break;
                }

                if (diff < lastDiff)
                {
                    WriteLine("Warm!");
                }
                else
                {
                    WriteLine("Cold.");
                }
                lastDiff = diff;
                tries++;
            } while (solved == false);

            //Ending
            WriteLine($"Well done, {playerName}.\n" +
            $"You needed {tries} tries.");
            if (tries < High.Tries)
            {
                WriteLine($"New record! \n" +
                $"You have beaten the Highscore from {High.PlayerName} of {High.Tries} tries by {High.Tries - tries}!");
                High.Tries = tries;
                High.PlayerName = playerName;
            }

        }
    }
}