using static System.Console;
/*
 * This project was all by myself as we had the instruction to 
 * play around with classes and methods.
 * I know that Stadt Land Fluss is a well known challenge in coding.
 * But I never had the idea before to actually do it!
 * So be welcome. This might not be pretty, but it is mine ^^
 * */
/*POST SCRIPTUM
* TODOS
*I want a timer implemented!
*/
namespace CLR
    {
    class Program
        {
        static void Main(string[] args)
            {
            /* Variable declaration */
            string c = "";
            string l = "";
            string r = "";

            /* Welcome message and Rules */
            WriteLine("Welcome to....");
            WriteLine("CITY");
            WriteLine("LAND");
            WriteLine("RIVER");
            WriteLine("!!!!!!!!!!!!!!!!!");

            /* Players give their names */
            WriteLine("Player one, please enter your Name: ");
            Write("==>");
            string? pOne = ReadLine();
            WriteLine("Player two, please enter your Name: ");
            Write("==>");
            string? pTwo = ReadLine();


            ///chatgpt
            CLRAnswers playerB = new CLRAnswers();
            CLRAnswers playerA = new CLRAnswers();

            /* Randommizer who will begin,
             * called first and second afterwards */
            Random begin = new Random();
            int beginner = begin.Next(1,3);
            string first = beginner == 1 ? pOne : pTwo;
            string second = first == pOne ? pTwo : pOne;

            /* First player begins */
            WriteLine($"{first},make sure that {second} can't see, which Letter I'll draw and what you write!\n" +
                $"When you are ready, u will have 60 seconds to answer.");
            WriteLine("Ready?");
            ReadKey();
            /* TODO: Implement Time! */

            /* Invoke Class Letter for random Letter */
            Letter chosenL = new Letter();
            string chose = chosenL.drawer();
            WriteLine($"I drew the Letter: {chose}.\n Go, {first}!");

            /* Send random letter and Playername to function */
            ///chatgpt
            PlayA(chose,first,playerA);


            /* Now it is second players turn.
            * Same as above*/

            /*Next Round */
            WriteLine($"Well done, {first}.\n" +
                $" Now, it is {second}'s turn!");

            /* Second player begins now */
            WriteLine($"{second},make sure that {first} can't see, which Letter I'll draw and what you write!\n" +
               $"When you are ready, u will have 60 seconds to answer.");
            WriteLine("Ready?");
            ReadKey();

            WriteLine($"I drew the Letter: {chose}.\n Go, {second}!");

            /* Send random letter and Name to function*/
            //TODO: eliminate that redundancy!!!
            ///chatgpt
            PlayB(chose,second,playerB);

            /////////////Endgame Area///////////////
            WriteLine($"Well done, {second}!.\n" +
                $"Now lets compare your results with the answers from {first}.");
            CompareAnswers(playerA,playerB);




            }


        /////////////////////////////////////////////////////////////

        /// <summary>
        /// Takes input from the player one and gives it to CLRAnswers
        /// </summary>
        /// <param name="a">The random Letter</param>
        /// <param name="playera">Playername</param>
        public static void PlayA(string a,string playera,CLRAnswers playerA)
            {
            /* Initialize variables */
            string city;
            string land;
            string river;

            /* Now take input */
            WriteLine($"Okay,{playera}, the time starts now!");
            WriteLine($"Choose a City with {a}: ");
            city = ReadLine().ToLower().Trim();
            WriteLine($"Choose a Land with {a}: ");
            land = ReadLine().ToLower().Trim();
            WriteLine($"Choose a River with {a}: ");
            river = ReadLine().ToLower().Trim();

            playerA.City = city;
            playerA.Land = land;
            playerA.River = river;
            //TODO: Implement Time!
            WriteLine("Time is up! Did you know it all?");
            //TODO Implement verification

            }

        public static void PlayB(string b,string playerb,CLRAnswers playerB)
            {
            /* Initialize variables */
            string city;
            string land;
            string river;

            /* Now take input */
            WriteLine($"Okay,{playerb}, the time starts now!");
            WriteLine($"Choose a City with {b}: ");
            city = ReadLine().ToLower().Trim();
            WriteLine($"Choose a Land with {b}: ");
            land = ReadLine().ToLower().Trim();
            WriteLine($"Choose a River with {b}: ");
            river = ReadLine().ToLower().Trim();

            /* Set the collected Data to Class CLRAnswers */
            playerB.City = city;
            playerB.Land = land;
            playerB.River = river;

            WriteLine("Time is up! Did you know it all?");

            }


        public static void CompareAnswers(CLRAnswers playerA,CLRAnswers playerB)
            {
            /* Compare the answers */
            if(playerA.City == playerB.City)
                {

                WriteLine("Both players chose the same city!");
                }
            else
                {
                WriteLine("The players chose different cities!");
                }
            if(playerA.Land == playerB.Land)
                {
                WriteLine("Both players chose the same land!");

                }
            else
                {
                WriteLine("The players chose different lands!");
                }
            if(playerA.River == playerB.River)
                {
                WriteLine("Both players chose the same river!");
                }
            else
                {

                WriteLine("The players chose different rivers!");
                }
            }
        }
    }

