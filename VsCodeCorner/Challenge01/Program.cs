using System.ComponentModel;
using static System.Console;
namespace SSE
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to As Cold As Hot \n" +
            "aka 'ACAS");
            WriteLine("One or two players?");
            Write("==>");
            bool input = Int32.TryParse(ReadLine(), out int playerNumber);
            if (!input)
            {
                WriteLine("Wrong Input");
            }
            WriteLine("(N)ormal or (H)ardcore?");
            char? level = Convert.ToChar(ReadLine().ToLower().Trim());
            if (highscore != 0)
            {
                WriteLine("Want to know the highscore to beat?");
                Write("(Y)es/(N)o ==>");
                char? scoreCheck = Convert.ToChar(ReadLine().ToLower().Trim());

            }
        }
    }
}
