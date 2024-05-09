using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Entities
{
    public class Company
    {
        public string Name 
        {
            get
            {
                return "TORUN GROSS "+Address;
            }
        }
        public string Address { get; set; } 
        public DateTime OpeningDate { get; set; }
        public List<Chart> Charts { get; set; }
        public double Giro 
        {
            get 
            {
                double giro = 0;
                foreach (Chart ch in Charts)
                {
                    giro += ch.TotalChartPrice;
                }
                return giro;
            }
        }
        public double GiroWithKdv
        {
            get
            {
                double giro = 0;
                foreach (Chart ch in Charts)
                {
                    giro += ch.TotalChartPriceWithKdv;
                }
                return giro;
            }
        }
        public int TotalSaleCount 
        { 
            get
            {
                int total = 0;
                foreach(Chart ch in Charts)
                {
                    total++;
                }

                return total;
            } 
        }
        public string GetCompanyInfo()
        {
            return $"{OpeningDate} tarihinde halka açılan {Name} in {DateTime.Now} zamanına kadarki " +
                   $"kdv siz cirosu : {Giro} tl, kdv li cirosu : {GiroWithKdv}, toplam satış adedi : {TotalSaleCount} adet," +
                   $"satış başına ortalama tutar (kdv li) : {Giro/TotalSaleCount} tl";
        }
        public void GetAllCharts()
        {
            Console.WriteLine($"{Name} isimli şubenin tüm sepet bilgileri : ");
            Console.WriteLine("-------------------------------------");
            foreach (Chart ch in Charts)
            {
                Console.WriteLine(ch.GetChartInfo());
                Console.WriteLine("------------------------------");
            }
            
        }
        public void GetAllChartPrice()
        {
            Console.WriteLine($"{Name} isimli şubenin sepet bazlı tek tek satış bilgileri : ");
            Console.WriteLine("-------------------------------------");
            foreach (Chart ch in Charts)
            {
                Console.WriteLine($"{ch.ShoppingTime} tarihindeki toplam satış tutarı (kdv li) : {ch.TotalChartPriceWithKdv} tl");
                
            }
        }
        public string GetAllChartDetails()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Firmanın tüm sepet detayları : ");
            Console.WriteLine("-------------------------------------");
            foreach (Chart ch in Charts)
            {
                sb.AppendLine(ch.GetAllChartInfo());
                sb.AppendLine($"Toplam kdv siz tutar : {ch.TotalChartPrice} tl , Toplam kdv li tutar : {ch.TotalChartPriceWithKdv} tl");
                sb.AppendLine("-------------------------------------");
            }
            
            return sb.ToString();

        }
    }
}
