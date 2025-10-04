using agdata.Domain.Entities.user;
using agdata.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Infrastructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>(); // in-memory storage

        public void Add(User user) => _users.Add(user); // add user

        public User GetById(Guid id) => _users.FirstOrDefault(u => u.Id == id); // find user by ID

        public User GetByEmail(string email) => _users.FirstOrDefault(u => u.Email == email); // find user by email

        public IEnumerable<User> GetAll() => _users; // return all users

        public void AddPoints(Guid userId, int points)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if (user == null) throw new Exception("User not found");
            user.Points += points; // add points
        }

        public void RedeemPoints(Guid userId, int points)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if (user == null) throw new Exception("User not found");
            if (user.Points < points) throw new Exception("Insufficient points");
            user.Points -= points; // redeem points
        }
    }
}
