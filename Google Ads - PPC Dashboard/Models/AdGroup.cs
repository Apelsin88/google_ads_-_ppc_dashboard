using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class AdGroup
    {
        public int Id { get; set; }
        public string? GoogleAdGroup {  get; set; }
        public int CampaignId { get; set; } // Foreign Key to Campaign
        public string? Name { get; set; }
        public string? Status { get; set; } // E.g., Enabled, Paused
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set;}
    }
}
