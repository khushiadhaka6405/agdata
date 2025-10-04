using agdata.Domain.Entities.User;
using agdata.Domain.Enums;
using agdata.Infrastructure;
using agdata.Infrastructure.Data.Repositories;
using agdata.Infrastructure.Repositories;
using Application.Interfaces;
using Application.Services;
using Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Project.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public async Task RegisterUser_ShouldCreateUserAndAccount()
        {
            // Arrange: Create in-memory repositories
            var userRepo = new InMemoryUserRepository();
            var accountRepo = new InMemoryUserAccountRepository();

            // Create service instance
            var service = new UserService(userRepo, accountRepo);

            // Act: Register user
            var user = await service.RegisterUserAsync(
                "Khushia",                   // Name
                "khushia6405@gmail.com",     // Email
                "EMP000",                    // EmployeeId
                UserRole.Employee            // Role enum
            );

            // Assert: Verify user creation
            Assert.NotNull(user);
            Assert.Equal("khushia6405@gmail.com", user.Email);

            // Verify account creation
            var account = await accountRepo.GetByUserIdAsync(user.Id);
            Assert.NotNull(account);
            Assert.Equal(0, account!.RewardBalance); // initial balance
        }
    }
}
