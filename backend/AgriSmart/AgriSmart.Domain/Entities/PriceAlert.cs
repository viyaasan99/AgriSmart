using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
    public class PriceAlert
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CropType { get; set; } = string.Empty;
        public decimal TargetPrice { get; set; }
        public string Condition { get; set; } = "above";
        public bool IsActive { get; set; } = true;
        public DateTime? TriggeresAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public User User { get; set; } = null!;

    }
}
