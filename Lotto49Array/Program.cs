using static System.Console;

namespace SSE
    {
    public class Program
        {
        static void Main(string[] args)
            {
            /* JOBDESCRIPTION
            //Pick a number,print it out
            WriteLine("Brudah gib Nummah!");
            int dig;
            //convert given number
            dig = Convert.ToInt32(ReadLine());
            //insert converted number
            int[] lotto = new int[dig];
            //fill each place with an increasing number
            //Lottery in germany has 49 digits.
            for(int i = 0;i < lotto.Length;i++)
                {
                lotto[i] = i + 1;
                WriteLine(lotto[i]);
                WriteLine("Whalla, habibi");
                }
            */
            // Initialize Array as database


            WriteLine("These are the numbers to be drawn from:");

            int[] lotto = new int[49];
            for(int o = 0;o < lotto.Length;o++)
                {
                lotto[o] = o + 1;
                WriteLine($"==> {string.Join(", ",lotto)}");
                }
            WriteLine("\n -----------------------------------");

            /*       //initialize collecting array
                   int[] winners = new int[6];
                   Random rand = new Random();
                   //draw them lucky basterds
                   for(int j = 0;j < 6;j++)
                       {
                       int draw = rand.Next(1,lotto.Length + 1);
                       winners[j] = draw;
                       //now take the chosen number out of the pool
                       lotto = lotto.Where((source,index) => index != draw - 1).ToArray();

                       // DEBUGGING
                       //debugging, th show that there are only unique numbers
                       WriteLine("\n ----------------------------------" +
                           "\n Remaining numbers (Just for debugging purpose)");
                       foreach(int k in lotto)
                           {
                           Write(k + " ");
                           }

                       }
                   WriteLine("\n -----------------------------------------------");
                   WriteLine("The lucky numbers for today are: ");
                   foreach(int val in winners)
                       {
                       Write(val + " ");
                       }
                   ReadKey();
                   }
       */
            // Michis Lösung
            /*

                        int i = 0;
                        int j = 0;
                        int temp = 0;
                        int x = 0;
                        int[] michi = new int[10];
                        Random rand = new Random();


                        for(i = lotto.Length - 1;i > 0;i--)
                            {

                            j = rand.Next(i + 1);

                            WriteLine("-------------------\n" +
                                   "Aktueller Befehl:\n" +
                                   "     j = rand.Next(i + 1);   \n " +
                                   "---------------------\n " +
                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}'");
                            Write($"==> {string.Join(", ",lotto)}");

                            temp = lotto[i];

                            WriteLine("---------------------\n" +
                                  "Aktueller Befehl:\n" +
                                  "      temp = lotto[i];   \n " +
                                  "-----------------------------\n " +
                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}'");
                            Write($"==> {string.Join(", ",lotto)}");
                            lotto[i] = lotto[j];

                            WriteLine("---------------------------\n" +
                                "Aktueller Befehl:\n" +
                                "     lotto[i] = lotto[j];   \n " +
                                "---------------------------\n" +
                                $"@@@@@@@@@@\n" +
                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}'");
                            Write($"==> {string.Join(", ",lotto)}");

                            lotto[j] = temp;

                            WriteLine("----------------------\n" +
                                "Aktueller Befehl:\n" +
                                "     lotto[j] = temp;   \n " +
                                "----------------------------\n" +
                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}'");
                            Write($"==> {string.Join(", ",lotto)}");

                            michi[x] = lotto[i];

                            WriteLine($"---------------------------\n" +
                                "Aktueller Befehl:\n" +
                                "     michi[x] = lotto[i];   \n " +
                                "}}}}}}}}}}}}}}}}" +

                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}");
                            Write($"==> {string.Join(", ",lotto)}");

                            x++;

                            WriteLine($"------------------\n" +
                                $"For Schleife i steht bei: '{i}' \n" +
                                $"Buffer Temp steht bei: '{temp}' \n" +
                                $"Randomzahl j,gezogen aus '{i + 1}' ist : '{j}' \n" +
                                $"Lottozahl an Position '{i}' lautet: '{lotto[i]}' \n" +
                                $"Michi Array lautet: ");
                            foreach(int z in michi)
                                {
                                Write(z + " ");
                                }
                            WriteLine("------------------------");
                            Write($"==> {string.Join(", ",lotto)}");
                            }
            */

            /*
                        bool exit = false;
                        while(exit == false)
                            {
                            int[] michi = new int[600];
                            Random rand = new Random();
                            int i;
                            int j;
                            int temp;
                            int x = 0;
                            for(i = lotto.Length - 1;i > 0;i--)
                                {
                                j = rand.Next(1,49);
                                temp = lotto[i];
                                lotto[i] = lotto[j];
                                lotto[j] = temp;
                                michi[x] = lotto[i];
                                x++;
                                WriteLine("------------------------");
                                Write($"==> {string.Join(", ",lotto)}");
                                }
                            if(Array.IndexOf(michi,lotto[i]) != -1)
                                {
                                WriteLine("");
                                Console.WriteLine($"{lotto[i]} is double!HA!");
                                exit = true;
                                ReadKey();
                                }
                            }
            */
            int i = 0;
            int j = 0;
            int temp = 0;
            int x = 0;
            int[] michi = new int[50];
            Random rand = new Random();


            for(i = lotto.Length - 1;i > 0;i--)
                {

                j = rand.Next(i + 1);
                temp = lotto[i];
                lotto[i] = lotto[j];
                lotto[j] = temp;
                michi[x] = lotto[i];
                x++;
                WriteLine($"==> {string.Join(", ",lotto)}");
                }
            }
        }
    }