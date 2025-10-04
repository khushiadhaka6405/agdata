using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.user
{
    public class UserAccount
    {
        public int PointsBalance { get; private set; }

        public UserAccount(int initialPoints = 0)
        {
            PointsBalance = initialPoints;
        }

        public void AddPoints(int points)
        {
            if (points <= 0) throw new ArgumentException("Points must be positive.");
            PointsBalance += points;
        }

        public void RedeemPoints(int points)
        {
            if (points <= 0) throw new ArgumentException("Points must be positive.");
            if (PointsBalance < points) throw new InvalidOperationException("Insufficient balance.");
            PointsBalance -= points;
        }
    }
}
