using static System.Console;

namespace RPGOne
    {
    public class Room
        {
        //Declaration of parameters for each room, is for besser acessibility
        public string roomName { get; set; }
        public string description { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public List<Character> npcs { get; set; }
        public List<Item> items { get; set; }
        public List<Weapon> weapons { get; set; }
        public List<Armor> armors { get; set; }

        public Room(string name,string desc,int posX,int posY,List<Character> npcs,List<Item> items,List<Weapon> weapons,List<Armor> armors)
            {
            this.roomName = name;
            this.description = desc;
            this.posX = posX;
            this.posY = posY;
            this.npcs = npcs;
            this.items = items;
            this.weapons = weapons;
            this.armors = armors;
            }


        Room start_room = new Room("START ROOM","THIS IS THE STARTING ROOM",0,0,new List<Character> { Character.friendly_wizard },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room foe_room = new Room("ORC FOE ROOM","THIS IS THE ORC FOE ROOM",0,1,new List<Character> { Character.orc_peon,Character.orc_peewee,Character.orc_boner },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room gem_room = new Room("GEM ROOM","THIS IS THE GEM ROOM",0,-1,new List<Character> { },new List<Item> { Item.gem,Item.gem,Item.gem },new List<Weapon> { },new List<Armor> { });
        Room orc_room = new Room("ORC ROOM","THIS IS AN ORC ROOM",0,2,new List<Character> { Character.orc_baba },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room rat_room = new Room("RAT ROOM","LOOK! THE RAT MAN!",1,0,new List<Character> { Character.rat_man },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room stor = new Room("STORE","BUY IT NOW!",1,1,new List<Character> { Character.store_clerk },new List<Item> { Item.gem,Item.gem,Item.poison },new List<Weapon> { Weapon.short_sword,Weapon.stick },new List<Armor> { Armor.leather_armor,Armor.cloth_robe,Armor.towel });
        // shit name STOR because of problems otherwise, it calls store.status() wich leads to the store method...that brakes the game(From Python)
        // the store is a class for itself...

        //these are just blockers, to be reworked laterwith waypoint tips
        Room wallm1m1 = new Room("WALL","NO WAY,TURN AROUND",-1,-1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wall1m1 = new Room("WALL","NO WAY,TURN AROUND",1,-1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wallm10 = new Room("WALL","NO WAY,TURN AROUND",-1,0,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wallm11 = new Room("WALL","NO WAY,TURN AROUND",-1,1,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wallm12 = new Room("WALL","NO WAY,TURN AROUND",-1,2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wall12 = new Room("WALL","NO WAY,TURN AROUND",1,2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wall03 = new Room("WALL","NO WAY,TURN AROUND",0,3,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });
        Room wall0m2 = new Room("WALL","NO WAY,TURN AROUND",0,-2,new List<Character> { },new List<Item> { },new List<Weapon> { },new List<Armor> { });


        public void Status()
            {
            WriteLine(roomName);
            WriteLine(description);
            WriteLine("ROOM: X: " + posX.ToString());
            WriteLine("ROOM: Y: " + posY.ToString());
            WriteLine("YOU SEE: ");
            foreach(var npc in npcs)
                {
                WriteLine(npc.name);
                }
            foreach(var item in items)
                {
                WriteLine(item.name);
                }
            foreach(var weapon in weapons)
                {
                WriteLine(weapon.name);
                }
            foreach(var armor in armors)
                {
                WriteLine(armor.name);
                }
            foreach(var npc in npcs)
                {
                WriteLine("\n\nTHE " + npc.name + " SAYS: " + npc.dialog + "\n\n");
                }
            }

        public Room Locate(Player player)
            {
            var rooms = new List<Room> { start_room,peon_room,gem_room,orc_room,rat_room,stor,wallm1m1,wall1m1,wallm10,wallm11,wallm12,wall12,wall03,wall0m2 };
            foreach(var room in rooms)
                {
                if(room.pos_x == player.pos_x && room.pos_y == player.pos_y)
                    {
                    return room;
                    }
                }
            return null;
            }

        }
    }
