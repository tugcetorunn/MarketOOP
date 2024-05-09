using System;
using System.Collections.Generic;

namespace Market.Entities
{
    public class Chart
    {
        private int chartNumberCounter = 1;
        public Chart()
        {
            ChartNumber = chartNumberCounter++;
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int ChartNumber { get; private set; }
        public List<Product> Products { get; set; }
        public DateTime ShoppingTime { get; set; }
        public Customer Customer { get; set; }
        public Cashier Cashier { get; set; }

        //public int ChartNumber
        //{
        //    get
        //    {
        //        return GetChartNumber();
        //    }
        //}
        //public int GetChartNumber()
        //{
        //    Chart chart = new Chart();
        //    int chNumber = chart.ChartNumber;
        //    chNumber = chartNumberCounter;
        //    chartNumberCounter++;
        //    return chNumber;
        //}   // bu şekilde burada proje sonsuz döngüye giriyor. Stack Overflow hatası genellikle bir sınıfın içinde kendini çağırması durumunda oluşur. Bu durum, genellikle bir property veya metot içinde, o sınıfın kendi örneğini yeniden oluşturmak ve çağırmakla ilgilidir. İncelediğimizde Chart sınıfında ChartNumber özelliği içinde bu hataya neden olabilecek bir yapı gözüküyor.GetChartNumber() metodu içinde sürekli olarak Chart sınıfının örneği oluşturuluyor.Bu, her Chart örneği oluşturulduğunda sonsuz döngüye neden olur.

        //public double TotalChartPrice()
        //{
        //    double price = 0;
        //    foreach (Product pr in Products)
        //    {
        //        price += pr.Price*pr.Amount;
        //    }

        //    return price;
        //} -> property olarak nasıl tanımlayabiliriz ?

        public double TotalChartPrice
        {
            get
            {
                double price = 0;
                foreach (Product pr in Products)
                {
                    price += pr.Price * pr.Amount;
                }

                return price;
            } // set ini de kapatmış oluyoruz dışarıdan müdahale edilemiyo metod halinde yaptığımızda dışarıdan değer alınabilir durumdaydı.
        }
        public double TotalChartPriceWithKdv
        {
            get
            {
                double priceWithKdv = 0;
                foreach (Product pr in Products)
                {
                    priceWithKdv += pr.PriceWithKdv * pr.Amount;
                }

                return priceWithKdv;
            }
        }

        public int TotalProductAmount
        {
            get 
            { 
                int amount = 0;
                foreach (Product pr in Products)
                {
                    amount += pr.Amount;
                }

                return amount;
            }
        }
        
        public string GetChartInfo()
        {
            return $"{Customer.GetInfo()} {ShoppingTime} tarihinde {Cashier.GetInfo()} aracılığıyla " +
                   $"kdv siz toplam {TotalChartPrice} TL, kdv li toplam {TotalChartPriceWithKdv} tutarında " +
                   $"toplam {TotalProductAmount} adet ürün almıştır. ";//(evulate)
        }

        public string GetAllChartInfo()
        {
            string info = Customer.GetInfo() + $" {ShoppingTime} tarihinde aldığı ürün bilgileri : \n";
            foreach (Product pr in Products)
            {
                info += $"{pr.Name} adlı ürün adedi {pr.Amount}, kdv siz fiyatı {pr.Price}, kdv li fiyatı {pr.PriceWithKdv} tl dir.\n";
            }
            return info;
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
