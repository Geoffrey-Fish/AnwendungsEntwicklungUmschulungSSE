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
                Player.Create player = new Player.Create();
                Narrative.Welcome();
                }
            }
        public void Options(Room room,Player player)
            {
            WriteLine("MOVE:\n| (N)ORTH\n| (E)AST\n| (S)OUTH\n| (W)EST\n|");
            WriteLine(" (L)OOK AT ME!\n| SHOW (R)OOM!\n|(M)AP?\n| ");
            WriteLine("  (I)NVENTORY?\n| (Q)UIT GAME");

            string user_input = player.GetUserInput();

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
        }
    }



//    def status(self):
//        print(self.name + " IS INSTANTIATED")
//         #TODO: I need a more fancy Intro, fuck dammnit!


//    def grid(self,player):
//        rooms = [start_room,peon_room,gem_room,orc_room,rat_room,
//         stor,wallm1m1,wall1m1,wallm10,wallm11,wallm12,
//          wall12,wall03,wall0m2]
//        for room in rooms:
//            if room.pos_x == player.pos_x and room.pos_y == player.pos_y:
//                room.status()
//                if len(room.enemies) > 0:
//                    while len(room.enemies) > 0:
//                        for enemy in room.enemies:
//                            self.battle(enemy,player)
//                            if enemy.hp <= 0:
//                                player.xp += enemy.xp
//                                enemy.queue_free(room)
//                                room.enemies.remove(enemy)
//                self.options(room,player)



//    def battle(self,attacker,defender):


//        def initiative(attacker,defender):
//            # INITIATIVE PHASE
//            if attacker.roll_dice(0,100) + (attacker.dex / 5) >=
//             defender.roll_dice(0,100) + (defender.dex / 5):
//                print(attacker.name + " HAS INITIATIVE")
//                # ATTACKER ATTACK PHASE
//                to_hit(attacker,defender)
//            else:
//                print(defender.name + " HAS INITIATIVE")
//                # DEFENDER ATTACK PHASE
//                to_hit(defender,attacker)


//        def to_hit(attacker,defender):
//            print(attacker.name + " IS ATTACKING " + defender.name)
//            if attacker.roll_dice(0,100) >= defender.roll_dice(0,100):
//                print(attacker.name + " HITS " + defender.name)
//                defender.hp -= attacker.dmg
//                print(attacker.name + " DOES " + str(attacker.dmg) + " DAMAGE")
//                print(defender.name + " NOW HAS " + str(defender.hp) + " HP")
//            else:
//                print(attacker.name + " MISSES " + defender.name)

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