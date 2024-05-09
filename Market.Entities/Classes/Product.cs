using System;

namespace Market.Entities
{
    public class Product : IKdv
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceWithKdv 
        { 
            get
            {
                return CalculateKdv(); 
            }
        }
        public double CalculateKdv()
        {
            double priceWithKdv = 0;
            if (_Category == Category.Electronic)
            {
                priceWithKdv = Price + (Price * 0.2);
            }
            else if (_Category == Category.Food)
            {
                priceWithKdv = Price + (Price * 0.01);
            }
            else if (_Category == Category.Snack)
            {
                priceWithKdv = Price + (Price * 0.1);
            }
            else if (_Category == Category.Drinks)
            {
                priceWithKdv = Price + (Price * 0.1);
            }
            else if (_Category == Category.Textile)
            {
                priceWithKdv = Price + (Price * 0.2);
            }
            return priceWithKdv;

        }
        public int Amount { get; set; }
        public Category _Category { get; set; }
    }
    
    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
