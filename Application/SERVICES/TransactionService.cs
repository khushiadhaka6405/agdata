using agdata.Application.Interfaces;
using agdata.Domain.Entities.Transaction; 
using agdata.Domain.Enums;
using agdata.Infrastructure;
using System;
using System.Collections.Generic;

namespace Services
{
    // Service layer for managing transactions
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository; // repository dependency

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository; // inject dependency
        }

        public Transaction CreateTransaction(Guid userId, TransactionType type, int points)
        {
            var t = new Transaction(userId, type, points);
            _transactionRepository.Add(t);
            return t;
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAll();
        }

        public Transaction GetTransactionById(Guid id)
        {
            var transaction = _transactionRepository.GetById(id);
            if (transaction == null) throw new Exception("Transaction not found");
            return transaction;
        }

        public IEnumerable<Transaction> GetTransactionsByUserId(Guid userId)
        {
            return _transactionRepository.GetByUserId(userId);
        }
    }
}
