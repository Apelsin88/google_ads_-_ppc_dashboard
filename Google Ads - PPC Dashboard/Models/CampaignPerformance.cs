using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class CampaignPerformance
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CampaignId { get; set; }

        public Campaign Campaign { get; set; } = null!; // Navigation Property

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Impressions { get; set; }

        public int Clicks { get; set; }

        public decimal Cost { get; set; }

        public int Conversions { get; set; }

        public decimal ConversionValue { get; set; }

        // Constructors
        public CampaignPerformance()
        {
        }

        public CampaignPerformance(int id, int campaignId, DateTime date, int impressions, int clicks, decimal cost, int conversions, decimal conversionValue)
        {
            Id = id;
            CampaignId = campaignId;
            Date = date;
            Impressions = impressions;
            Clicks = clicks;
            Cost = cost;
            Conversions = conversions;
            ConversionValue = conversionValue;
        }

        //https://www.youtube.com/watch?v=qP7tddwUGU4
        public decimal GetClickThroughRate(int clicks, int impressions)
        {
            return clicks / impressions;
        }

        //https://www.youtube.com/watch?v=qP7tddwUGU4
        ///i hans video var det conversions delat pa interactions
        public decimal GetConversionRate()
        {
            return Conversions / Impressions;
        }

        //https://www.youtube.com/watch?v=qP7tddwUGU4
        // kanske? Finns redan men sa har kan man fa fram det oxa
        public decimal GetConversionValue(int conversions, int clicks)
        {
            return conversions / clicks;
        }

        //https://www.youtube.com/watch?v=qP7tddwUGU4
        //https://dashthis.com/blog/most-important-google-ads-metrics/
        // Kanske? Return on Ad Spend (ROAS)
        public decimal GetConversionValuePerCost()
        {
            return ConversionValue / Cost;
        }

        //https://www.youtube.com/watch?v=qP7tddwUGU4
        public decimal GetCostPerConversion(decimal cost, int conversions)
        {
            return cost / conversions;
        }
    }
}
