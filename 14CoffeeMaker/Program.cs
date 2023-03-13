/*Create class coffee machine
 * Water level and bean quantity as fields.
   Two methods if water or beans have to be filled up
in addition two static methods named maxwaterlevel and maxbeanquantity
class must be encapsulated data safe.
two more methods should be able to return how much water and beans could be refilled.
extra challenge for me: make another garbage container and a milk foam cleaner
*/
using static System.Console;
namespace SSE
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool exit = false;
            CoffeeMaker Nespresso = new CoffeeMaker();
            while(exit == false)
                {
                Nespresso.Menu();
                WriteLine("#########");
                WriteLine("Want to end that?");
                Write("(Y)es, (N)o: ==> ");
                string answer = ReadLine().ToLower().Trim();
                if(answer == "y" || answer == "yes")
                    {
                    exit = true;
                    }
                Clear();
                }
            }
        }
    }


