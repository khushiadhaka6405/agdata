using agdata.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.Transaction
{
    public class Transaction
    {
        public Guid Id { get; private set; } // unique transaction ID
        public Guid UserId { get; private set; } // ID of the user
        public TransactionType Type { get; private set; } // type of transaction
        public int Points { get; private set; } // points involved in transaction
        public DateTime Date { get; private set; } // date of transaction

        // Constructor to create a new transaction
        public Transaction(Guid userId, TransactionType type, int points)
        {
            if (points <= 0)
                throw new ArgumentException("Points must be positive.");

            Id = Guid.NewGuid(); // generate unique ID
            UserId = userId;
            Type = type;
            Points = points;
            Date = DateTime.UtcNow; // set current date
        }
    }
}
