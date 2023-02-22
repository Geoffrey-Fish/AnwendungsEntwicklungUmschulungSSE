using static System.Console;

namespace SSE
    {

    public class Program
        {
        static void Main(string[] args)
            {
            /*-----BUBBLESORT V1---------*/
            int[] array = { 4,33,7,1,23,12,15,22,2,47,9,23,24,14,5,11,8,64,42 };

            WriteLine("Hi, i am a Bubblesort example.");
            WriteLine("This is the culprit:");
            WriteLine($"{string.Join(", ",array)}");

            for(int a = array.Length;a >= 0;a--)
                {
                int place1 = 0;
                int place2 = 1;
                WriteLine($"Round: {a}");
                WriteLine($"{string.Join(", ",array)}");
                for(int b = 0;b < array.Length - 1;b++)
                    {
                    if(array[place1] > array[place2])
                        {
                        (array[place1], array[place2]) = (array[place2], array[place1]);
                        place1++;
                        place2++;

                        }
                    else
                        {
                        place1++;
                        place2++;
                        }
                    }
                }
            WriteLine("Done! The array now looks like this:");
            WriteLine($"{string.Join(", ",array)}");
            /*---------Bubblesort optimized V2---------*/


            WriteLine("------------------------\n --------------------------");
            int[] brray = { 4,33,7,1,23,12,15,22,2,47,9,23,24,14,5,11,8,64,42 };
            bool exit = false;
            WriteLine("Hi, i am a Bubblesort V2 example.");
            WriteLine("This is the culprit:");
            WriteLine($"{string.Join(", ",brray)}");

            while(exit == false)
                {
                int place1 = 0;
                int place2 = 1;
                int changed = 0;
                for(int a = brray.Length;a >= 0;a--)
                    {
                    if(a < brray.Length && changed == 0)
                        {
                        exit = true;
                        break;
                        }
                    WriteLine($"changed is at: {changed}");
                    place1 = 0;
                    place2 = 1;
                    changed = 0;

                    WriteLine($"Round:{a}");
                    WriteLine($"{string.Join(", ",brray)}");

                    for(int b = 0;b < brray.Length - 1;b++)
                        {
                        WriteLine($"changed: {changed}");

                        if(brray[place1] > brray[place2])
                            {
                            (brray[place1], brray[place2]) = (brray[place2], brray[place1]);
                            place1++;
                            place2++;
                            changed++;
                            }
                        else
                            {
                            place1++;
                            place2++;
                            }
                        }
                    }
                }
            WriteLine("Done! The array now looks like this:");
            WriteLine($"{string.Join(", ",brray)}");
            }
        }
    }