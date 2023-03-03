using static System.Console;
namespace ShoppingMall
    {
    class Employees: Person
        {
        public string gender;
        public string firstName;
        public string surName;
        public string street;
        public int zipCode;
        public string city;
        public int pID;
        public int rabbate;
        public Employees(string gender,string firstName,string surName,string street,int zipCode,string city,int pID,int rabbate)
            {
            this.gender = gender;
            this.firstName = firstName;
            this.surName = surName;
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.pID = pID;
            this.rabbate = rabbate;
            }

        public void Adress()
            {
            WriteLine($"Street: {this.street}.\n" +
                $"Zipcode: {this.zipCode}.\n" +
                $"City: {this.city}.");
            }
        }
    }
