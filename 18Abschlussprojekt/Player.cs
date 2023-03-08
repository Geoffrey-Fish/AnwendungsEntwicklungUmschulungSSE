using static System.Console;

namespace RPGOne
    {/// <summary>
     /// It is more fun to be a Player, ayght? ^^
     /// </summary>
    public class Player
        {
        //todo: include weight and think about
        //todo: dmg and ar
        public string name = "PLAYER";
        public int posX = 0;
        public int posY = 0;
        public int? max_hp = null;
        public int hp = 0;
        public int xp = 0;
        public int gp = 0;
        public int? st = null;
        public int? dex = null;
        public List<Item> items = new List<Item>();
        public List<Weapon> weapons = new List<Weapon> { };
        public List<Armor> armors = new List<Armor> { };
        public int dmg; //by weapon
        public int ar; //armor


        /// <summary>
        /// Create Method is interactive
        /// </summary>
        /// <param name="Player">Empty object</param>
        public Player()
            {
            //Do while for creation. Only full rolled char may start
            bool creation = false;
            do
                {
                WriteLine("CREATING YOUR CHARACTER:");
                WriteLine("(N)AME YOUR CHARACTER");
                WriteLine("(R)OLL YOUR CHARACTER");
                WriteLine("(P)LAY GAME");
                Write("==> ");
                string[] choice = new string[] { "N","R","P" };
                string? user_input = UserInput(choice);

                switch(user_input)
                    {
                    case "N":
                        WriteLine("WHAT IS YOUR NAME?");
                        Write("=>>");
                        string? name = ReadLine().ToUpper().Trim();
                        this.name = name;
                        WriteLine($"{name}?\n" +
                            $"SOUNDS ABOUT RIGHT.");
                        Thread.Sleep(1000);
                        break;

                    case "R":
                        WriteLine("---------------------");
                        WriteLine("LET'S SEE YOUR HEALTH...");
                        WriteLine("ROLLING HP...");
                        Thread.Sleep(1000);
                        int roll = RollDice(20,40);
                        hp = roll;
                        WriteLine($"YOU START WITH: {hp} HP!\n" +
                            $"SO YOUR HP CAP IS: {max_hp = hp * 4}");
                        Thread.Sleep(1000);

                        WriteLine("---------------------");
                        WriteLine("LET'S SEE YOUR MUSCLES THEN...");
                        WriteLine("ROLLING...");
                        Thread.Sleep(1000);
                        roll = RollDice(20,60);
                        st = roll;
                        WriteLine($"YOUR POWER IS {st} !");
                        Thread.Sleep(1000);

                        WriteLine("---------------------");
                        WriteLine("AT LAST YOUR DEXTERITY...");
                        WriteLine("ROLLING...");
                        Thread.Sleep(1000);
                        roll = RollDice(20,60);
                        dex = roll;
                        WriteLine($"{dex} IS YOUR DEXTERITY.");
                        WriteLine("---------------------");
                        break;

                    case "P":
                        if(this.name is "PLAYER" || hp is 0)
                            {
                            Clear();
                            WriteLine("FINISH MAKING YOUR CHARACTER!");
                            WriteLine("---------------------");
                            break;
                            }
                        else
                            {
                            //Everything is ok, lets go and end the do while loop
                            //And don't let that poor fella walk naked!
                            items.Add(Item.minor_health);
                            weapons.Add(Weapon.short_sword);
                            armors.Add(Armor.towel);
                            WriteLine("HAVE FUN PLAYING THE GAME AND DON'T DIE!");
                            creation = true;
                            }
                        break;
                    default:
                        WriteLine("INVALID!\nCHOOSE AN OPTION:\n 'N', 'R' OR 'P'");
                        WriteLine("---------------------");
                        break;
                    }
                } while(!creation);
            }

        /// <summary>
        /// Takes Userinput, checks and converts it and returns the value
        /// </summary>
        /// <param name="array">Possible chars given</param>
        /// <returns>Chosen char</returns>
        public string UserInput(string[] array)
            {
            string? user_input = ReadLine().ToUpper().Trim();
            if(!array.Contains(user_input))
                {
                WriteLine("WRONG INPUT.");
                UserInput(array);
                }
            return user_input;
            }


        //todo: include weight
        /// <summary>
        /// Show actual status of Player
        /// </summary>
        public void Status()
            {
            Clear();
            WriteLine("-------POSITION---------");
            WriteLine($"YOU ARE IN THE {Room.Locate(posX,posY)}");
            WriteLine(name + "`S POS X: " + posX);
            WriteLine(name + "`S POS Y: " + posY);

            WriteLine("-------STATS------------");
            WriteLine($"HEALTH: {hp} OF: {max_hp}");
            WriteLine("STRENGTH: " + st);
            WriteLine("DEXTERITY: " + dex);
            WriteLine("DAMAGE: " + dmg);
            WriteLine("DEFENCE: " + ar);
            WriteLine("EXPIERIENCE: " + xp);
            WriteLine("GOLD: " + gp);

            if(items.Count > 0)
                {
                WriteLine("---------------------");
                WriteLine("YOUR BAG CONTAINS: ");
                foreach(Item item in items)
                    {
                    WriteLine(item.name);
                    }
                }
            if(weapons.Count > 0)
                {
                WriteLine("---------------------");
                WriteLine("YOUR WEAPONS: ");
                foreach(Weapon weapon in weapons)
                    {
                    WriteLine(weapon.name);
                    }
                }
            if(armors.Count > 0)
                {
                WriteLine("---------------------");
                WriteLine("YOUR ARMOR: ");
                foreach(Armor armor in armors)
                    {
                    WriteLine(armor.name);
                    }
                }
            WriteLine("---------------------");
            }


        /// <summary>
        /// Personal Dice machine
        /// </summary>
        /// <param name="name">Playername</param>
        /// <param name="min">min value</param>
        /// <param name="max">max value -1</param>
        /// <returns></returns>
        public int RollDice(int min,int max)
            {
            Random Dice = new Random();
            int roll = Dice.Next(min,max);
            WriteLine($"{name} ROLLED: {roll}");
            return roll;
            }


        //todo: weapon and armor choose for active weapon
        /// <summary>
        /// To look at the inventory and interact with its contents
        /// todo: the weight might play here also!
        /// </summary>
        /// <param name="room"> The room the player is at</param>
        /// <param name="player">The player</param>
        public void Inventory(Room room,Player player)
            {
            Clear();
            WriteLine("INVENTORY OPTIONS:\n" +
                "| (P)ICK UP\n" +
                "| (D)ROP\n" +
                "| (B)ACK");
            Write("==> ");
            string[] choice = new string[] { "P","D","B" };
            string user_input = UserInput(choice);
            if(user_input == "P")
                {
                if(room.items.Count == 0 && room.weapons.Count == 0 && room.armors.Count == 0)
                    {
                    WriteLine("SORRY,BUT THIS ROOM IS EMPTY!");
                    }
                WriteLine("LOOK AT THE ITEMS HERE:");
                Thread.Sleep(500);
                PickUpItems(room,room.items,items);
                WriteLine("WHAT ABOUT THESE WEAPONS?");
                Thread.Sleep(500);
                PickUpWeapons(room,room.weapons,weapons);
                WriteLine("SOME ARMOR, MAYBE?");
                Thread.Sleep(500);
                PickUpArmors(room,room.armors,armors);
                }
            else if(user_input == "D")
                {
                if(player.items.Count == 0 && player.weapons.Count == 0 && player.armors.Count == 0)
                    {
                    WriteLine("SORRY,BUT YOU ARE NEKKID, LOL");
                    }
                Drop(room);
                }
            else if(user_input == "B")
                {
                WriteLine("GOING BACK TO MOVEMENT MENU");
                Program.Grid(this);
                }
            }


        /// <summary>
        /// Pick valuable Items from the Floor
        /// </summary>
        /// <param name="room">The Room you are at</param>
        /// <param name="roomObjList">The items in the room</param>
        /// <param name="playerObjList">Players bag</param>
        void PickUpItems(Room room,List<Item> roomObjList,List<Item> playerObjList)
            {
            if(roomObjList.Count > 0)
                {
                foreach(Item obj in roomObjList)
                    {
                    WriteLine(obj.name);
                    WriteLine("(P)ICK UP?\n| (N)EXT?\n| (B)ACK?");
                    string[] choice = new string[] { "P","N","B" };
                    string userInput = UserInput(choice);
                    if(userInput == "P")
                        {
                        WriteLine(name + " PICKS UP " + obj.name);
                        roomObjList.Remove(obj);
                        playerObjList.Add(obj);
                        }
                    else if(userInput == "N")
                        {
                        continue;
                        }
                    else if(userInput == "B")
                        {
                        return;
                        }
                    }
                }
            else
                {
                WriteLine("THERE IS NOTHING!WANNA DROP INSTEAD?\n| (Y)ES\n| (N)O");
                string[] choice = new string[] { "Y","N" };
                string userInput = UserInput(choice);
                if(userInput == "Y")
                    {
                    Drop(room);
                    }
                else if(userInput == "N")
                    {
                    return;
                    }
                }
            }


        /// <summary>
        /// Pick valuable Weapons from the Floor
        /// </summary>
        /// <param name="room">The Room you are at</param>
        /// <param name="roomObjList">The weapons in the room</param>
        /// <param name="playerObjList">Players bag</param>
        void PickUpWeapons(Room room,List<Weapon> roomObjList,List<Weapon> playerObjList)
            {
            if(roomObjList.Count > 0)
                {
                foreach(Weapon obj in roomObjList)
                    {
                    WriteLine(obj.name);
                    WriteLine("(P)ICK UP?\n| (N)EXT?\n| (B)ACK?");
                    string[] choice = new string[] { "P","N","B" };
                    string userInput = UserInput(choice);
                    if(userInput == "P")
                        {
                        WriteLine(name + " PICKS UP " + obj.name);
                        roomObjList.Remove(obj);
                        playerObjList.Add(obj);
                        }
                    else if(userInput == "N")
                        {
                        continue;
                        }
                    else if(userInput == "B")
                        {
                        return;
                        }
                    }
                }
            else
                {
                WriteLine("THERE IS NOTHING!WANNA DROP INSTEAD?\n| (Y)ES\n| (N)O");
                string[] choice = new string[] { "Y","N" };
                string userInput = UserInput(choice);
                if(userInput == "Y")
                    {
                    Drop(room);
                    }
                else if(userInput == "N")
                    {
                    return;
                    }
                }
            }


        /// <summary>
        /// Pick valuable Armor from the Floor
        /// </summary>
        /// <param name="room">The Room you are at</param>
        /// <param name="roomObjList">The Armor in the room</param>
        /// <param name="playerObjList">Players bag</param>
        void PickUpArmors(Room room,List<Armor> roomObjList,List<Armor> playerObjList)
            {
            if(roomObjList.Count > 0)
                {
                foreach(Armor obj in roomObjList)
                    {
                    WriteLine(obj.name);
                    WriteLine("(P)ICK UP?\n| (N)EXT?\n| (B)ACK?");
                    string[] choice = new string[] { "P","N","B" };
                    string userInput = UserInput(choice);
                    if(userInput == "P")
                        {
                        WriteLine(name + " PICKS UP " + obj.name);
                        roomObjList.Remove(obj);
                        playerObjList.Add(obj);
                        }
                    else if(userInput == "N")
                        {
                        continue;
                        }
                    else if(userInput == "B")
                        {
                        return;
                        }
                    }
                }
            else
                {
                WriteLine("THERE IS NOTHING!WANNA DROP INSTEAD?\n| (Y)ES\n| (N)O");
                string[] choice = new string[] { "Y","N" };
                string userInput = UserInput(choice);
                if(userInput == "Y")
                    {
                    Drop(room);
                    }
                else if(userInput == "N")
                    {
                    return;
                    }
                }
            }


        /// <summary>
        /// Drop Function for throwing stuff away- wait till the player sees how much money he could make at the store...hehehe...
        /// </summary>
        /// <param name="room">The room to be littered</param>
        void Drop(Room room)
            {
            if(items.Count == 0 && weapons.Count == 0 && armors.Count == 0)
                {
                WriteLine("OH BOY,HOW DID YOU GET NEKKID???CYA...");
                Program.Grid(this);
                }
            WriteLine("DROP:\n| (I)TEM ? \n| (W)EAPON ?\n| (A)RMOR ?");
            string[] choice = new string[] { "I","W","A" };
            string userInput = UserInput(choice);
            if(userInput == "I")
                {
                WriteLine("DROPPING ITEM");
                foreach(Item item in items)
                    {
                    WriteLine("DROPPING " + item.name);
                    WriteLine("You sure?\n| (Y)ES\n| OR (N)O");
                    string[] choice2 = new string[] { "Y","N" };
                    string input = UserInput(choice2);
                    if(input == "Y")
                        {
                        items.Remove(item);
                        room.items.Add(item);
                        }
                    else if(input == "N")
                        {
                        continue;
                        }
                    else
                        {
                        WriteLine("WRONG INPUT, DUDE.");
                        Drop(room);
                        }
                    }
                }
            else if(userInput == "W")
                {
                WriteLine("DROPPING WEAPON");
                foreach(Weapon weapon in weapons)
                    {
                    WriteLine("DROPPING " + weapon.name);
                    WriteLine("You sure?\n| (Y)ES\n| OR (N)O");
                    string[] choice3 = new string[] { "Y","N" };
                    string input = UserInput(choice3);
                    if(input == "Y")
                        {
                        weapons.Remove(weapon);
                        room.weapons.Add(weapon);
                        }
                    else if(input == "N")
                        {
                        continue;
                        }
                    else
                        {
                        WriteLine("WRONG INPUT, DUDE.");
                        Drop(room);
                        }
                    }
                }
            else if(userInput == "A")
                {
                WriteLine("DROPPING ARMOR");
                foreach(Armor armor in armors)
                    {
                    WriteLine("DROPPING " + armor.name);
                    WriteLine("You sure?\n| (Y)ES\n| OR (N)O");
                    string[] choice4 = new string[] { "Y","N" };
                    string input = UserInput(choice4);
                    if(input == "Y")
                        {
                        armors.Remove(armor);
                        room.armors.Add(armor);
                        }
                    else if(input == "N")
                        {
                        continue;
                        }
                    else
                        {
                        WriteLine("WRONG INPUT, COME ON!");
                        }
                    }
                }
            else
                {
                WriteLine("WRONG INPUT,GOOD LORD!!!");
                Drop(room);
                }
            }

        /////
        }
    }