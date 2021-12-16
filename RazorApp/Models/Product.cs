using System;

namespace RazorApp.Models
{
    public class Product
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}