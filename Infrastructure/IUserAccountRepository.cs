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
        void Add(UserAccount account);
        UserAccount GetByUserId(Guid userId);
    }
}
