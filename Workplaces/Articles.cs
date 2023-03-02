using static System.Console;
namespace ShoppingMall
    {
    public class Articles
        {
        int id;
        string desc;
        decimal price;
        public Articles(int id,string desc,decimal price)
            {
            this.id = id;
            this.desc = desc;
            this.price = price;
            WriteLine($"Article Number{this.id},\"{this.desc}\", instantiated.");
            }
        }
    }
