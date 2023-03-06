namespace RPGOne
    {

    class Item
        {
        public string Name;
        public int DmgValue;
        public int ArValue;
        public int GpValue;
        public double Weight;

        public Item(string name,int dmgValue,int arValue,int gpValue,double weight)
            {
            Name = name;
            DmgValue = dmgValue;
            ArValue = arValue;
            GpValue = gpValue;
            Weight = weight;
            }

        public void Status()
            {
            Console.WriteLine(Name);
            Console.WriteLine("DMG VALUE: " + DmgValue.ToString());
            Console.WriteLine("AR VALUE: " + ArValue.ToString());
            Console.WriteLine("GP VALUE: " + GpValue.ToString());
            Console.WriteLine("WEIGHT: " + Weight.ToString());
            }
        }

    class Program
        {
        static void Main(string[] args)
            {
            Random random = new Random();

            // WEAPONS
            Item short_sword = new Item("SHORT SWORD",random.Next(1,7),0,50,3);
            Item wizards_staff = new Item("WIZARDS STAFF",random.Next(1,41),0,400,4);
            Item stick = new Item("STICK",1,0,1,0.1);

            // ARMORS
            Item leather_armor = new Item("LEATHER ARMOR",0,2,80,12);
            Item cloth_robe = new Item("CLOTH ROBE",0,1,5,2);
            Item towel = new Item("TOWEL",0,1,1,0.1);

            // ITEMS
            Item gem = new Item("GEM",0,0,100,0.1);
            Item poison = new Item("POISON",5,0,40,1);
            Item minor_health = new Item("MINOR_HEALTH",0,0,150,1);

            // Example usage
            short_sword.Status();
            wizards_staff.Status();
            stick.Status();
            leather_armor.Status();
            cloth_robe.Status();
            towel.Status();
            gem.Status();
            poison.Status();
            minor_health.Status();
            }
        }
//class Item:
//    def __init__(self, name, dmg_value, ar_value, gp_value, weight):
//        self.name = name
//        self.dmg_value = dmg_value
//        self.ar_value = ar_value
//        self.gp_value = gp_value
//        self.weight = weight

//    def status(self):
//        print(self.name)
//        print("DMG VALUE: " + str(self.dmg_value))
//        print("AR VALUE: " + str(self.ar_value))
//        print("GP VALUE: " + str(self.gp_value))
//        print("WEIGHT: " + str(self.weight))


//# INSTANCE ITEM name, dmg, ar, gp, weight
//# WEAPONS
//short_sword = Item("SHORT SWORD",random.randint(1, 6), 0, 50, 3)
//wizards_staff = Item("WIZARDS STAFF",random.randint(1, 40), 0, 400, 4)
//stick = Item("STICK", 1, 0, 1, 0.1)

//# ARMORS
//leather_armor = Item("LEATHER ARMOR", 0, 2, 80, 12)
//cloth_robe = Item("CLOTH ROBE", 0, 1, 5, 2)
//towel = Item("TOWEL", 0, 1, 1, 0.1)

//# ITEMS
//gem = Item("GEM", 0, 0, 100, .1)
//poison = Item("POISON", 5, 0, 40, 1)
//minor_health = Item("MINOR_HEALTH", 0, 0, 150, 1)

