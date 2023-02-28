using static System.Console;


namespace SSE
    {
    internal class Dynamic
        {
        /* Dynamic polymorphism checks at runtime which method is used.
         This decision is made for the method,which signature is identical, but has different implementation*/

        public void Output()
            {
            WriteLine("I am the output");
            }
        }

    class DynamicChild: Dynamic
        {
        /* In thi childclass we use the keyword new to show that this i a different implementation*/
        public new void Output()
            {
            WriteLine("I am the Child output");
            }
        }
    }
