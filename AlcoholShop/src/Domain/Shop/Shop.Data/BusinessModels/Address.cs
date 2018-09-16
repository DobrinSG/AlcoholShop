namespace Shop.Data.BusinessModels
{
    public class Address
    {
        public Address(string city, string street, string streetNumber)
        {
            City = city;
            Street = street;
            StreetNumber = streetNumber;
        }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }
    }
}
