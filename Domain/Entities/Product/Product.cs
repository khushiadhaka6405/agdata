using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Product
{
    public class Product 
    {
        public string Name { get; private set; }
        public ProductPrice Price { get; private set; }
        public ProductStock Stock { get; private set; }

        public Product(string name, int pointsRequired, int initialStock)
        {
            Name = name;
            Price = new ProductPrice(pointsRequired);
            Stock = new ProductStock(initialStock);
        }

        public void UpdateStock(int countChange) => Stock.UpdateStock(countChange);
        public void UpdatePrice(int newPoints) => Price.UpdatePrice(newPoints);
    }
}
