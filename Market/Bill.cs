using System;
using Market.Entities;
namespace Market
{
    public class Bill
    {
        private Calculates calculates;
        public Bill()
        {
            calculates = new Calculates();
        }
        public Bill(Company company, Chart chart, Customer customer)
        {
            this.Company = company;
            calculates = new Calculates(company, chart);
            Customer = customer;
            Chart = chart;
        }
        public int BillNumber 
        { 
            get 
            {
                return calculates.CalculateBillNumber();
            }// calculates nesnesini burada oluşturduğumuzda BillNumber özelliği, Calculates sınıfını çağırır, Calculates sınıfı da BillNumber özelliğini çağırır ve bu işlem sonsuza kadar devam eder. bu da stack over flow hatasının dönmesine neden olur. Bu döngüyü engellemek için BillNumber özelliğinin her çağrıldığında sadece bir değer döndürmesi gerekmektedir. Yani, Calculates sınıfının her defasında yeniden oluşturulması yerine, bir kere oluşturulması ve her çağrıldığında aynı Calculates nesnesinin kullanılması sağlanmalıdır. Önerilen çözüm, Bill sınıfının constructor'ında Calculates nesnesini oluşturmak ve bu nesneyi Bill sınıfının bir özelliği olarak saklamaktır. Böylece, her BillNumber özelliği çağrıldığında aynı Calculates nesnesi kullanılır.

        }
        public Customer Customer { get; set; }
        public Chart Chart { get; set; }
        public Company Company { get; set; }
        public void GetBill()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{BillNumber} numaralı fatura bilgileri : ");
            Console.WriteLine($"Alıcı : {Company.Name}");
            Console.WriteLine($"Borçlu : {Customer.Name}");
            Console.WriteLine($"Kdv siz borç tutarı : {Chart.TotalChartPrice}");
            Console.WriteLine($"Kdv li borç tutarı : {Chart.TotalChartPriceWithKdv}");
            Console.WriteLine("------------------------------------------");
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
