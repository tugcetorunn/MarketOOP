using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities
{
    public class Holding
    {
        public string Name { get; } = "TORUN HOLDING";
        public string Address { get; } = "Bursa Nilüfer";
        public DateTime OpeningTime { get; } = new DateTime(2023, 1, 7);
        public List<Company> Companies { get; set; }

        public string GetAllCompanies()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} isimli kuruluşumuzun {Companies.Count} adet şubesinin ciro bilgileri : ");
            foreach (Company cm in Companies)
            {
                sb.AppendLine($"{cm.Address} şubemizin açılış tarihi olan {cm.OpeningDate} gününden beri " +
                              $"toplam (kdv li) cirosu : {cm.GiroWithKdv} tl dir. ");
            }

            return sb.ToString();
        }
        public void GetHoldingInfo() 
        {
            Console.WriteLine($"Kuruluşumuzun adı : {Name}");
            Console.WriteLine($"Kuruluşumuzun adresi : {Address}");
            Console.WriteLine($"Kuruluş tarihimiz : {OpeningTime}");
            Console.WriteLine($"Şube sayımız : {Companies.Count}");



        }
    }
}
