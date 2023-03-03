using static System.Console;

namespace SSE
    {
    class Car: Vehicle
        {
        string name;
        int price = 50399;

        public Car()
            {
            WriteLine("@@@@@ Child method print after creation after parent message @@@@@");
            WriteLine(" Simple, common car with nothing created");
            WriteLine("@@@@@");
            }
        public Car(string m,string b,string name,string c,int s)
            {
            this.medium = m;
            this.brand = b;
            this.colour = c;
            this.name = name;
            this.speed = s;
            WriteLine("-----");
            WriteLine(" New car created.");
            WriteLine("-----");
            }

        public void info()
            {
            WriteLine("-----");
            WriteLine($" My name is {this.name}.\n" +
                $" I move in {this.medium}.\n" +
                $" I was built by {this.brand}\n" +
                $" and i am {this.speed} fast!" +
                $"");
            WriteLine("-----");
            }
        public int getPrice()
            {
            return this.price;
            }
        public void setPrice(int x)
            {
            this.price = x;

            }
        public string Name { get => name; set => name = value; }

        }
    }
