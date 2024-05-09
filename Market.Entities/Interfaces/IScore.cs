namespace Market.Entities
{
    public interface IScore
    {
        int TotalScore { get; set; }
    }

    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
//Eklenecek özellikler;
//- kasiyerler prim alsın
//- 8 mart günü yapılan alışverişlerde kadın müşteriler %20 indirim alsın
//- her ayın 11 i (ay dönümü old. için) tüm alışverişlerde %5 indirim olsun
//- bir holding e bağlı 3 ayrı company(şube) olsun
//- her ay primlere göre ayın elemanı seçilsin
//- müşteri doğumgününde bir dilim pasta hediye alsın
