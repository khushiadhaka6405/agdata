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
        void Add(User user); // add new user
        User GetById(Guid id); // get user by ID
        User GetByEmail(string email); // get user by email
        IEnumerable<User> GetAll(); // get all users
        void AddPoints(Guid userId, int points); // add points to user
        void RedeemPoints(Guid userId, int points); // redeem points from user
    }
}
