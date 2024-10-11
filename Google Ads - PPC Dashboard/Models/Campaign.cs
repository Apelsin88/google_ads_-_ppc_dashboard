using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Campaign
    {
        public int Id { get; set; }

        public string GoogleCampaignId { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Status { get; set; } = null!; // E.g., Active, Paused

        public decimal Budget { get; set; }

        public string BudgetType { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; } // Nullable in case it's ongoing

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

        // Relationship: One-to-Many with AdGroups
        public ICollection<AdGroup> AdGroups { get; set; } = new List<AdGroup>();

        // One-to-Many with CampaignPerformance
        public ICollection<CampaignPerformance> Performances { get; set; } = new List<CampaignPerformance>();


        public int GetNumberOfAds()
        {
            int numberOfAds = 0;
            foreach (AdGroup adGroup in AdGroups)
            {
                numberOfAds += adGroup.Ads.Count;

            }
            return numberOfAds;
        }

        public decimal GetConversions()
        {
            decimal numberOfConversions = 0;
            foreach (CampaignPerformance performance in Performances)
            {
                numberOfConversions += performance.Conversions;
            }
            return numberOfConversions;
        }

        public decimal GetROAS()
        {

            decimal conversionValue = 0;
            decimal cost = 0;

            foreach (CampaignPerformance performance in Performances)
            {
                conversionValue += performance.ConversionValue;
                cost += performance.Cost;
            }

            decimal rOAS = conversionValue / cost;
            return rOAS;
        }
    }
}
