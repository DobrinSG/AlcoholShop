namespace Shop.Data.BusinessModels
{
    public class Seller : Person
    {
        public Seller(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public int Sallary { get; set; }
    }
}
