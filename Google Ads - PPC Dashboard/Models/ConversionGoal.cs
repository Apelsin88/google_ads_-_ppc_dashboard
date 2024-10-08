﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Google_Ads___PPC_Dashboard.Models
{
    public class ConversionGoal
    {
        public int ConversionGoalId { get; set; }

        public string Name { get; set; } = null!;

        public string Type { get; set; } = null!;

        public decimal Value { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
