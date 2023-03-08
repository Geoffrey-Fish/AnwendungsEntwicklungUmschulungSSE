using static System.Console;

namespace RPGOne
    {

    /// <summary>
    /// Every RPG needs a map!
    /// </summary>
    public class Map
        {
        /// <summary>
        /// Simple printout of the map.
        /// </summary>
        public static void Plan(Room room,Player player)
            {
            WriteLine("" +
                "||||||||||||||||||\n" +
                "||||||none |||||||\n" +
                "|none|orc  |none |\n" +
                "|none|foes |store|\n" +
                "|none|start|rat  |\n" +
                "|none|gem  |none |\n" +
                "||||||none |||||||\n" +
                "||||||||||||||||||");
            Program.Options(room,player);
            //todo: should learn how to make a cli table for proper show of that map
            }
        public static string[][] mapping ={
                new string[] { "||||||", "||||||", "||||||" }, //[0][0],[0][1],[0][2]
                new string[] { "||||||", "none |", "||||||" }, //[1][0],[1][1],[1][2]
                new string[] { "|none|", "orc  |", "none |" }, //[2][0],[2][1],[2][2]
                new string[] { "|none|", "foes |", "store|" }, //[3][0],[3][1],[3][2]
                new string[] { "|none|", "start|", "rats |" }, //[4][0],[4][1],[4][2]
                new string[] { "|none|", "gems |", "none |" }, //[5][0],[5][1],[5][2]
                new string[] { "||||||", "none |", "||||||" }, //[6][0],[6][1],[6][2]
                new string[] { "||||||", "||||||", "||||||" }  //[7][0],[7][1],[7][2]
                };

        //todo: still wip
        /// <summary>
        /// Right now no idea what I wanted with that
        /// </summary>
        public void Path()
            {
            //like a way pointer #TODO
            }


        //todo: still wip
        /// <summary>
        /// Seems like i wanted to remap this with visited rooms marked
        /// OR maybe Player Position???
        /// </summary>
        /// <param name="key"> like, "visited" ?</param>
        /// <param name="value"> the room coordinates?</param>
        public void MapAdd(string key,object value)
            {
            Dictionary<string,object> map = new Dictionary<string,object>();
            map.Add(key,value);
            WriteLine(map);
            }

        }
    }