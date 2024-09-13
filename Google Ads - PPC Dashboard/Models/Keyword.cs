using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Keyword
    {
        public int Id { get; set; }

        public string GoogleKeywordId { get; set; } = null!;

        public int AdGroupId { get; set; } // Foreign Key to AdGroup

        public AdGroup AdGroup { get; set; } = null!; // Navigation Property

        public string KeywordText { get; set; } = null!;

        public string MatchType { get; set; } = null!; // E.g., Exact, Phrase, Broad

        public string Status { get; set; } = null!;

        public decimal? Bid { get; set; }

        public int? QualityScore { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
