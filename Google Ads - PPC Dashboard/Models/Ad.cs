using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string GoogleAdId { get; set; }
        public int AdGroupId { get; set; } // Foreign Key to AdGroup
        public string AdType { get; set; } // E.g., Text, Display
        public string HeadlinePart1 { get; set; }
        public string HeadlinePart2 { get; set; }
        public string Description1 { get; set; }
        public string FinalUrl { get; set; }
        public string Status { get; set; } // E.g., Active, Paused
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set;}
    }
}
