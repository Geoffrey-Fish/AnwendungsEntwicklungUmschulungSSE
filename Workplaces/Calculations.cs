using static System.Console;
namespace ShoppingMall
    {
    static class Calculations
        {
        //build up testing data
        public static Employees co1 = new Employees("Max","Power","MainLane 1",0899,"Arkansas",001,10);
        public static Customers cu1 = new Customers("Miss","Maggie","Marple","Backyard 2",28273,"NewBerlin",001);
        public static Articles art1 = new Articles(1,"Clown doll",49.99m);//m stands for decimal
        public static Articles art2 = new Articles(2,"DickyDicksack",0.99m);
        public static Articles art3 = new Articles(3,"Zetzuai Bronze 14",9.99m);


        public static void Rechnung()
            {
            //this is a list!
            List<Articles> articleList = new List<Articles>();
            bool checkOut = false;
            decimal gesamtSumme = 0;
            do
                {
                WriteLine($"So what do you want to buy?\n" +
                    $"1: {art1.desc}\n" +
                    $"2:{art2.desc}\n" +
                    $"3: {art3.desc}");
                Int32.TryParse(ReadLine(),out int choice);
                switch(choice)
                    {
                    case 1:
                            {
                            articleList.Add(art1);
                            Clear();
                            WriteLine($"{art1} in checkout.");
                            break;
                            }
                    case 2:
                            {
                            articleList.Add(art2);
                            Clear();
                            WriteLine($"{art2} in checkout.");
                            break;
                            }
                    case 3:
                            {
                            articleList.Add(art3);
                            Clear();
                            WriteLine($"{art3} in checkout.");
                            break;
                            }
                    }

                }
            while(true);

            }
        }
    }
