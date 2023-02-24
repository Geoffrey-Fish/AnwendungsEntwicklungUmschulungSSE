/*Erstelle Klasse Kaffeemaschine
 * Wasserstand und Bohnenmenge als Felder.
   Zwei methoden ob Wasser oder Bohnen aufgefüllt werden müssen
dazu zwei static methoden namens maxwasserstand und max bohnenmenge
klasse muss datensicher gekapselt sein.
zwei weitere methoden sollen zurück geben künnen, wie viel wasser und bohnen nachgefüllt werden könnte.
Extra challenge für mich: mach noch einen müll container und einen milchschaum reiniger
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
                else
                    {
                    Clear();
                    Nespresso.Menu();
                    }
                }
            }
        }
    }


