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
        User RegisterUser(string name, string email, string employeeId, UserRole role = UserRole.Employee); // register user
        User GetUserByEmail(string email); // get user by email
        User GetUserById(Guid id); // get user by ID
        IEnumerable<User> GetAllUsers(); // get all users
        void AddPointsToUser(Guid userId, int points); // add points to user
        void RedeemPointsFromUser(Guid userId, int points); // redeem points from user
    }

}


