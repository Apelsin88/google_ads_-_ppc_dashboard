using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class AdGroup
    {
        public int Id { get; set; }
        public string? GoogleAdGroup { get; set; }
        public int CampaignId { get; set; } // Foreign Key to Campaign

        public Campaign Campaign { get; set; } = null!;

        public string? Name { get; set; }
        public string? Status { get; set; } // E.g., Enabled, Paused

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

        // Relationship: One-to-Many with Ads
        public ICollection<Ad> Ads { get; set; } = new List<Ad>();

        // Relationship: One-to-Many with Keywords
        public ICollection<Keyword> Keywords { get; set; } = new List<Keyword>();
    }
}
