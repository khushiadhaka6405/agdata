using agdata.Domain.Entities.Redemption;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace agdata.Infrastructure
{
    public class InMemoryRedemptionRepository : IRedemptionRepository
    {
        public void Add(Redemption r)
        {
            if (r == null) throw new ArgumentNullException(nameof(r));
            InMemoryDatabase.Redemptions.Add(r);
        }

        public Redemption GetById(Guid redemptionId)
        {
            foreach (var r in InMemoryDatabase.Redemptions)
            {
                if (r != null && r.GetType().GetProperty("Id")?.GetValue(r) is Guid id && id == redemptionId)
                    return r;
            }
            return null;
        }

        public IEnumerable<Redemption> GetAll()
        {
            return InMemoryDatabase.Redemptions;
        }
    }
}
