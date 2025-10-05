using agdata.Domain.Entities.Event;
using agdata.Domain.Entities.Product;
using agdata.Domain.Entities.Redemption;
using agdata.Domain.Entities.Transaction;
using agdata.Domain.Entities.user;

using System.Collections.Generic;

namespace agdata.Infrastructure.Data
{
    public static class InMemoryDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Event> Events { get; set; } = new List<Event>();
        public static List<Redemption> Redemptions { get; set; } = new List<Redemption>();
        public static List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

