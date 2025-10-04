using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Transaction
{
    public class Transaction 
    {
        public Guid UserId { get; private set; }
        public TransactionType Type { get; private set; }
        public int Points { get; private set; }

        public Transaction(Guid userId, TransactionType type, int points)
        {
            if (points <= 0) throw new ArgumentException("Points must be positive.");
            UserId = userId;
            Type = type;
            Points = points;
        }
    }
}
