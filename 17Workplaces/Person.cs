namespace ShoppingMall
    {
    abstract class Person // abstract classes cant invoke objects
        {
        string? gender;
        string? firstName;
        string? surName;
        string? street;
        int zipCode;
        string? city;

        //Eigenschaften sind nötig um von anderen klassen auf diese abstract zugreifen zu können

        public string Gender { get => gender; set => gender = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Street { get => street; set => street = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }

        public string City
            {
            get => city; set => city = value;
            }

        }
    }
