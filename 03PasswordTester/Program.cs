using System.Text.RegularExpressions;
using static System.Console;

namespace SSE
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            /*Having fun with RegEx!
            *This one looks terrifying as fuck, but it essentially asks:
             * Is there:
             * A Capital Letter?
             * A lower Letter?
             * A Number?
             * A Special Char?
             * Is it at least 4 chars long?*/
            Regex pwcheck = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{4,}$");

            /* This one does not work because it just looks if anything at all is in the password. Don't do this!
            *Regex pwcheckV2 = new Regex("^(?=.*?[A-Za-z0-9_#?!@*%^&*-]).{6,}$");*/

            bool exit = false;
            while(exit == false)
                {
                WriteLine("Please choose a password, containing minimum: \n - 4 chars\n - Uppercase\n - LowerCase\n - Digit\n - special char:");
                string? pw = ReadLine();

                if(pwcheck.IsMatch(pw))
                    {
                    /* Mean trick, clean the screen so u must actually remember what you did^^*/
                    Clear();
                    WriteLine("Please repeat your Password now:");
                    string? pwr = ReadLine();
                    if(pw == pwr)
                        {
                        WriteLine("Correct!\n Well done.\n You may exit now by pressing X.");
                        string? ext = ReadLine().ToLower();
                        exit = ext == "x" ? true : false;
                        }
                    }
                else
                    {
                    WriteLine("Your password does not meet the requiered complexity.\n Please try again.\n" +
                        "(Y)es to proceed, (N)o to Exit");
                    string? ext = ReadLine().ToLower();
                    exit = ext == "n" ? true : false;
                    }
                }
            }
        }
    }