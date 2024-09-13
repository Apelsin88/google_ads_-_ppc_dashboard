using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{

    public class ApplicationUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime? LastLogin { get; set; }

        // One-to-Many with CustomReport
        public ICollection<CustomReport> CustomReports { get; set; }
        // One-to-Many with UserDashboardsetting
        public ICollection<UserDashboardSetting> UserDashboardSettings { get; set; }
        // One-to-Many with RefreshToken
        public ICollection<RefreshToken> RefreshTokens { get; set; }
        // Many-to-Many with Role
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
