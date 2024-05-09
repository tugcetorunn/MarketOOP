using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Market.Entities;


namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier Ahmet = new Cashier() { Name = "Ahmet" };

            Customer cTugce = new Customer("Tuğçe Torun", Gender.Kadin);
            Customer cZeynep = new Customer("Zeynep Toker", Gender.Kadin);
            Customer cEymen = new Customer("Eymen Toker", Gender.Erkek);

            Product charger = new Product() { Name = "Şarj aleti", _Category = Category.Electronic, Amount = 2, Price = 300 };
            Product cheese = new Product() { Name = "Peynir", _Category = Category.Food, Amount = 2 , Price = 150 };
            Chart chTugce = new Chart() { Customer = cTugce, Products = new List<Product>() { charger, cheese }, ShoppingTime = DateTime.Now.AddMonths(-3), Cashier = Ahmet };
            

            Product cips = new Product() { Name = "Cips", _Category = Category.Snack, Amount = 3, Price = 30 };
            Product bread = new Product() { Name = "Ekmek", _Category = Category.Food, Amount = 4, Price = 10 };
            Chart chZeynep = new Chart() { Customer = cZeynep, Products = new List<Product>() { cips, bread }, ShoppingTime = DateTime.Now.AddMonths(-2), Cashier = Ahmet };

            Product phone = new Product() { Name = "Samsung S24 Ultra", _Category = Category.Electronic, Amount = 1, Price = 70000 };
            Product earphone = new Product() { Name = "Samsung kulaklık", _Category = Category.Electronic, Amount = 1, Price = 3000 };
            Chart chEymen = new Chart() { Customer = cEymen, Products = new List<Product>() { phone, earphone }, ShoppingTime = DateTime.Now.AddMonths(-1), Cashier = Ahmet };

            Company nilufer = new Company() { Charts = new List<Chart>() { chTugce, chZeynep, chEymen } };

            Bill bTugce = new Bill() { Company = nilufer, Chart = chTugce, Customer = cTugce };

            List<Chart> charts = new List<Chart> {chEymen , chTugce, chZeynep};

            Calculates calculates = new Calculates() { Chart = chTugce, Company = nilufer, Charts = charts, Customer = cTugce };

            //nilufer.GetAllCharts();
            //Console.WriteLine("..........................");
            //nilufer.GetAllChartPrice();
            //Console.WriteLine("..........................");
            //Console.WriteLine(nilufer.GetCompanyInfo());
            //Console.WriteLine(chTugce.GetAllChartInfo());

            //Console.WriteLine(bTugce.BillNumber);
            Console.WriteLine(nilufer.GetAllChartDetails());
        }
    }

    
}







//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
//Eklenecek özellikler;
//- kasiyerler prim alsın
//- 8 mart günü yapılan alışverişlerde kadın müşteriler %20 indirim alsın
//- her ayın 11 i (ay dönümü old. için) tüm alışverişlerde %5 indirim olsun
//- bir holding e bağlı 3 ayrı company(şube) olsun
//- her ay primlere göre ayın elemanı seçilsin
//- müşteri doğumgününde bir dilim pasta hediye alsın
//- market kartı olan müşteriler elektronik ürünlerde 1000 tl alışveriş üzeri hesaplarına 50 tl kupon yatsın (kart interface ??)
