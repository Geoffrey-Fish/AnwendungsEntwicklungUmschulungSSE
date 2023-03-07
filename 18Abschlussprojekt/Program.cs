using static System.Console;

namespace RPGOne
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool Exit = false;
            WriteLine("Proof of Concept for a simple CLI Dungeon adventure.\n" +
                "Material gathered a year ago with Python.");

            WriteLine("This is RPG One. A solo Adventure.");
            WriteLine();
            WriteLine("Welcome, stranger.");
            //Main loop
            while(Exit == false)
                {
                Player player = new Player();
                Narrative.Welcome(player.name);
                }
            }
        public void Options(Room room,Player player)
            {
            WriteLine("MOVE:\n| (N)ORTH\n| (E)AST\n| (S)OUTH\n| (W)EST\n|");
            WriteLine(" (L)OOK AT ME!\n| SHOW (R)OOM!\n|(M)AP?\n| ");
            WriteLine("  (I)NVENTORY?\n| (Q)UIT GAME");

            string user_input = player.UserInput();

            if(user_input == "N")
                {
                player.pos_y += 1;
                this.Grid(player);
                }
            else if(user_input == "S")
                {
                player.pos_y -= 1;
                this.Grid(player);
                }
            else if(user_input == "W")
                {
                player.pos_x -= 1;
                this.Grid(player);
                }
            else if(user_input == "E")
                {
                player.pos_x += 1;
                this.Grid(player);
                }
            else if(user_input == "L")
                {
                WriteLine("LOOK AT YOU!");
                player.Status();
                WriteLine("---------------------------------------------------------");
                this.Options(room,player);
                }
            else if(user_input == "R")
                {
                room.Status();
                /*print(Room.status(room) maybe
                 a function in rooms for locating the player
                 and return the corresponding room?*/
                this.Options(room,player);
                }
            else if(user_input == "M")
                {
                map.Plan();
                this.Options(room,player);
                }
            else if(user_input == "I")
                {
                player.Inventory(room);
                }
            else if(user_input == "Q")
                {
                this.GameOver();
                }
            else
                {
                WriteLine("DUDE, WRONG INPUT!!!");
                // maybe here after choose drop,pick up?
                WriteLine("---------------------------------------------------------");
                this.Options(room,player);
                }
            }



        public void grid(List<Room> rooms,Player player)
            {
            // Find the room that the player is in
            Room currentRoom = null;
            foreach(Room room in rooms)
                {
                if(room.posX == player.posX && room.posY == player.posY)
                    {
                    currentRoom = room;
                    break;
                    }
                }

            if(currentRoom == null)
                {
                // The player is not in any room
                // Handle this error case appropriately
                }
            else
                {
                currentRoom.Status();
                foreach(var npc in currentRoom.npcs)
                    {
                    if(npc.friend == false)
                        {
                        battle(npc,player);
                        if(enemy.hp <= 0)
                            {
                            player.xp += enemy.xp;
                            enemy.queue_free(room);
                            room.enemies.Remove(enemy);
                            }
                        }
                    }
                }
            this.options(currentRoom,player);
            }

        public static void battle(Character attacker,Player defender)
            {
            initiative(attacker,defender);

            void initiative(Character att,Player def)
                {
                // INITIATIVE PHASE
                if(att.RollDice(0,100) + (att.dex / 5) >= def.RollDice(0,100) + (def.dex / 5))
                    {
                    Console.WriteLine($"{att.name} HAS INITIATIVE");
                    // ATTACKER ATTACK PHASE
                    foeAttack(att,def);
                    }
                else
                    {
                    Console.WriteLine($"{def.name} HAS INITIATIVE");
                    // DEFENDER ATTACK PHASE
                    heroAttack(def,att);
                    }
                }

            void foeAttack(Character attacker,Player defender)
                {
                Console.WriteLine($"{attacker.name} IS ATTACKING {defender.name}");
                if(attacker.RollDice(0,100) >= defender.RollDice(0,100))
                    {
                    Console.WriteLine($"{attacker.name} HITS {defender.name}");
                    defender.hp -= (attacker.dmg - defender.ar);
                    Console.WriteLine($"{attacker.name} DOES {attacker.dmg} DAMAGE");
                    Console.WriteLine($"{defender.name} NOW HAS {defender.hp} HP");
                    }
                else
                    {
                    Console.WriteLine($"{attacker.name} misses {defender.name}.");
                    }
                }
            void heroAttack(Player attacker,Character defender)
                {
                Console.WriteLine($"{attacker.name} IS ATTACKING {defender.name}");
                if(attacker.RollDice(0,100) >= defender.RollDice(0,100))
                    {
                    Console.WriteLine($"{attacker.name} HITS {defender.name}");
                    defender.hp -= (attacker.dmg - defender.ar);
                    Console.WriteLine($"{attacker.name} DOES {attacker.dmg} DAMAGE");
                    Console.WriteLine($"{defender.name} NOW HAS {defender.hp} HP");
                    }
                else
                    {
                    Console.WriteLine($"{attacker.name} misses {defender.name}.");
                    }
                }
            }

        ////////////
        /// <summary>
        /// Kind of Library
        /// </summary>
        //Todo: needs to be better hidden

        //Invocation of the rooms we are in.
        public static Room start_room = new Room("START ROOM","THIS IS THE STARTING ROOM",0,0,new List<Character> { Character.friendly_wizard },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room foe_room = new Room("ORC FOE ROOM","THIS IS THE ORC FOE ROOM",0,1,new List<Character> { Character.orc_peon,Character.orc_peewee,Character.orc_boner },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room gem_room = new Room("GEM ROOM","THIS IS THE GEM ROOM",0,-1,new List<Character> { },new List<Item> { Item.gem,Item.gem,Item.gem },new List<Weapon> { },new List<Armor> { });
        public static Room orc_room = new Room("ORC ROOM","THIS IS AN ORC ROOM",0,2,new List<Character> { Character.orc_baba },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room rat_room = new Room("RAT ROOM","LOOK! THE RAT MAN!",1,0,new List<Character> { Character.rat_man },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room stor = new Room("STORE","BUY IT NOW!",1,1,new List<Character> { Character.store_clerk },new List<Item> { Item.gem,Item.gem,Item.poison },new List<Weapon> { Weapon.short_sword,Weapon.stick },new List<Armor> { Armor.leather_armor,Armor.cloth_robe,Armor.towel });
        // shit name STOR because of problems otherwise, it calls store.status() wich leads to the store method...that brakes the game(From Python)
        // the store is a class for itself...

        //these are just blockers, to be reworked laterwith waypoint tips
        public static Room wallm1m1 = new Room("WALL","NO WAY,TURN AROUND",-1,-1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wall1m1 = new Room("WALL","NO WAY,TURN AROUND",1,-1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wallm10 = new Room("WALL","NO WAY,TURN AROUND",-1,0,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wallm11 = new Room("WALL","NO WAY,TURN AROUND",-1,1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wallm12 = new Room("WALL","NO WAY,TURN AROUND",-1,2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wall12 = new Room("WALL","NO WAY,TURN AROUND",1,2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wall03 = new Room("WALL","NO WAY,TURN AROUND",0,3,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        public static Room wall0m2 = new Room("WALL","NO WAY,TURN AROUND",0,-2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });

        public static List<Room> rooms = new List<Room> { start_room,foe_room,gem_room,orc_room,rat_room,stor,wallm1m1,wall1m1,wallm10,wallm11,wallm12,wall12,wall03,wall0m2 };

        ///////////////
        ///End Tags///
        /////////////
        }
    }



//        # RUN BATTLE
//        initiative(attacker,defender)
//#TODO
//    '''def random_encounter(self,player) :
//        rooms = [start_room,orc_room,peon_room,rat_room]
//        enemies = [orc_peon,orc_peon]
//        roll = random.randint(0,100)
//        if roll <= 10:
//            print("TWO ORC PEONS")
//            print(enemies[0].name)
//            print(enemies[1].name)

//            enemies[0].pos_x = player.pos_x and
//             enemies[0].pos_y = player.pos_y
//            enemies[1].pos_x = player.pos_x and
//             enemies[1].pos_y = player.pos_y

//        elif roll >= 11 and roll <= 20 :
//            print("ORC PEON")
//            #WIP
//        elif roll >= 21 and roll <= 95 :
//            print("NO ENCOUNTERS")
//            #WIP
//        elif roll >= 96 :
//            print("TREASURE ROOM")'''
//            #WIP

// TODO: Make wall rooms for not going into the abyss
//maybe give possible directions in the rooms if looked at?
//give hints about a store
//need interaction and talk with npcs
//use of health potions
//maybe even a game break for drinking with an alert or so
//whilst in fight - better than dying, right ?
//exit method ?