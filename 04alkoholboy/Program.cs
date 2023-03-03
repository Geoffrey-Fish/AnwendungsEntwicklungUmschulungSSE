using static System.Console;

namespace alcoholic
    {
    class Program
        {
        public static int beer;
        public static double weight;
        public static double alcool;
        public static double bloodAlcool;
        public static void Main(string[] args)
            {
            DataCol();
            AlcCalc();
            Shaming();
            ReadKey();
            }
        public static void DataCol()
            {
            WriteLine("How many beers did you chuck down?");
            beer = Convert.ToInt32(ReadLine());
            WriteLine("How fat are you?");
            weight = Convert.ToInt32(ReadLine());
            }

        public static void AlcCalc()
            {
            alcool = (((beer * 500) * 0.05) * 0.8);
            bloodAlcool = (alcool / (0.7d * weight));
            bloodAlcool = Math.Round(bloodAlcool,2);
            }
        public static void Shaming()
            {
            switch(bloodAlcool)
                {
                case 0d:
                    WriteLine($"{bloodAlcool}! An innocent Angel over here!");
                    break;
                case <= 0.3d:
                    WriteLine($"{bloodAlcool}, that is still acceptable.Stay safe, buddy!");
                    break;
                case <= 0.5d:
                    WriteLine($"{bloodAlcool}, you sure you can drive?");
                    break;
                case <= 0.8d:
                    WriteLine($"{bloodAlcool}, You can't talk straight!");
                    break;
                case > 0.8d:
                    WriteLine($"{bloodAlcool}, you have a serious problem, dude...");
                    break;
                }
            }
        }
    }
