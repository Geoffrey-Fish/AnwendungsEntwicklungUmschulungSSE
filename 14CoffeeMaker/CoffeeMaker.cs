using static System.Console;

namespace SSE
    {
    internal class CoffeeMaker
        {
        int waterTankLevel = 30;
        int beanStorageLevel = 20;
        int wasteBucketLevel = 0;
        static int waterTankMax = 100;
        static int beanStorageMax = 100;
        static int wasteTankMax = 20;

        public CoffeeMaker()
            {
            WriteLine($"PrschBlrglbrrrrrrkkkkchrRrRrRrfffffffffitttsch");
            WriteLine($"Machine is ready to brew!");
            }

        public void Menu()
            {
            WriteLine("Main Menu: \n" +
                "1: Make Coffee\n" +
                "2: Check Water\n" +
                "3: Check Beans\n" +
                "4: Check Waste");
            Write("Choose 1,2,3,4: ==> ");
            int answer = Convert.ToInt32(ReadLine());
            switch(answer)
                {
                case 1:
                    MakeCoffee();
                    WriteLine("---");
                    break;
                case 2:
                    WriteLine($"Water at {WaterCheck()}.\n" +
                        $"Want to fill up?");
                    Write("(Y)es, (N)o: ==> ");
                    string answer2 = ReadLine().ToLower().Trim();
                    if(answer2 == "y")
                        {
                        Maintenance(1);
                        WriteLine("Maintenance done.");
                        break;
                        }
                    else
                        {
                        break;
                        }
                case 3:
                    WriteLine($"Beans at {BeanCheck()}.\n" +
                     $"Want to fill up?");
                    Write("(Y)es, (N)o: ==> ");
                    string answer3 = ReadLine().ToLower().Trim();
                    if(answer3 == "y")
                        {
                        Maintenance(2);
                        WriteLine("Maintenance done.");
                        break;
                        }
                    else
                        {
                        break;
                        }
                case 4:
                    WriteLine($"Waste at {WasteCheck()}.\n" +
                     $"Want to empty?");
                    Write("(Y)es, (N)o: ==> ");
                    string answer4 = ReadLine().ToLower().Trim();
                    if(answer4 == "y")
                        {
                        Maintenance(3);
                        WriteLine("Maintenance done.");
                        break;
                        }
                    else
                        {
                        break;
                        }
                default:
                    WriteLine("Deadly fail");
                    break;
                }
            }

        /// <summary>
        /// Coffee Maker Makes Coffee!
        /// </summary>
        ////////////////////////////BREW COFFEE////////////////////////////////////////////////////////////////////////////
        public void MakeCoffee()
            {
            Clear();
            WriteLine("Checking levels...\n" +
                "...\n" +
                "...\n");
            /* Checking status of every part and anser accordingly */
            string wtl = this.waterTankLevel <= 0 ? "Fill up" : "good";
            string bsl = this.beanStorageLevel <= 0 ? "Fill up" : "good";
            string wbl = this.wasteBucketLevel >= CoffeeMaker.wasteTankMax ? "Empty Wastebucket" : "good";
            /* Result of the check */
            WriteLine("-----");
            WriteLine($" Water: {wtl}.\n" +
                $" Beans: {bsl}.\n" +
                $" WasteBucket: {wbl}.");
            WriteLine("-----");
            /* If one of the Parameters is off, forced to Maintenance */
            if(wtl == "good" && bsl == "good" && wbl == "good")
                {
                WriteLine("PFFFFFbrrrrRRrrrRschcshcshcshcscscscscfffffBrxBrxBrxswooosh..." +
                    " Please enjoy your coffee!");
                /* You make coffee, so you change values, amirite?*/
                ValueChange();
                }
            else
                {
                WriteLine("Please maintain your Machine accordingly before use...\n" +
                    "...Starting Maintenance.\n " +
                    "-------------------------");

                Maintenance(0);
                }
            }


        /// <summary>
        /// Automaticly change storages after brewing
        /// </summary>
        private void ValueChange()
            {
            this.waterTankLevel -= 15;
            this.beanStorageLevel -= 7;
            this.wasteBucketLevel += 7;
            }

        /// <summary>
        ///If one of the storages is empty, this is called by the user OR by the Make Coffee instance
        /// </summary>
        /// <param name="x">if choice to give or not</param>
        public void Maintenance(int x)
            {
            int temp;
            if(x == 0)
                {
                WriteLine("Welcome to the Maintenance Menu.\n " +
                    "What needs to be filled or emptied?\n" +
                    "1: Water\n" +
                    "2: Beans\n" +
                    "3: Wastebucket");
                Write("Choose 1,2,3:==> ");
                x = Convert.ToInt32(ReadLine());
                }
            switch(x)
                {
                case 1:
                    temp = waterTankMax - this.waterTankLevel;
                    this.waterTankLevel = waterTankMax;
                    WriteLine($"Water filled up with {temp} units.");
                    WriteLine("-----");
                    break;
                case 2:
                    temp = beanStorageMax - this.beanStorageLevel;
                    this.beanStorageLevel = beanStorageMax;
                    WriteLine($"Beans filled up with {temp} units.");
                    WriteLine("-----");
                    break;
                case 3:
                    temp = wasteBucketLevel;
                    this.wasteBucketLevel = 0;
                    WriteLine($"{temp} units removed from the WasteBucket.");
                    WriteLine("-----");
                    break;
                default:
                    WriteLine("Fatal Error, call for help!");
                    break;
                }
            }


        private int WaterCheck()
            {
            return this.waterTankLevel;
            }
        private int BeanCheck()
            {
            return this.beanStorageLevel;
            }
        private int WasteCheck()
            {
            return this.wasteBucketLevel;
            }


        }
    }
