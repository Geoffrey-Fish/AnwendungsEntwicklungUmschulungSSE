using static System.Console;

namespace AbstractInterface
    {
    abstract class Animal
        {
        string name;
        int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void TellAge()
            {
            WriteLine($"This animal is {age} years old.");
            }
        /* You can build an abstract  method.
         * use this syntax:
         *<accessmodifier> abstract <returnvalue><methodname>();
         * An abstract class has no body(codeblock). That will be initialized inside the child class.
         * */

        public abstract void Sound();

        // lets go to dog
        }
    }
