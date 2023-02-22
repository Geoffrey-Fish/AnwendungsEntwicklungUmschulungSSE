using static System.Console;
namespace SSE
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            bool exit = false;
            while(!exit)
                {
                WriteLine("-------------------------------------\n" +
                    " Welcome to Calculus2000. \n" +
                    " What kind of Operation do you want to do? \n" +
                    " Enter the coresponding number, please: \n" +
                    " 1: Addition (+)\n" +
                    " 2: Subtraction (-)\n" +
                    " 3: Multiplication (*)\n" +
                    " 4: Division (/)\n" +
                    " 5: Modulo (%)\n" +
                    "\n" +
                    "If you want to quit,enter Zero (0)");
                bool choice = int.TryParse(ReadLine(),out int prog);
                if(!choice)
                    {
                    WriteLine("Your Input is invalid.\n" +
                        "Shame on you!");
                    continue;
                    }
                else
                    {
                    if(prog == 0)
                        {
                        exit = true;
                        }
                    else
                        {
                        CallCalc(prog);
                        }
                    }
                }
            }
        static void CallCalc(int x)
            {
            double a;
            double b;


            WriteLine("Please enter now the two numbers you want to calculate:");
            Write("First: ");
            bool aa = double.TryParse(ReadLine(),out a);
            if(!aa)
                {
                WriteLine("Invalid Input!\n" +
                    "Try again!");

                }
            else
                {
                Write("Second: ");
                bool bb = double.TryParse(ReadLine(),out b);
                if(!bb)
                    {
                    WriteLine("Invalid Input!\n" +
                        "Try again!");
                    }
                else
                    {
                    switch(x)
                        {
                        case 1:
                            Addition(a,b);
                            break;
                        case 2:
                            Subtraction(a,b);
                            break;
                        case 3:
                            Multiplication(a,b);
                            break;
                        case 4:
                            Division(a,b);
                            break;
                        case 5:
                            Modulo(a,b);
                            break;
                        default:
                            break;
                        }
                    }
                }
            }
        static void Addition(double a,double b)
            {
            double c = a + b;
            WriteLine($"{a} + {b} = {c}.");
            }
        static void Subtraction(double a,double b)
            {
            double c = a - b;
            WriteLine($"{a} - {b} = {c}.");
            }
        static void Multiplication(double a,double b)
            {
            double c = a * b;
            WriteLine($"{a} * {b} = {c}.");
            }
        static void Division(double a,double b)
            {
            double c = a / b;
            WriteLine($"{a} / {b} = {c}.");
            }
        static void Modulo(double a,double b)
            {
            double c = a % b;
            WriteLine($"{a} % {b} = {c}.");
            }
        }
    }
