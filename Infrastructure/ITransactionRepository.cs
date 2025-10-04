using agdata.Domain.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        IEnumerable<Transaction> GetByUserId(Guid userId);
    }
}
