using static System.Console;

namespace SSE
    {
    public class Program
        {
        static void Main(string[] args)
            {
            string medium = "Bike";
            string name = " Turbo";
            string user = "jens";

            string brand = "Volvo";
            string colour = "yellow";
            int speed = 87;

            /* Time saver
            WriteLine("-----");
            WriteLine(" What do you want?\n " +
                " Which brand?");
            Write("==>");
            brand = ReadLine();
            WriteLine(" Which colour?");
            Write("==>");
            colour = ReadLine();
            WriteLine(" And how fast may it drive?");
            Write("==>");
            speed = Convert.ToInt32(ReadLine());
            WriteLine(" Air, Land, Sea?");
            Write("==>");
            medium = ReadLine();
            WriteLine(" What is your name?");
            Write("==>");
            user = ReadLine();
*/
            WriteLine("-----");
            Vehicle bobby = new Vehicle(medium,brand,colour,speed);
            WriteLine($" Thank you, {user}.\n" +
                " That is your Vehicle order now:");

            WriteLine("-----");
            bobby.infos();
            WriteLine("-----");

            WriteLine($"{user}, see what happens if I just invoke a vehicle without infos!:");

            Vehicle billy = new Vehicle();

            WriteLine("-----");

            WriteLine("Now a child CAR without params,see what happens:");
            Car wurst = new Car();
            WriteLine("-----");
            WriteLine("And now a regular car with params:");
            Car hans = new Car(medium,brand,name,colour,speed);
            WriteLine("-----");
            WriteLine("Infos(Parent method) prints:");
            hans.infos();
            WriteLine("-----");
            WriteLine("Info(this childs method) prints:");
            hans.info();
            WriteLine("-----");
            WriteLine($"The price tag says: {hans.getPrice()} Yen");
            hans.setPrice(39999);
            WriteLine($"Now,after setting the value, an updated pricetag: {hans.getPrice()} Yen");
            WriteLine("-----");
            WriteLine($"Lets set {hans.Name}'s name to Jupiter!");
            hans.Name = "voro";
            WriteLine($"Hans new name is {hans.Name}.");

            }
        }
    }