using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class ApplicationUser
    {
        public string Id { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public bool IsActive { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime? LastLogin { get; set; }

        // One-to-Many with CustomReport
        public ICollection<CustomReport> CustomReports { get; set; } = new List<CustomReport>();

        // One-to-Many with UserDashboardSetting
        public ICollection<UserDashboardSetting> UserDashboardSettings { get; set; } = new List<UserDashboardSetting>();

        // One-to-Many with RefreshToken
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

        // Many-to-Many with Role
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
