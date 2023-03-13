using static System.Console;

namespace SSE
    {
    public static class Program
        {

        static string[] region = { "Sachsenzipfel","Berliner","Bremer","Hesse","Niedersachse","Rheinländer","Pfälzer","Schwab","Arroganter Arsch","Frangge" };
        static string? plz;
        public static void Main(string[] args)
            {
            while(true)
                {
                Frage();
                ReadKey();
                }
            }

        public static void Frage()
            {
            WriteLine("Woher kommschschschsch?? ");
            plz = ReadLine();
            if(plz.Length != 5)
                {
                WriteLine("Postleitzahl hat fünf Stellen, du Sebbl!");
                }
            else
                {
                int one = ToInt(plz[0]);
                PlzFinder(one);
                }
            }
        static int ToInt(this char c)
            {
            return (int)(c - '0');
            }
        public static void PlzFinder(int x)
            {
            WriteLine("Du bist a " + region[x]);
            }


        }
    }