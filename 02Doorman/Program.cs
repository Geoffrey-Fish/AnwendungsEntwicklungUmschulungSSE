using static System.Console;
/*good old Doorman*/
/*while true keeps app open and is for clean practice*/

namespace SSE
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            while(true)
                {
                WriteLine("Stop right there! How old are you?");
                int? age = Convert.ToInt32(ReadLine());
                switch(age)
                    {
                    case < 18:
                        WriteLine("Forget it, kiddo!");
                        break;
                    case > 40:
                        WriteLine("The cemetery is over there,Grampa!");
                        break;
                    case >= 18:
                        WriteLine("Come on in!");
                        break;
                    default:
                        WriteLine("ERROR");
                        break;
                    }
                /*Exit Command*/
                Environment.Exit(0);
                }
            }
        }
    }
