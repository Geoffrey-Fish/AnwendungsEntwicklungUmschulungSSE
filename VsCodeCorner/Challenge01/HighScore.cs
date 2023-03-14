using static System.Console;
namespace SSE
{
    //For storing the overall highscore of the game
    //todo: must be stored permanently
    public class HighScore
    {
        public string PlayerName { get; set; }
        public int Tries { get; set; }

        //Instantiation of a highscore
        public HighScore(string name, int tries)
        {
            this.PlayerName = name;
            this.Tries = tries;
        }
        //show call the highscore and best player
        public void Display()
        {
            WriteLine($"Current Master is {PlayerName} with {Tries} tries!");
        }
    }
}
