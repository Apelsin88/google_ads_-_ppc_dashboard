using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class Ad
    {
        public int Id { get; set; }

        public string GoogleAdId { get; set; } = null!;

        public int AdGroupId { get; set; } // Foreign Key to AdGroup

        [ValidateNever]
        public AdGroup AdGroup { get; set; } = null!; // Navigation Property

        public string AdType { get; set; } = null!; // E.g., Text, Display

        public string HeadlinePart1 { get; set; } = null!;

        public string HeadlinePart2 { get; set; } = null!;

        public string Description1 { get; set; } = null!;

        public string FinalUrl { get; set; } = null!;

        public string Status { get; set; } = null!; // E.g., Active, Paused

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
