namespace Google_Ads___PPC_Dashboard.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // E.g., Active, Paused
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Nullable in case it's ongoing
        public string NetworkType { get; set; } // E.g., Search, Display
        public string TargetLocations { get; set; } // Could be a list of geo-targeting locations
    }
}
