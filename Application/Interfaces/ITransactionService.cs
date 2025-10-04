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
        Transaction CreateTransaction(Guid userId, TransactionType type, int points);
        IEnumerable<Transaction> GetAllTransactions();
        Transaction GetTransactionById(Guid id);
        IEnumerable<Transaction> GetTransactionsByUserId(Guid userId);
    }
}
