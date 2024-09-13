using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class CustomReport
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!; // Navigation Property

        public string Name { get; set; } = null!;

        public string Configuration { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
