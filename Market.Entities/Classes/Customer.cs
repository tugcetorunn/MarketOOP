namespace Market.Entities
{
    public class Customer : Person
    {
        public Customer()
        {

        }
        public Customer(string _name, Gender gender)
        {
            Name = _name;
            Gender = gender;
        }
        public Chart chart {  get; set; }
        public override string GetInfo()
        {
            return base.GetInfo() + " müşteri";
        }
    }

    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
