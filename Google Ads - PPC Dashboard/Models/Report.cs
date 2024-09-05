namespace Google_Ads___PPC_Dashboard.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int UserId { get; set; } // Foreign Key to User
        public User User { get; set; } // Navigation Property
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Filters { get; set; } // JSON or string to represent filters
    }
}
