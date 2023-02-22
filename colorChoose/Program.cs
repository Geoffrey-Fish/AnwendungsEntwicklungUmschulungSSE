﻿using static System.Console;
namespace SSE
    {
    public static class Program
        {
        public static void Main(string[] args)
            {
            int tries = 3;
            while(tries != 0)
                {
                WriteLine("Welcome, please change my Color: (R)ed, (G)reen, (B)lue.");
                string? color = ReadLine().ToLower();
                switch(color)
                    {
                    case "r" or "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        WriteLine("Isn't that a nice, powerfull Red !");
                        continue;
                    case "g" or "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        WriteLine("I really like green? I guess??");
                        continue;
                    case "b" or "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        WriteLine("Blue is not so nice, but whayne...");
                        continue;
                    default:
                        tries--;
                        continue;
                    }

                WriteLine("That's it!\n" +
                    " Really well done, Buddy! \n" +
                    " Press any key to stop this!");
                ReadKey();
                Environment.Exit(0);
                }
            /*After 3 times you get kicked out!*/
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("That was too many times just wrong input,mate...Cya!");
            }
        }
    }