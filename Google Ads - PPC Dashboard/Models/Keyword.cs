using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Keyword
    {
        public int Id { get; set; }
        public string GoogleKeywordId { get; set; }
        public int AdGroupId { get; set; } // Foreign Key to AdGroup
        public string KeywordText { get; set; }
        public string MatchType { get; set; } // E.g., Exact, Phrase, Broad
        public string Status { get; set; }
        public decimal? Bid { get; set; }
        public int? QualityScore { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set;}
    }
}
