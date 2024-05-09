using System;

namespace Market.Entities
{
    public class Person
    {
        //static Random rnd;
        //public Person()
        //{
        //    rnd = new Random(); // görevi her bir person nesnesi türettiğimizde random sınıfı değişkeni üretiyor.
        //}
        public string Id { get; } = Guid.NewGuid().ToString();
        public int Tckn { get; } = new Random().Next(10000000, 900000000); // daha uzun yapılamıyor, next metodu içinde int değer istiyor. random metodunu 92. satırda newleyip burada next metodunu çağırınca program static obje istedi.
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public virtual string GetInfo()
        {
            return $"{Id} kimlikli {Tckn} tc nolu {Name}({Gender}) isimli";
        }

    }

    
}//Person, Customer, Chart, Product, Category, Cashier, Company, Holding
