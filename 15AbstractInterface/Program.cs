using static System.Console;

namespace AbstractInterface
    {
    class Program
        {
        static void Main(string[] args)
            {

            Dog buddy = new Dog("buddy",7,"black");
            buddy.TellAge();
            buddy.Sound();

            //Interface IFly
            Bird polly = new Bird("Polly",4,60,true);
            polly.Sound();
            polly.Routing();
            ((IFly)polly).Fly(polly.CanFly);

            Bird dodo = new Bird("dodo",50,20,false);
            dodo.Sound();
            dodo.Routing();
            ((IFly)dodo).Fly(dodo.CanFly);

            ReadLine();
            }
        }
    }
