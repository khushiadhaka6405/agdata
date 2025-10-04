using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Product
{
    public class ProductStock
    {
        public int Quantity { get; private set; }

        public ProductStock(int initialStock)
        {
            if (initialStock < 0) throw new ArgumentException("Stock cannot be negative.");
            Quantity = initialStock;
        }

        public void UpdateStock(int change)
        {
            if (Quantity + change < 0) throw new InvalidOperationException("Insufficient stock.");
            Quantity += change;
        }
    }
}
