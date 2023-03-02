using static System.Console;

namespace ShoppingMall
    {
    static class Menue
        {
        public static void Startup()
            {
            bool programWorks = true;
            do
                {
                WriteLine("Welcome, user.\n" +
                    "Please choose your program: \n" +
                    "1: Shopping \n" +
                    "2: Coffee shop \n" +
                    "3: Play Lotto \n" +
                    "4: Stop that program");
                /*Does break the program*/
                //int process = Convert.ToInt32(ReadLine());
                /* Holds the program stable*/
                Int32.TryParse(ReadLine(),out int process);
                switch(process)
                    {
                    case 1:
                        Calculations.Calculation();
                        break;
                    case 2:
                        CoffeeMaker espresso = new CoffeeMaker();
                        espresso.Menu();
                        break;
                    case 3:
                        Lotto.LottoGame();
                        break;
                    case 4:
                        programWorks = false;
                        break;
                    default:
                        WriteLine("Wrong input, restart Program.\n" +
                        ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
                        break;
                    }
                }
            while(programWorks == true);
            }
        }
    }
