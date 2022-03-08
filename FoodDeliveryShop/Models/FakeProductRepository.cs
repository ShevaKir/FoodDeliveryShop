using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Pizza", Price = 10 },
            new Product { Name = "Burger", Price = 15 },
            new Product { Name = "Sandwich", Price = 5 }
        };
    }
}
