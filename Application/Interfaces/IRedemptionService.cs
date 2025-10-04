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
        Redemption RedeemProduct(Guid userId, Guid productId); // create redemption
        IEnumerable<Redemption> GetAllRedemptions(); // get all
        Redemption GetRedemptionById(Guid id); // get by id
        void ApproveRedemption(Guid id); // approve
        void CompleteRedemption(Guid id); // complete
        void RejectRedemption(Guid id); // reject
    }
}
