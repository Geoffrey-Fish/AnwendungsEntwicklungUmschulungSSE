using static System.Console;
namespace ShoppingMall
    {
    class Customers: Person
        {
        public string gender;
        public string firstName;
        public string surName;
        public string street;
        public int zipCode;
        public string city;
        public int cID;
        public Customers(string gender,string firstName,string surName,string street,int zipCode,string city,int cID)
            {
            this.gender = gender;
            this.firstName = firstName;
            this.surName = surName;
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.cID = cID;
            }
        public void Adress()
            {
            WriteLine($"Street: {this.street}.\n" +
                $"Zipcode: {this.zipCode}.\n" +
                $"City: {this.city}.");
            }
        }
    }