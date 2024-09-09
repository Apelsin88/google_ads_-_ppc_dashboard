using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string GoogleCampaignId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // E.g., Active, Paused
        public decimal Budget { get; set; }
        public string BudgetType { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; } // Nullable in case it's ongoing
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
