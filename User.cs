using System;

namespace CoffeeVendingMachine.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Initials => $"{FirstName?[0]}{LastName?[0]}";
    }
}