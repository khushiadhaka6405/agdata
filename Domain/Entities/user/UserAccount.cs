using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.user
{
    public class UserAccount
    {
        public Guid UserId { get; private set; }
        public int RewardBalance { get; private set; }

        public UserAccount(Guid userId)
        {
            UserId = userId;
            RewardBalance = 0; // initial points
        }

        public void AddPoints(int points)
        {
            RewardBalance += points;
        }

        public void RedeemPoints(int points)
        {
            if (points > RewardBalance) throw new Exception("Insufficient points");
            RewardBalance -= points;
        }
    }
}
