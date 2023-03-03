using static System.Console;

namespace SSE
    {
    public class Program
        {
        static void Main(string[] args)
            {
            bool exit = false;
            int pwon = 0;
            int cwon = 0;
            while(exit == false)
                {
                Clear();
                WriteLine("Welcome to \n" +
                    "Stone Paper Scissors Spock Lizard!\n" +
                    "Choose your weapon:\n" +
                    "1: Stone\n" +
                    "2: Scissors\n" +
                    "3: Paper\n" +
                    "4: Spock\n" +
                    "5: Lizard\n " +
                    "And Enter your number.\n" +
                    "------------");

                int choice = 0;

                //Player chooses weapon
                try
                    {
                    choice = Convert.ToInt32(ReadLine());
                    }
                catch
                    {
                    if(choice <= 0 || choice >= 5)
                        WriteLine("That was no valid Input!");
                    }

                //random generator 0 to 4, Computer chooses weapon
                var rand = new Random();
                int computer = rand.Next(0,5);

                // 2D Array stores the weapons
                string[] weapons = new string[] { "Stone","Scissors","Paper","Spock","Lizard" };

                //this translates the computer random choice into a weapon
                string compAnswer = weapons[computer];
                string playerAnswer = weapons[choice - 1];
                string result = Compairer(playerAnswer,compAnswer);
                if(result == "won")
                    {
                    pwon++;
                    }
                else if(result == "lost")
                    {
                    cwon++;
                    }
                else
                    {
                    continue;
                    }
                WriteLine($"You {result} with {playerAnswer}, your Opponent chose {compAnswer}.");
                //Resume and repeat the game or exit
                WriteLine($"You won {pwon} times.\n Computer won {cwon} times.\n" +
                    "Wanna play (A)gain or (E)xit?");
                string? end = ReadLine().ToLower().Trim();
                if(end == "e")
                    {
                    exit = true;
                    }
                else if(end == "a")
                    {
                    continue;
                    }
                }
            }

        public static string Compairer(string a,string b)
            {
            if(a == b)
                {
                return "draw!";
                }
            else
                {
                switch(a)
                    {
                    case "Stone":
                        return b == "Scissors" || b == "Lizard" ? "won" : "lost";
                    case "Scissors":
                        return b == "Paper" || b == "Lizard" ? "won" : "lost";
                    case "Paper":
                        return b == "Stone" || b == "Spock" ? "won" : "lost";
                    case "Spock":
                        return b == "Stone" || b == "Scissors" ? "won" : "lost";
                    case "Lizard":
                        return b == "Paper" || b == "Spock" ? "won" : "lost";
                    default:
                        return "oh no, that was nothin'!";
                    }
                }
            }
        }
    }
