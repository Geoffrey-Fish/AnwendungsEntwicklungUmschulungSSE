using static System.Console;

namespace SSE
{
    ///The stats of a player
    public class Player
    {
        public string name { get; set; }
        public int chosenNumber { get; set; }
        public int diff { get; set; }
        public int lastDiff { get; set; }
        public int tries { get; set; }
        public bool solved { get; set; }

        //instantiate a player for every contestant.Slick and concise.
        public Player(char c, string n, int d, int ld, int t, bool s)
        {
            name = n;
            chosenNumber = Mode.gameMode(c);
            diff = d;
            lastDiff = ld;
            tries = t;
            solved = s;
            WriteLine("DEBUG:{0} NUMBER DRAWN: {1}", name, chosenNumber);
        }
    }
}