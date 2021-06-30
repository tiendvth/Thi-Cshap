using System;

namespace DANGVANTIEN_T2009015
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){}

        public Product(string productId, string productName, double price)
        {
            Id = productId;
            Name = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id} \t {Name} \t ${Price}";
        }
    }
}