using agdata.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Redemption
{
    public class Redemption
    {
        public Guid Id { get; private set; } // unique redemption ID
        public Guid UserId { get; private set; } // ID of the user redeeming product
        public Guid ProductId { get; private set; } // ID of product being redeemed
        public DateTime Date { get; private set; } = DateTime.UtcNow; // redemption date
        public RedemptionStatus Status { get; private set; } = RedemptionStatus.Pending; // redemption status

        // Constructor to create a redemption
        public Redemption(Guid userId, Guid productId)
        {
            Id = Guid.NewGuid(); // generate unique ID automatically
            UserId = userId;
            ProductId = productId;
        }

        // Approve the redemption
        public void Approve() => Status = RedemptionStatus.Approved;

        // Mark redemption as complete
        public void Complete() => Status = RedemptionStatus.Completed;

        // Reject the redemption
        public void Reject() => Status = RedemptionStatus.Rejected;
    }
}
