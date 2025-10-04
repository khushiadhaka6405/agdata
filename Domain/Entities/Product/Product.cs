using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Product
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int PointsRequired { get; private set; }

        // Constructor for Product
        public Product(string name, int pointsRequired)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");

            if (pointsRequired <= 0)
                throw new ArgumentException("PointsRequired must be positive");

            Id = Guid.NewGuid(); // assign new ID
            Name = name;
            PointsRequired = pointsRequired;
        }
    }
}
