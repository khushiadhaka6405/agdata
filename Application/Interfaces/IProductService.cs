using agdata.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Application.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(string name, int pointsRequired);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
    }
}
