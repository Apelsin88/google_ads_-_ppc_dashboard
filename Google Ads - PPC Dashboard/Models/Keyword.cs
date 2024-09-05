namespace Google_Ads___PPC_Dashboard.Models
{
    public class Keyword
    {
        public int KeywordId { get; set; }
        public int AdGroupId { get; set; } // Foreign Key to AdGroup
        public AdGroup AdGroup { get; set; } // Navigation Property
        public string Text { get; set; }
        public string MatchType { get; set; } // E.g., Exact, Phrase, Broad
    }
}
