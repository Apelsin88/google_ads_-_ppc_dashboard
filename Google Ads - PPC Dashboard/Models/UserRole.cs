using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{

    public class UserRole
    {
        [Key]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; }
        public string RoleId { get; set; } = null!;
        public Role Role { get; set; }
    }
}
