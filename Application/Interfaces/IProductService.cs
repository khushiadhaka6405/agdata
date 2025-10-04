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
        Product Create(string name, int requiredPoints, int initialStock);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
        void UpdatePrice(Guid id, int newPoints);
        void ChangeStock(Guid id, int delta);
    }
}
