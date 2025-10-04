using agdata.Domain.Entities.Product;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public class InMemoryProductRepository : IProductRepository
    {
        public void Add(Product p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            InMemoryDatabase.Products.Add(p);
        }

        public Product GetById(Guid productId)
        {
            foreach (var product in InMemoryDatabase.Products)
            {
                if (product != null && product.GetType().GetProperty("Id")?.GetValue(product) is Guid id && id == productId)
                    return product;
            }
            return null; // return null if not found
        }

        public IEnumerable<Product> GetAll()
        {
            return InMemoryDatabase.Products;
        }
    }
}
