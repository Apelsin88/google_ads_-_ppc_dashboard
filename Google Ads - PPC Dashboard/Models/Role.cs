using System.Collections.Generic;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Role
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string NormalizedName { get; set; } = null!;

        // Many-to-Many with ApplicationUser
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
