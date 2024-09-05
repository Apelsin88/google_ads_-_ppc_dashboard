namespace Google_Ads___PPC_Dashboard.Models
{
    public class Budget
    {
        public int BudgetId { get; set; }
        public int CampaignId { get; set; } // Foreign Key to Campaign
        public Campaign Campaign { get; set; } // Navigation Property
        public decimal Amount { get; set; } // Total budget amount
        public decimal Spend { get; set; } // Amount spent so far
        public decimal RemainingBudget { get; set; }
        public DateTime Date { get; set; }
    }
}
