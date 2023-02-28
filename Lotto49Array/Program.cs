using static System.Console;
/*
 * We shall program an algorithm that draws
 * 6 random numbers in the rage 1 to 49.
 * No double draws allowed.
 * */
/*POSTSCRIPTUM:
 * After that we could insert a simple game out of that base.
 * I didn't do it back then, so I did it now.
 */
namespace SSE
    {
    public class Program
        {
        static void Main(string[] args)
            {
            //If you wanna gamble
            int[] playerBet = new int[6];
            bool game = false;

            WriteLine("Welcome to german lottery.\n" +
                "These are the numbers to be drawn from:");

            //Initialize number Array for the lottery
            int[] lotto = new int[49];
            for(int o = 0;o < lotto.Length;o++)
                {
                lotto[o] = o + 1;
                }
            //show the numbers

            foreach(int val in lotto)
                {
                Write(val + ", ");
                }
            WriteLine("\n -----------------------------------");

            //Here I start the gamemode
            WriteLine("Would you like to bet?\n" +
                "(Y)es or (N)o");
            Write("==> ");
            string? answer = ReadLine().ToLower().Trim();
            if(answer == "y")
                {
                game = true;
                playerBet = Tipico();
                }
            else
                {
                WriteLine("Well, then we proceed with the drawing");
                }

            //initialize collecting array for the drawn numbers
            int[] winners = new int[6];

            //initialize the random generator
            Random rand = new Random();

            //draw them lucky basterds
            for(int j = 0;j < 6;j++)
                {
                int draw = rand.Next(1,lotto.Length + 1);

                // Add drawn number
                winners[j] = draw;

                //now take the drawn number out of the pool to eliminate duplicates
                lotto = lotto.Where((source,index) => index != draw - 1).ToArray();

                /*
                // DEBUGGING
                // debugging, th show that there are only unique numbers
                // WriteLine("\n ----------------------------------" +
                // "\n Remaining numbers (Just for debugging purpose)");

                 foreach(int k in lotto)
                    {
                    Write(k + " ");
                    }
                */
                }
            WriteLine("\n -----------------------------------------------");

            //Showing the drawn numbers
            WriteLine("The lucky numbers for today are: ");
            Array.Sort(winners);
            Write("==> ");
            foreach(int val in winners)
                {
                Write(val + ", ");
                }
            WriteLine();

            //Compare Tips if played
            if(game)
                {
                WriteLine("Your numbers were:");
                Array.Sort(playerBet);
                Write("==> ");

                //iterate through
                foreach(int val in playerBet)
                    {
                    Write(val + ", ");
                    }
                WriteLine();

                //Final output
                WriteLine($"You have {ChickenDinner(playerBet,winners)} of six numbers correct!");
                WriteLine("Adieu");
                }
            else
                {
                WriteLine("\n Ade.");
                }

            ReadKey();
            }

        public static int[] Tipico()
            {
            // Initialize variables
            int[] tips = new int[6];
            int i = 0;
            //Message
            WriteLine("Please enter six numbers from 1 to 49. \n " +
                "Press enter after every number.");
            //take input and check for validity
            while(i < 6)
                {
                Write($"{i + 1}: ==> ");
                int tip = Convert.ToInt32(ReadLine());
                if(tip > 49 || tip < 1)
                    {
                    WriteLine("Wrong number!Try again!");
                    }
                else
                    {
                    tips[i] = tip;
                    i++;
                    }
                }
            return tips;
            }
        public static int ChickenDinner(int[] playerBet,int[] winners)
            {
            int matches = 0;
            Array.Sort(playerBet);
            //WriteLine(" debug pb");
            //foreach(int z in playerBet)
            //    {
            //    Write(z + ", ");
            //    }
            Array.Sort(winners);
            //WriteLine(" debug ww");
            //foreach(int x in winners)
            //    {
            //    Write(x + ", ");
            //    }
            for(int i = 0;i < 6;i++)
                {
                if(playerBet[i] == winners[i])
                    {
                    matches++;
                    }
                }
            return matches;
            }
        }
    }