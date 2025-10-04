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
        public void Add(Transaction tx)
        {
            if (tx == null) throw new ArgumentNullException(nameof(tx));
            InMemoryDatabase.Transactions.Add(tx);
        }

        public IEnumerable<Transaction> GetByUserId(Guid userId)
        {
            var result = new List<Transaction>();

            foreach (var tx in InMemoryDatabase.Transactions)
            {
                if (tx != null && tx.GetType().GetProperty("UserId")?.GetValue(tx) is Guid id && id == userId)
                    result.Add(tx);
            }

            return result;
        }
    }
}
