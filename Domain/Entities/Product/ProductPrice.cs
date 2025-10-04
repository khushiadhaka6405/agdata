using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Product
{
    public class ProductPrice
    {
        public int RequiredPoints { get; private set; }

        public ProductPrice(int requiredPoints)
        {
            if (requiredPoints <= 0) throw new ArgumentException("Points must be positive.");
            RequiredPoints = requiredPoints;
        }

        public void UpdatePrice(int newPoints)
        {
            if (newPoints <= 0) throw new ArgumentException("Points must be positive.");
            RequiredPoints = newPoints;
        }
    }
}

