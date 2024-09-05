namespace Google_Ads___PPC_Dashboard.Models
{
    public class AdGroup
    {
        public int AdGroupId { get; set; }
        public int CampaignId { get; set; } // Foreign Key to Campaign
        public Campaign Campaign { get; set; } // Navigation Property
        public string Name { get; set; }
        public string Status { get; set; } // E.g., Enabled, Paused
        public decimal BidAmount { get; set; }
        public string TargetKeywords { get; set; } // Could be a list of keywords
    }
}
