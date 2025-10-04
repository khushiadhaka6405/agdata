using agdata.Domain.Entities.Redemption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface IRedemptionRepository
    {
        void Add(Redemption redemption);
        Redemption GetById(Guid id);
        IEnumerable<Redemption> GetAll();
    }
}
