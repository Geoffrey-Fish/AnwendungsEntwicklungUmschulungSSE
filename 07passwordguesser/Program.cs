using static System.Console;
namespace SSE
    {
    public static class Program
        {
        public static void Main(string[] args)
            {
            /*Password guesser with 3 strikes*/
            int strikes = 3;
            /*keep app open till no strikes left*/
            while(strikes > 0)
                {
                WriteLine("Hello, Bob. Please enter your password:...");
                /* ? against possible null value*/
                string? password = ReadLine();
                /*here you can enter your password to guess*/
                switch(password == "sw0rdf1sh")
                    {
                    case true:
                        WriteLine("Welcome, Bob!");
                        /*This is the app exit command*/
                        Environment.Exit(0);
                        break;
                    default:
                        strikes--;
                        WriteLine($"That was wrong, buddy. \n You have {strikes} trys left!");
                        continue;
                    }
                }
            }
        }
    }