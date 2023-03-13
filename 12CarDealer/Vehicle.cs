using static System.Console;

namespace SSE
    {
    class Vehicle
        {
        public string medium;
        public string brand;
        public string colour;
        public int speed;
        public Vehicle()
            {
            WriteLine("I am but a humble car, \n " +
                "ain't got no soul nor colour, \n" +
                "yet, here we are...");
            }
        /// <summary>
        /// Vehicle is the parent class
        /// </summary>
        /// <param name="medium">Air, land, sea</param>
        /// <param name="brand">Company fabricated it</param>
        /// <param name="colour">Well, colour</param>
        /// <param name="speed">Speed,baby</param>
        public Vehicle(string medium,string brand,string colour,int speed)
            {
            this.medium = medium;
            this.brand = brand;
            this.colour = colour;
            this.speed = speed;
            WriteLine($"Vehicle invoked");
            }

        public void infos()
            {
            WriteLine($"Moves in Medium: {this.medium}.\n " +
                $"Brand: {this.brand}.\n" +
                $"Colour: {this.colour}.\n" +
                $"Max speed: {this.speed}.");
            }
        }
    }
