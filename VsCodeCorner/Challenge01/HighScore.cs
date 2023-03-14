namespace SSE
{
    public class HighScore
    {
        public string PlayerName { get; set; }
        public int Tries { get; set; }

        public HighScore(string name, int tries)
        {
            this.PlayerName = name;
            this.Tries = tries;
        }

        public void Display()
        {
            Console.WriteLine($"Current Master is {PlayerName} with {Tries} tries!");
        }
    }
}
