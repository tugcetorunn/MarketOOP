using System;

namespace Market.Entities
{
    public class Cashier : Person, IScore
    {
        public int CashierNumber { get; set; } = new Random().Next(1000,1100);
        public override string GetInfo()
        {
            return base.GetInfo() + $" {CashierNumber} numaralı kasiyer";
        }
        public int TotalScore { get; set; } 
    }

    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
