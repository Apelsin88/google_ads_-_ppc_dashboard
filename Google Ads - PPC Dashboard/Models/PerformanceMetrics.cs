namespace Google_Ads___PPC_Dashboard.Models
{
    public class PerformanceMetrics
    {
        public int MetricsId { get; set; }
        public int AdId { get; set; } // Foreign Key to Ad
        public Ad Ad { get; set; } // Navigation Property
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public int Conversions { get; set; }
        public decimal Cost { get; set; } // Total cost
        public decimal CTR { get; set; } // Click-Through Rate
        public decimal CPC { get; set; } // Cost Per Click
    }
}
