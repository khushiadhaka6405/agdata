using agdata.Domain.Entities.Event;
using agdata.Domain.Entities.Product;
using agdata.Domain.Entities.Redemption;
using agdata.Domain.Entities.Transaction;
using agdata.Domain.Entities.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure.Data
{
    public static class InMemoryDatabase
    {
        public static List<User> Users { get; set; } = new();
        public static List<UserAccount> UserAccounts { get; set; } = new();
        public static List<Product> Products { get; set; } = new();
        public static List<Event> Events { get; set; } = new();
        public static List<Redemption> Redemptions { get; set; } = new();
        public static List<Transaction> Transactions { get; set; } = new();
    }
}
