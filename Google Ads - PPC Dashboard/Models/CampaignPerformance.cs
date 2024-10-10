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

        public decimal GetClickThroughRate(int clicks, int impressions)
        {
            return clicks / impressions;
        }

        // kanske?
        public decimal GetConversionValue(int conversions, int clicks)
        {
            return conversions / clicks;
        }

        // Kanske?
        public decimal GetConversionValuePerCost(decimal conversionValue, decimal cost)
        {
            return conversionValue / cost;
        }

        public decimal GetCostPerConversion(decimal cost, int conversions)
        {
            return cost / conversions;
        }
    }
}
