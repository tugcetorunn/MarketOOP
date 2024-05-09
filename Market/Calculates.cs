using System;
using System.Collections.Generic;
using Market.Entities;


namespace Market
{
    public class Calculates
    {
        public Calculates(Company company, Chart chart)
        {
            Company = company;
            Chart = chart;
        }
        public Calculates()
        {
            
        }
        public Customer Customer { get; set; }
        public Chart Chart { get; set; }
        public List<Chart> Charts { get; set; }
        public Company Company { get; set; }
        public int CalculateBillNumber()
        {
            string BillNumberPart1 = Company.Name.Substring(0, 1);
            string BillNumberPart2 = Company.Name.Substring(1, 1);
            string BillNumberPart3 = Chart.ShoppingTime.Year.ToString();
            string BillNumberFullString = string.Join("", BillNumberPart3, "0000000000");
            int BillNumber = Convert.ToInt32(BillNumberFullString);

            for (int i = 0; i < Chart.ChartNumber; i++)
            {
                BillNumber++;
            }

            return BillNumber;
        }        
    }

    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
//Eklenecek özellikler;
//- kasiyerler prim alsın
//- 8 mart günü yapılan alışverişlerde kadın müşteriler %20 indirim alsın
//- her ayın 11 i (ay dönümü old. için) tüm alışverişlerde %5 indirim olsun
//- bir holding e bağlı 3 ayrı company(şube) olsun
//- her ay primlere göre ayın elemanı seçilsin
//- müşteri doğumgününde bir dilim pasta hediye alsın
//- market kartı olan müşteriler elektronik ürünlerde 1000 tl alışveriş üzeri hesaplarına 50 tl kupon yatsın (kart interface ??)
