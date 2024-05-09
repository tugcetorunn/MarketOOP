using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Entities;

namespace Market.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier Mehmet = new Cashier() { Name = "Mehmet" };

            Customer cTugce = new Customer("Tuğçe Torun", Gender.Kadin);
            Customer cZeynep = new Customer("Zeynep Toker", Gender.Kadin);
            Customer cEymen = new Customer("Eymen Toker", Gender.Erkek);

            Product charger = new Product() { Name = "Şarj aleti", _Category = Category.Electronic, Amount = 2, Price = 300 };
            Product cheese = new Product() { Name = "Peynir", _Category = Category.Food, Amount = 2, Price = 150 };
            Chart chTugce = new Chart() { Customer = cTugce, Products = new List<Product>() { charger, cheese }, ShoppingTime = DateTime.Now.AddMonths(-3), Cashier = Mehmet };


            Product cips = new Product() { Name = "Cips", _Category = Category.Snack, Amount = 3, Price = 30 };
            Product bread = new Product() { Name = "Ekmek", _Category = Category.Food, Amount = 4, Price = 10 };
            Chart chZeynep = new Chart() { Customer = cZeynep, Products = new List<Product>() { cips, bread }, ShoppingTime = DateTime.Now.AddMonths(-2), Cashier = Mehmet };

            Product phone = new Product() { Name = "Samsung S24 Ultra", _Category = Category.Electronic, Amount = 1, Price = 70000 };
            Product earphone = new Product() { Name = "Samsung kulaklık", _Category = Category.Electronic, Amount = 1, Price = 3000 };
            Chart chEymen = new Chart() { Customer = cEymen, Products = new List<Product>() { phone, earphone }, ShoppingTime = DateTime.Now.AddMonths(-1), Cashier = Mehmet };

            //////////////////////////////////////////////////////////////

            Cashier Busra = new Cashier() { Name = "Büşra" };

            Customer cMelis = new Customer("Melis Tor", Gender.Kadin);
            Customer cTugba = new Customer("Tuğba Tok", Gender.Kadin);
            Customer cAli = new Customer("Ali Toki", Gender.Erkek);
            Customer cVeli = new Customer("Veli Oki", Gender.Erkek);
            Customer cHale = new Customer("Hale Yoki", Gender.Kadin);

            Product wipe = new Product() { Name = "mendil", _Category = Category.Hygien, Amount = 5, Price = 10 };
            Product yoghurt = new Product() { Name = "yoğurt", _Category = Category.Food, Amount = 2, Price = 70 };
            Product candle = new Product() { Name = "mum", _Category = Category.Accessories, Amount = 3, Price = 50 };
            Product water = new Product() { Name = "su", _Category = Category.Drinks, Amount = 4, Price = 10 };
            Product lemonade = new Product() { Name = "limonata", _Category = Category.Drinks, Amount = 2, Price = 40 };
            Product monitor = new Product() { Name = "Samsung monitör", _Category = Category.Electronic, Amount = 1, Price = 10000 };
            Product chocolate = new Product() { Name = "ülker kare çikolata", _Category = Category.Snack, Amount = 3, Price = 30 };
            Product airfrier = new Product() { Name = "philips airfrier", _Category = Category.Electronic, Amount = 1, Price = 15000 };


            Chart chTugba = new Chart() { Customer = cTugba, Products = new List<Product>() { candle, water, wipe }, ShoppingTime = DateTime.Now.AddMonths(-2), Cashier = Mehmet };
            Chart chMelis = new Chart() { Customer = cMelis, Products = new List<Product>() { wipe, yoghurt, candle }, ShoppingTime = DateTime.Now.AddMonths(-3), Cashier = Mehmet };
            Chart chAli = new Chart() { Customer = cAli, Products = new List<Product>() { lemonade, monitor, water, wipe }, ShoppingTime = DateTime.Now.AddMonths(-1), Cashier = Mehmet };
            Chart chVeli = new Chart() { Customer = cVeli, Products = new List<Product>() { airfrier, monitor, chocolate, wipe }, ShoppingTime = DateTime.Now.AddMonths(-1), Cashier = Mehmet };
            Chart chHale = new Chart() { Customer = cHale, Products = new List<Product>() { candle, chocolate, yoghurt, wipe }, ShoppingTime = DateTime.Now.AddMonths(-1), Cashier = Mehmet };


            //Company yildirim = new Company() { Address = "Yıldırım", OpeningDate = new DateTime(2023, 3, 11), Charts = { chTugba, chMelis, chAli } };
            //Company nilufer = new Company() { Address = "Nilüfer", OpeningDate = new DateTime(2023, 4, 11), Charts = { chVeli, chHale } };
        
            //Holding holding = new Holding() { Companies = new List<Company>() { yildirim, nilufer } };
            
            //holding.GetHoldingInfo();
            //Console.WriteLine(holding.GetAllCompanies());

            Console.Clear();

            Bread bread1 = new Bread() { Price = 15 , _Category = Category.Food}; // Bread Product tan miras alıyor. dolaylı olarak IKdv den de miras almış oluyor base class ından kdv hesaplaması yapılıyor.
            Console.WriteLine(bread1.PriceWithKdv);
            // asıl nokta IKdv yi interface yapmamızın önemiydi. bunun için Category lere miras verse daha doğru gözlem olur.
        }
    }
}
