using agdata.Domain.Entities.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface IUserAccountRepository
    {
        Task<UserAccount> GetByUserIdAsync(Guid userId);
        Task AddAsync(UserAccount account);
        Task<IEnumerable<UserAccount>> GetAllAsync();
    }
}
