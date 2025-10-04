using agdata.Domain.Entities.Redemption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Application.Interfaces
{
   
     public interface IRedemptionService
    {
        Redemption Redeem(Guid userId, Guid productId);
        void Approve(Guid redemptionId);
        void Complete(Guid redemptionId);
        void Reject(Guid redemptionId);
        IEnumerable<Redemption> GetAll();
    }
}
