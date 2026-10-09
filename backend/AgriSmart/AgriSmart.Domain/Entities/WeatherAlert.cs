using System;
using System.Collections.Generic;
using System.Text;

namespace AgriSmart.Domain.Entities
{
   public class WeatherAlert 
    {
        public Guid Id { get; set; }
        public Guid FarmId { get; set; }
        public string AlertType { get; set; }= string.Empty;
        public string Severity { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string? RecommendedAction { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public Farm Farm { get; set; } = null!;

    }
}
