namespace Google_Ads___PPC_Dashboard.Models
{
    public class Ad
    {
        public int AdId { get; set; }
        public int AdGroupId { get; set; } // Foreign Key to AdGroup
        public AdGroup AdGroup { get; set; } // Navigation Property
        public string Headline { get; set; }
        public string Description { get; set; }
        public string AdType { get; set; } // E.g., Text, Display
        public string URL { get; set; }
        public string Status { get; set; } // E.g., Active, Paused
    }
}
