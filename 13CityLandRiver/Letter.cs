namespace CLR
    {
    /// <summary>
    /// This Class is used to draw a random letter
    /// from a to z.
    /// To call with Letter.drawer()
    /// </summary>
    class Letter
        {
        Random chara = new Random();
        public Letter()
            {
            drawer();
            }

        public string drawer()
            {
            int draw = chara.Next(1,27);
            string[] alphabet = { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
            return alphabet[draw];
            }


        }
    }
