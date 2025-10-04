using agdata.Domain.Entities.user;
using agdata.Domain.Enums;
using agdata.Infrastructure;
using Agdata.Application.Interfaces;
using Application.Interfaces;
using Domain.Entities.User;
using Domain.Enums;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository; // repository for storing and retrieving users

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository; // inject user repository dependency
        }

        // Register a new user and add to repository
        public User RegisterUser(string name, string email, string employeeId, UserRole role = UserRole.Employee)
        {
            var user = new User
            {
                Id = Guid.NewGuid(), // generate unique ID
                Name = name,         // set user name
                Email = email,       // set user email
                EmployeeId = employeeId, // set employee ID
                Role = role          // set role
            };

            _userRepository.Add(user); // store new user
            return user; // return the created user
        }

        // Retrieve user by email
        public User GetUserByEmail(string email)
        {
            var user = _userRepository.GetByEmail(email);
            if (user == null) throw new Exception("User not found"); // throw error if user does not exist
            return user;
        }

        // Retrieve user by ID
        public User GetUserById(Guid id)
        {
            var user = _userRepository.GetById(id);
            if (user == null) throw new Exception("User not found"); // throw error if user does not exist
            return user;
        }

        // Get all registered users
        public IEnumerable<User> GetAllUsers() => _userRepository.GetAll();

        // Add reward points to a user
        public void AddPointsToUser(Guid userId, int points) => _userRepository.AddPoints(userId, points);

        // Redeem reward points from a user
        public void RedeemPointsFromUser(Guid userId, int points) => _userRepository.RedeemPoints(userId, points);
    }
}
