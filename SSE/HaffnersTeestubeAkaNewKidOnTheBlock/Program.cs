using static System.Console;

namespace SSE
    {
    class Programm
        {
        static void Main(string[] args)
            {
            Person p1 = new Person();
            p1.name = "Hans";
            p1.gebDat = new DateTime(1999,9,9);
            p1.adr = new Adress();
            p1.adr.strasse = "wurstgasse";
            p1.adr.nummer = "3C"; // string because of char possible
            p1.adr.plz = "04321"; // string because of leading zero possible!!!!
            p1.adr.ort = "Kaff";



            WriteLine($"First creation: {p1.name},{p1.adr.strasse}.");
            ReadKey();
            }
        }
    }