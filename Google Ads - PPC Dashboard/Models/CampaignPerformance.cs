using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class CampaignPerformance
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public decimal Cost { get; set; }
        public int Conversions { get; set; }
        public decimal ConversionValue { get; set; }
    }
}
