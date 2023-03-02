using static System.Console;

namespace ShoppingMall
    {
    static class Menue
        {
        public static void Startup()
            {
            bool working = true;
            do
                {
                WriteLine("Welcome, user.\n" +
                    "Please choose your program: \n" +
                    "1: Bill \n" +
                    "2: Stop program");
                /*Does break the program*/
                //int process = Convert.ToInt32(ReadLine());
                /* Holds the program stable*/
                Int32.TryParse(ReadLine(),out int process);
                if(process == 1)
                    {

                    }
                else if(process == 2)
                    {
                    working = false;
                    }
                else
                    {
                    WriteLine("Wrong input, restart Program.\n" +
                        ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
                    }
                }
            while(working == true);
            }
        }
    }
