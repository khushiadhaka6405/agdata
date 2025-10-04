using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Redemption
{
    public class Redemption 
    {
        public Guid UserId { get; private set; }
        public Guid ProductId { get; private set; }
        public DateTime Date { get; private set; } = DateTime.UtcNow;
        public RedemptionStatus Status { get; private set; } = RedemptionStatus.Pending;

        public Redemption(Guid userId, Guid productId)
        {
            UserId = userId;
            ProductId = productId;
        }

        public void Approve() => Status = RedemptionStatus.Approved;
        public void Complete() => Status = RedemptionStatus.Completed;
        public void Reject() => Status = RedemptionStatus.Rejected;
    }
}
