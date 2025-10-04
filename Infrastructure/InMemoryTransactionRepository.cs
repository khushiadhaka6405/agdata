using agdata.Domain.Entities.Transaction;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public class InMemoryTransactionRepository : ITransactionRepository
    {
        // Add a transaction to in-memory database
        public void Add(Transaction tx)
        {
            if (tx == null) throw new ArgumentNullException(nameof(tx));
            InMemoryDatabase.Transactions.Add(tx);
        }

        // Get all transactions
        public IEnumerable<Transaction> GetAll()
        {
            return InMemoryDatabase.Transactions;
        }

        // Get transaction by ID
        public Transaction GetById(Guid id)
        {
            return InMemoryDatabase.Transactions.FirstOrDefault(t => t.Id == id);
        }

        // Get transactions by User ID
        public IEnumerable<Transaction> GetByUserId(Guid userId)
        {
            return InMemoryDatabase.Transactions
                .Where(t => t.UserId == userId)
                .ToList();
        }
    }
}
