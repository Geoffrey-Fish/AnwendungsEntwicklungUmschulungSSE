using static System.Console;

namespace AbstractInterface
    {
    internal class Dog: Animal // Dog inherits Animal
        {
        string furColor;

        public string FurColor { get => furColor; set => furColor = value; }
        public Dog(string name,int age,string furColor)
            {
            Name = name;
            Age = age;
            FurColor = furColor;
            }

        /*An abstract method of the parent class MUST be in the inheriting classes and be defined in them.
         * <accessmodifier> override <returnvalue><methodname>(){}
         * */
        public override void Sound()
            {
            WriteLine("A dog ==> \"Barks\"");
            }

        //lets go to program
        }
    }
