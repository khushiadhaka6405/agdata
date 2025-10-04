using agdata.Domain.Entities.Transaction;
using agdata.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Application.Interfaces
{
    public interface ITransactionService
    {
        Transaction Record(Guid userId, TransactionType type, int points);
        IEnumerable<Transaction> ForUser(Guid userId);
    }
}
