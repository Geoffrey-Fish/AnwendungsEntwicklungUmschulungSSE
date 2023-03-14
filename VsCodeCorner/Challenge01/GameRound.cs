using static System.Console;
namespace SSE
{
    public static class GameRound
    {


        public static bool gameround(Player player, HighScore High)
        {
            WriteLine($"{player.name}, guess the Number!");
            Write("==>");
            bool input = Int32.TryParse(ReadLine(), out int playerNumber);
            if (!input)
            {
                WriteLine("Wrong Input");
            }
            if (playerNumber > player.chosenNumber)
            {
                player.diff = playerNumber - player.chosenNumber;
            }
            else if (playerNumber < player.chosenNumber)
            {
                player.diff = player.chosenNumber - playerNumber;
            }
            else if (playerNumber == player.chosenNumber)
            {
                player.solved = true;
                //Ending
                WriteLine($"Well done, {player.name}.\n" +
                $"You needed {player.tries} tries.");

                if (player.tries < High.Tries)
                {
                    WriteLine($"New record! \n" +
                    $"You have beaten the Highscore from {High.PlayerName} of {High.Tries} tries by {High.Tries - player.tries}!");
                    High.Tries = player.tries;
                    High.PlayerName = player.name;
                }
                return player.solved;
            }

            if (player.diff < player.lastDiff)
            {
                WriteLine("Warm!");
            }
            else
            {
                WriteLine("Cold");
            }
            player.lastDiff = player.diff;
            player.tries++;
            return player.solved;
        }
    }
}
