using agdata.Domain.Entities.user;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public class InMemoryUserRepository : IUserRepository, IUserAccountRepository
    {
        public void Add(User user) => InMemoryDatabase.Users.Add(user);

        public User GetByEmail(string email) =>
            InMemoryDatabase.Users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        public User GetById(Guid id) =>
            InMemoryDatabase.Users.FirstOrDefault(u => u.Id == id);

        public IEnumerable<User> GetAll() => InMemoryDatabase.Users;

        public void Add(UserAccount account) => InMemoryDatabase.UserAccounts.Add(account);

        public UserAccount GetByUserId(Guid userId) =>
            InMemoryDatabase.UserAccounts.FirstOrDefault(a => a.UserId == userId);
    }
}
