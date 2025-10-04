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
        void Add(Transaction tx);
        IEnumerable<Transaction> GetAll();
        Transaction GetById(Guid id);
        IEnumerable<Transaction> GetByUserId(Guid userId);
    }
}
