using agdata.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agdata.Domain.Entities.user
{

    public class User
    {
        public Guid Id { get; set; } // unique identifier
        public string Name { get; set; } // user name
        public string Email { get; set; } // user email
        public string EmployeeId { get; set; } // employee ID
        public UserRole Role { get; set; } // user role
        public int Points { get; set; } = 0; // reward points

        // Default constructor
        public User() { }

        // Optional: parameterized constructor
        public User(Guid id, string name, string email, string employeeId, UserRole role)
        {
            Id = id;
            Name = name;
            Email = email;
            EmployeeId = employeeId;
            Role = role;
        }
    }
}
