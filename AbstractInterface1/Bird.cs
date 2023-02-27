using static System.Console;

namespace AbstractInterface
    {
    internal class Bird: Animal, IFly // Bird inherits Animal AND IFly
        {
        int span;
        bool canFly;

        public Bird(string name,int age,int span,bool canFly)
            {
            Name = name;
            Age = age;
            Span = span;
            CanFly = canFly;
            }

        public int Span { get => span; set => span = value; }
        public bool CanFly { get => canFly; set => canFly = value; }

        public override void Sound()
            {
            WriteLine("A Bird \"Chirps\"");
            }
        public void Routing()
            {
            WriteLine("The Routing Code will be implemented here later on.");
            }
        }
    }
