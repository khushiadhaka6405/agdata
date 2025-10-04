using agdata.Domain.Entities.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure.Repositories
{
        public class InMemoryUserAccountRepository : IUserAccountRepository
        {
            private readonly Dictionary<Guid, UserAccount> _accounts = new Dictionary<Guid, UserAccount>();

            public Task AddAsync(UserAccount account)
            {
                _accounts[account.UserId] = account;
                return Task.CompletedTask;
            }

            public Task<UserAccount> GetByUserIdAsync(Guid userId)
            {
                _accounts.TryGetValue(userId, out var account);
                return Task.FromResult(account);
            }

            public Task<IEnumerable<UserAccount>> GetAllAsync()
            {
                return Task.FromResult<IEnumerable<UserAccount>>(_accounts.Values);
            }
        }
}



