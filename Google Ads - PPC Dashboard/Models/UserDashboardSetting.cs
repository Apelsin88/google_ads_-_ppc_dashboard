using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class UserDashboardSetting
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string WidgetType { get; set; }
        public int WidgetPosition { get; set; }
        public string WidgetSettings { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set;}

    }
}
