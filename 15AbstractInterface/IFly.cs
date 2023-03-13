using static System.Console;

namespace AbstractInterface
    {
    /*
     * An Interface gives special methods for other classes to use.
     * It cant have any other kind of members.
     * */
    internal interface IFly
        {
        /*
         * The methods of an Interface are per se ABSTRACT and don't have any Accessmodifiers.
         The syntax is:
        <returntype> <methodname>();
        */
        void Routing();

        /* Contrary to an abstract class, the methods of an Interface CAN have a codeblock already.
         */
        void Fly(bool cf)
            {
            if(cf)
                {
                WriteLine("The Fly code will be executed here later on");
                }
            else
                {
                WriteLine("This animal can't fly");
                }
            }
        }
    }
