using static System.Console;
namespace ShoppingMall
    {
    static class Calculations
        {
        //build up testing data
        public static Employees co1 = new Employees("Mister","Max","Power","MainLane 1",0899,"Arkansas",001,10);
        public static Customers cu1 = new Customers("Miss","Maggie","Marple","Backyard 2",28273,"NewBerlin",001);
        public static Articles art1 = new Articles(1,"Clown doll",49.99m);//m stands for decimal
        public static Articles art2 = new Articles(2,"DickyDicksack",3.97m);
        public static Articles art3 = new Articles(3,"Zetzuai Bronze(Shonen-Ai)",12.53m);


        public static void Calculation()
            {
            //this is a list!
            List<Articles> articleList = new List<Articles>();
            bool checkOut = false;
            decimal total = 0;
            do
                {
                WriteLine($"So what do you want to buy?\n" +
                    $"1: {art1.Desc}, {art1.Price} $\n" +
                    $"2:{art2.Desc}, {art2.Price} $\n" +
                    $"3: {art3.Desc}, {art3.Price} $\n" +
                    $"4: View Basket\n" +
                    $"5: Checkout now!");
                Write("==> ");
                Int32.TryParse(ReadLine(),out int choice);
                switch(choice)
                    {
                    case 1:
                            {
                            articleList.Add(art1);
                            Clear();
                            WriteLine($"You have {art1.Desc} put into your basket.");
                            break;
                            }
                    case 2:
                            {
                            articleList.Add(art2);
                            Clear();
                            WriteLine($"You have {art2.Desc} put into your basket.");
                            break;
                            }
                    case 3:
                            {
                            articleList.Add(art3);
                            Clear();
                            WriteLine($"You have {art3.Desc} put into your basket.");
                            break;
                            }
                    case 4:
                        WriteLine("Your basket contains the following Items: ");
                        decimal subtotal = 0;
                        foreach(var i in articleList)
                            {
                            WriteLine(i.Desc);
                            subtotal += i.Price;
                            }
                        WriteLine($"Sum: {subtotal}");
                        break;
                    case 5:
                            {
                            Clear();
                            WriteLine("Thank you!");
                            checkOut = true;
                            break;
                            }

                    default:
                        WriteLine("Wrong input, buddy.");
                        break;
                    }

                }
            while(checkOut == false);

            WriteLine("(C)ustomer or C(o)worker?");
            Write("==> ");
            string who = ReadLine().ToLower().Trim();
            switch(who)
                {
                case "c":
                    WriteLine($"Billing:\n" +
                        $"Recipient: {cu1.gender} {cu1.firstName} {cu1.surName}.\n" +
                        $"Send to:");
                    cu1.Adress();
                    WriteLine("Articles:");
                    foreach(var i in articleList)
                        {
                        WriteLine($"1 x {i.Desc}");
                        total += i.Price;
                        }
                    WriteLine($"----------\n" +
                        $"Total: {total.ToString("F")} $.\n" +
                        $"--------------\n" +
                        $"Thanks for your purchase\n" +
                        $"and have a nice day.");
                    break;
                case "o":
                    WriteLine($"Billing: \n" +
                        $"{co1.gender} {co1.surName},\n" +
                        $"Coworker Number: {co1.pID}.\n" +
                        $"Send to:");
                    co1.Adress();
                    WriteLine("Articles:");
                    foreach(var i in articleList)
                        {
                        WriteLine($"1 x {i.Desc}");
                        total += i.Price;
                        }
                    decimal totalpID = (total - (total / 100 * co1.rabbate));
                    WriteLine($"----------\n" +
                        $"Total: {totalpID.ToString("F")} $\n" +
                        $"----------\n" +
                        $"Thanks for your purchase\n" +
                        $"and have a nice day.");
                    break;
                default:
                    WriteLine("Wrong input, dude!");
                    break;
                }

            }
        }
    }
