using agdata.Domain.Entities.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetByEmail(string email);
        User GetById(Guid id);
        IEnumerable<User> GetAll();
    }
}
