using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.user
{

    public class User 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string EmployeeId { get; private set; }
        public UserRole Role { get; private set; }
        public bool IsActive { get; private set; }
        public UserAccount Account { get; private set; }

        public User(string name, string email, string employeeId, UserRole role)
        {
            Name = name;
            Email = email;
            EmployeeId = employeeId;
            Role = role;
            IsActive = true;
            Account = new UserAccount();
        }

        public void Deactivate() => IsActive = false;
        public void Activate() => IsActive = true;
        public void UpdateRole(UserRole role) => Role = role;
    }
}
