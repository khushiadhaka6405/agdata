using agdata.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
    }
}
