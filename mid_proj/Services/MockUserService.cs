using mid_proj.Models;
using mid_proj.Services;
using System.Collections.Generic;
using System.Linq;

namespace mid_project.Services
{
    
        public class MockUserService : IUserService
        {
            // Mock database (in-memory list)
            private List<User> _users = new List<User>();

            // Register a new user
            public bool Register(User user)
            {
                if (_users.Any(u => u.Email == user.Email))
                    return false; // Email already exists

                _users.Add(user);
                return true;
            }

            // Authenticate a user (login)
            public User Authenticate(string email, string password)
            {
                return _users.FirstOrDefault(
                    u => u.Email == email && u.Password == password
                );
            }

            // Optional: Add admin user during initialization
            public MockUserService()
            {
                // Seed an admin user for testing
                _users.Add(new User
                {
                    Email = "admin@school.com",
                    Password = "admin123",
                    Role = "Admin"
                });
            }
        }
    }
