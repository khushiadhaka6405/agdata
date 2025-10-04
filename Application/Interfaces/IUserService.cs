using agdata.Domain.Entities.user;
using agdata.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agdata.Application.Interfaces
{
    public interface IUserService
    {
        User RegisterUser(string name, string email, string employeeId, UserRole role = UserRole.Employee);
        User GetByEmail(string email);
        User GetById(Guid id);
        IEnumerable<User> GetAll();
        void AddPoints(Guid userId, int points);
        void Redeem(Guid userId, Guid productId);
    }

}


