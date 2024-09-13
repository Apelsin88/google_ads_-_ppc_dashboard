using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class UserDashboardSetting
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!; // Navigation Property

        public string WidgetType { get; set; } = null!;

        public int WidgetPosition { get; set; }

        public string WidgetSettings { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
