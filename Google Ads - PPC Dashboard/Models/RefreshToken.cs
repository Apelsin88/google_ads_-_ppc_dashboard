using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!; // Navigation Property

        public string Token { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
